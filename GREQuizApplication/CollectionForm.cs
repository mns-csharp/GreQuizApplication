


namespace QuizApplication
{
    using QuizApplicationLibrary;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Simple.Framework;
    using System.Drawing.Imaging;
    using QuizApplicationLibrary.BLL;
    using QuizApplicationLibrary.POCO;
    using Simple.Framework.Gui;
    using Simple.Framework.Orm;

    public partial class CollectionForm : BaseForm
    {
        private const int NAME_CELL_NO = 2;
        private const int TIMER_POLLING_INTERVAL = 50;
        private bool IsGuiReady = false;
        private MaxGroupBll _maxGroupDatabase = null;
        private WordBLL _wordDatabase = null;
        private DataGridViewSnapshot _dataGridViewSnapshot = null;
        //private SpeechSynthesizer _speak = null;

        public CollectionForm()
        {
            InitializeComponent();

            _maxGroupDatabase = new MaxGroupBll();
            _wordDatabase = new WordBLL();
            _dataGridViewSnapshot = new DataGridViewSnapshot();

            LoadGroupsInComboBox();
            LoadLearntInComboBox();

            InitializeSpeakSynthesizer();
            InitializeTimer();
        }

        #region component initializer
        private void LoadGroupsInComboBox()
        {
            groupComboBox.Items.Clear();

            int maxGroup = (int)_maxGroupDatabase.Get().GroupNo;

            for (int i = 0; i < maxGroup; i++)
            {
                groupComboBox.Items.Add(i + 1);
            }

            groupComboBox.SelectedIndex = 0;
        }

        private void LoadLearntInComboBox()
        {
            learntComboBox.Items.Clear();

            learntComboBox.Items.AddRange(Enum.GetNames(typeof(LearntTypeEnum)));

            learntComboBox.SelectedIndex = 0;
        }

        private void InitializeTimer()
        {
            textSearchTimer.Interval = 50;
            textSearchTimer.Tick += timer1_Tick;
        }

        void InitializeSpeakSynthesizer()
        {
            //_speak = new SpeechSynthesizer();
            //_speak.Volume = 100;
            //_speak.Rate = -5;// -10 to +10
            //_speak.SelectVoiceByHints(VoiceGender.Neutral);
        } 
        #endregion

        #region Learn tool tip
        private void learnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectGroupForm f = new SelectGroupForm(LearnFormTypeEnum.Random);
            f.ShowDialog();
        } 
        #endregion

        #region Load button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;

            Take_DataGridView_Snapshot();
            LoadToDataGridView();
            Restore_DataGridView_Snapshot();
        } 
        #endregion

        #region Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WordEntityForm f = new WordEntityForm(FormViewMode.Add, null);
            f.ItemStateChangeEvent += new ItemStateChanged(LoadToDataGridView);
            f.ShowDialog();

            SetFocusToWord(f.Word);

            f.Dispose();
        } 
        #endregion

        #region Set focus to the word
        void SetFocusToWord(int selectIndex)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (selectIndex > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectIndex].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = selectIndex;
                }
            }
        }

        void SetFocusToWord(Word concernedWord)
        {
            Console.WriteLine("SetFocusToWord()...");

            if (concernedWord != null)
            {
                int selectIndex = 0;

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    Word item = r.Tag as Word;

                    if (item != null)
                    {
                        if (concernedWord.Name == item.Name)
                        {
                            dataGridView1.Focus();
                            dataGridView1.CurrentCell = dataGridView1.Rows[selectIndex].Cells[0];
                            dataGridView1.FirstDisplayedScrollingRowIndex = selectIndex;
                            break;
                        }
                    }

                    selectIndex++;
                }
            }
        }

        void Take_DataGridView_Snapshot()
        {
            if (dataGridView1.Rows.Count > 1)
            {
                _dataGridViewSnapshot.FirstRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
                _dataGridViewSnapshot.SelectedRowIndex = dataGridView1.SelectedRows[0].Index;
            }
        }

        void Restore_DataGridView_Snapshot()
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = _dataGridViewSnapshot.FirstRowIndex;

            int selectIndex = _dataGridViewSnapshot.SelectedRowIndex;

            if (selectIndex <= dataGridView1.RowCount)
            {
                selectIndex = _dataGridViewSnapshot.SelectedRowIndex;
                dataGridView1.Rows[selectIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[selectIndex].Cells[0];
            }
        }
        #endregion

        #region Edit button click
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int selectIndex = selectedRow.Index;//dataGridView1.SelectedRows[0].Index;

                    if (selectedRow != null)
                    {
                        //Word item = selectedRow.Tag as Word;//Eats up too much memory
                        string wordName = Convert.ToString(selectedRow.Cells[NAME_CELL_NO].Value);
                        Word item = _wordDatabase.GetByName(wordName);

                        if (item != null)
                        {
                            Take_DataGridView_Snapshot();

                            LearntTypeEnum learntType = (LearntTypeEnum)learntComboBox.SelectedIndex;

                            WordEntityFormCopy f = new WordEntityFormCopy(FormViewMode.Edit, item, learntType);
                            f.ItemStateChangeEvent += new ItemStateChanged(LoadToDataGridView);
                            f.ShowDialog();

                            SetFocusToWord(selectIndex);
                            //dataGridView1.Rows[selectIndex].Selected = true;
                            
                            Restore_DataGridView_Snapshot();

                            f.Dispose();
                        }

                        item.Dispose();
                    }
                }
                else
                {
                    throw new Exception(SelectionErrorMessages.GetErrorMessageFor(typeof(Word)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

        #region Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (selectedRow != null)
                    {
                        string wordName = Convert.ToString(selectedRow.Cells[NAME_CELL_NO].Value);
                        Word item = _wordDatabase.GetByName(wordName);

                        if (item != null)
                        {
                            DialogResult res = MessageBox.Show("delete \'" + item.Name + "\' ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                            if (res == System.Windows.Forms.DialogResult.OK)
                            {
                                _wordDatabase.Delete(item);

                                LoadToDataGridView();
                            }
                        }

                        item.Dispose();

                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            int selectIndex = dataGridView1.SelectedRows[0].Index;
                            SetFocusToWord(selectIndex);
                        }
                    }
                }
                else
                {
                    throw new Exception(SelectionErrorMessages.GetErrorMessageFor(typeof(Word)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

        #region Close button click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region DataGridView double click
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        } 
        #endregion
        
        #region Text search
        private int timerCounter = TIMER_POLLING_INTERVAL;
        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            textSearchTimer.Stop();

            timerCounter = TIMER_POLLING_INTERVAL;                      
            
            textSearchTimer.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter--;

            if (timerCounter == 0)
            {
                LoadToDataGridView();

                searchTextBox.Focus();

                textSearchTimer.Stop();
            }
        }
        #endregion
        
        #region child data
        private void LoadToChildDataGridView()
        {
            Word item = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string wordName = Convert.ToString(selectedRow.Cells[NAME_CELL_NO].Value);
                item = _wordDatabase.GetByName(wordName);
            }

            if (item != null)
            {
                wordMeaningTextBox.Text = " " + item.Name + "  =  " +item.Meaning;
                richTextBox1.Text = item.Etymology;

                if (item.Photo != null)
                {
                    pictureBox1.Image = ConvertImage.ToImage(item.Photo);
                }
                else
                {
                    pictureBox1.Image = null;
                    //pictureBox1.Image.Dispose();
                }

                item.Dispose();
            }

            
        } 
        #endregion        

        #region Load to all data grid view
        void LoadToDataGridView()
        {
            dataGridView1.Rows.Clear();

            IList<Word> items = null;            

            string like = searchTextBox.Text;

            if (groupCheckBox.Checked || learntCheckBox.Checked)
            {
                LearntTypeEnum learntType = (LearntTypeEnum)learntComboBox.SelectedIndex;
                int groupNo = (int)groupComboBox.Items[groupComboBox.SelectedIndex];
                int correctness = InMemoryValues.CorrectnessRepetition;

                if(groupCheckBox.Checked && learntCheckBox.Checked)
                {
                    if (learntType == LearntTypeEnum.All)//all
                    {
                        items = _wordDatabase.GetByGroup(groupNo);//, like);
                    }
                    else if (learntType == LearntTypeEnum.NotLearnt)//not learnt
                    {
                        items = _wordDatabase.GetByCorrectnessBelow(groupNo, correctness);//, like);
                    }
                    else//learnt
                    {
                        items = _wordDatabase.GetByCorrectnessBeyond(groupNo, correctness);//, like);
                    }
                }
                else if (groupCheckBox.Checked)
                {
                    items = _wordDatabase.GetByGroup(groupNo);//, like);
                }
                else // if(learntCheckBox.Checked)
                {
                    if (learntType == LearntTypeEnum.All)//all
                    {
                        items = _wordDatabase.Get();//ByLike(like);
                    }
                    else if (learntType == LearntTypeEnum.NotLearnt)//not learnt
                    {
                        items = _wordDatabase.GetByCorrectnessBelow(correctness);//, like);
                    }
                    else//learnt
                    {
                        items = _wordDatabase.GetByCorrectnessBeyond(correctness);//, like);
                    }
                }
            }
            else
            {
                items = _wordDatabase.Get();
            }

            if (items != null)
            {
                if (items.Count > 0)
                {
                    ControlHelper.SuspendDrawing(dataGridView1);

                    int i = 0;
                    foreach (Word c in items)
                    {
                        dataGridView1.Rows.Add((i+1).ToString(), c.GroupNo, c.Name, c.CorrectnessCount, "Edit");
                                                
                        //dataGridView1.Rows[i].Tag = c;//Eats up excessive memory..........

                        if(c.CorrectnessCount>=InMemoryValues.CorrectnessRepetition)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                        else if (StringUtil.IsNullOrWhiteSpace(c.Meaning) || string.IsNullOrEmpty(c.Meaning))
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Firebrick;
                        }
                        else if (StringUtil.IsNullOrWhiteSpace(c.Etymology) || string.IsNullOrEmpty(c.Etymology))
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Crimson;
                        }
                        //else if(c.Photo == null)
                        //{
                        //    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        //}
                        //else if(c.Photo.Length <= 0)
                        //{
                        //    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        //}

                        ++i;

                        c.Dispose();
                    }

                    IList<Word> likes = _wordDatabase.GetByLike(like);

                    if(likes != null)
                    {
                        if(likes.Count > 0)
                        {
                            Word word = likes[0];

                            SetFocusToWord(word);

                            word.Dispose();
                        }
                    }

                    // clearing memory
                    if (likes != null)
                    {
                        likes.Clear();
                        likes = null;
                    }
                    totalRowsLabel.Text = items.Count.ToString();

                    ControlHelper.ResumeDrawing(dataGridView1);
                }
                else
                {
                    totalRowsLabel.Text = "0";
                }
            }
            else
            {
                totalRowsLabel.Text = "0";
            }

            // clearing memory
            if (items != null)
            {
                items.Clear();
                items = null;
            }
        } 
        #endregion

        //create context menu items when right click a data grid view
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LoadToChildDataGridView();
            }
            else if(me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ToolStripMenuItem mi = dataGridViewContextMenuStrip.Items[1] as ToolStripMenuItem;
                
                MaxGroup maxGroup = _maxGroupDatabase.Get();

                mi.DropDownItems.Clear();

                int skipGroup = (int)groupComboBox.SelectedItem;

                for (int i = 1; i <= maxGroup.GroupNo; i++)
                {
                    if (i == skipGroup) continue;

                    ToolStripMenuItem ii = new ToolStripMenuItem("Group " + i);
                    ii.Tag = i;
                    ii.Click += contextMenu_Click;                    
                    mi.DropDownItems.Add(ii);
                }

                dataGridViewContextMenuStrip.Show(dataGridView1, new Point(me.X, me.Y));
            }
        }

        //context menu click
        //DataGridView -> Right Click -> Learn/Unlearn
        private void learnUnlearnMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            if (selectedRows != null)
            {
                if (selectedRows.Count == 1)
                {
                    //Word item = selectedRows[0].Tag as Word;
                    string selectedWordName = (selectedRows[0].Cells[NAME_CELL_NO].Value).ToString();
                    
                    Word item = _wordDatabase.GetByName(selectedWordName);

                    if (item != null)
                    {
                        if (item.CorrectnessCount < InMemoryValues.CorrectnessRepetition)
                        {
                            item.CorrectnessCount = InMemoryValues.CorrectnessRepetition;
                        }
                        else
                        {
                            item.CorrectnessCount = 0;
                        }

                        _wordDatabase.Update(item);
                    }

                    item.Dispose();
                }
                // multiple words.
                // Simply change the CorrectnessIndex.
                else if (selectedRows.Count > 1)
                {
                    List<string> names = new List<string>();
                    StringBuilder sb = new StringBuilder();
                    int i = 0;
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string selectedName = Convert.ToString(row.Cells[NAME_CELL_NO].Value);

                        names.Add(selectedName);

                        if (!string.IsNullOrEmpty(selectedName) || !StringUtil.IsNullOrWhiteSpace(selectedName))
                        {
                            sb.Append("@Name" + i.ToString());
                            sb.Append(",");

                            i++;
                        }                      
                    }
                    sb.Remove(sb.Length - 1, 1);

                    LearnUnlearnForm f = new LearnUnlearnForm(sb.ToString());
                    f.ShowDialog();

                    if (f.ConvertType != LearntTypeEnum.All)
                    {
                        int groupNo = (int)groupComboBox.Items[groupComboBox.SelectedIndex];
                        int correctnessCount =  (f.ConvertType == LearntTypeEnum.Learnt) ? InMemoryValues.CorrectnessRepetition : 0;
                        string inClause = sb.ToString();

                        _wordDatabase.UpdateCorrectnessCount(groupNo, correctnessCount, inClause, names);
                    }
                }

                Take_DataGridView_Snapshot();
                LoadToDataGridView();
                Restore_DataGridView_Snapshot();
            }
        }

        // click "Go To -> Group XX"
        // Simply change the GroupNo
        void contextMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ii = sender as ToolStripMenuItem;

            int groupNo = (int)(ii.Tag);

            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;

            IList<string> values = new List<string>();
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach(DataGridViewRow r in rows)
            {
                string selectedName = Convert.ToString(r.Cells[NAME_CELL_NO].Value);

                if (!string.IsNullOrEmpty(selectedName) || !StringUtil.IsNullOrWhiteSpace(selectedName))
                {                    
                    sb.Append("@Name" + i.ToString());
                    sb.Append(",");

                    values.Add(selectedName);
                    i++;
                }
            }
            sb.Remove(sb.Length - 1, 1);

            string whereClause = sb.ToString();

            _wordDatabase.UpdateGroupNo(groupNo, whereClause, values);

            Take_DataGridView_Snapshot();
            LoadToDataGridView();
            Restore_DataGridView_Snapshot();

            string str = string.Empty;
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            LoadToChildDataGridView();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLearningForm f = new ManageLearningForm();
            f.ShowDialog();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm f = new StatisticsForm();
            f.ShowDialog();
        }

        private void manageGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGroupsForm f = new ManageGroupsForm();
            f.ShowDialog();
        }

        private void groupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupComboBox.Enabled = groupCheckBox.Checked;
            if (IsGuiReady)
            {
                Console.WriteLine("groupCheckBox_CheckedChanged()...");                

                LoadToDataGridView();
            }
        }

        private void groupComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (IsGuiReady)
            {
                Console.WriteLine("groupComboBox_SelectionChangeCommitted()...");
                LoadToDataGridView();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clearButton_Click()...");

            dataGridView1.Rows.Clear();
            searchTextBox.Text = string.Empty;
            pictureBox1.Image = null;
            wordMeaningTextBox.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }

        private void learntComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (IsGuiReady)
            {
                Console.WriteLine("learntComboBox_SelectionChangeCommitted()...");
                LoadToDataGridView();
            }
        }

        private void learnedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            learntComboBox.Enabled = learntCheckBox.Checked;

            if (IsGuiReady)
            {
                Console.WriteLine("learnedCheckBox_CheckedChanged()...");
                
                LoadToDataGridView();
            }
        }

        private void CollectionForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load()...");
            ApplicationData appData = InMemoryValues.ApplicationData;

            groupCheckBox.Checked = (bool)appData.GroupCheckBox___CollectionForm;
            groupComboBox.SelectedIndex = (int)appData.GroupComboBox___CollectionForm;
            learntCheckBox.Checked = (bool)appData.LearntCheckBox____CollectionForm;
            learntComboBox.SelectedIndex = (int)appData.LearntComboBox____CollectionForm;
            searchTextBox.Text = appData.FilterTextBox____CollectionForm;

            LoadToDataGridView();

            dataGridView1.FirstDisplayedScrollingRowIndex = (int)appData.LastTopWordIndex____CollectionForm;
            int selectIndex = (int)appData.LastSelectedWordIndex____CollectionForm;
            dataGridView1.Rows[selectIndex].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[selectIndex].Cells[0];

            IsGuiReady = true;
        }

        private void CollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationData appData = InMemoryValues.ApplicationData;
            appData.GroupCheckBox___CollectionForm = groupCheckBox.Checked;
            appData.GroupComboBox___CollectionForm = groupComboBox.SelectedIndex;
            appData.LearntCheckBox____CollectionForm = learntCheckBox.Checked;
            appData.LearntComboBox____CollectionForm = learntComboBox.SelectedIndex;
            appData.FilterTextBox____CollectionForm = searchTextBox.Text;
            appData.LastTopWordIndex____CollectionForm = (int)dataGridView1.FirstDisplayedScrollingRowIndex;
            appData.LastSelectedWordIndex____CollectionForm = (int)dataGridView1.SelectedRows[0].Index;
            appData.OrderBy_____CollectionForm = (int)GetCheckedBox();

            InMemoryValues.ApplicationData = appData;
            InMemoryValues.Save();
        }

        private OrderByTypeEnum GetCheckedBox()
        {
            if (radioButton1.Checked) return OrderByTypeEnum.GroupNo;
            if (radioButton2.Checked) return OrderByTypeEnum.Name;
            if (radioButton3.Checked) return OrderByTypeEnum.CorrectnessCount;
            return OrderByTypeEnum.None;
        }

        private void dataGridViewContextMenuStrip_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
        }

        private void flashCardToolTipItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);

            SelectGroupForm f = new SelectGroupForm(LearnFormTypeEnum.FlachCard);
            f.ShowDialog();


            int GROUP_NO = f.GroupNo;

            FlashCardForm ff = new FlashCardForm(GROUP_NO);
            ff.ItemStateChangeEvent += ff_ItemStateChangeEvent;
            ff.ShowDialog();
        }

        void ff_ItemStateChangeEvent()
        {
            Take_DataGridView_Snapshot();
            LoadToDataGridView();
            Restore_DataGridView_Snapshot();
        }

        private void readTextGlassButton_Click(object sender, EventArgs e)
        {
            string wordToRead = string.Empty;

            if(dataGridView1.Rows != null)
            {
                if(dataGridView1.Rows.Count > 1)
                {
                    wordToRead = Convert.ToString( dataGridView1.SelectedRows[0].Cells[2].Value);
                }
            }

            string textToRead = richTextBox1.Text;
           
            //_speak.SpeakAsync(textToRead);
        }

        private void stopGlassButton_Click(object sender, EventArgs e)
        {
            //_speak.SpeakAsyncCancelAll();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Word item = dataGridView1.SelectedRows[0].Tag as Word;

            if (item != null)
            {                
                new PictureBoxForm(ConvertImage.ToImage(item.Photo)).ShowDialog();
            }
        }

        // Row-button click 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                //_speak.SpeakAsync(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                btnEdit_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                
            }
            else if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!string.IsNullOrEmpty(richTextBox1.SelectedText) || !StringUtil.IsNullOrWhiteSpace(richTextBox1.SelectedText))
                {
                    rtbContextMenuStrip1.Show(richTextBox1, new Point(me.X, me.Y));
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void resetGlassButton_Click(object sender, EventArgs e)
        {
            if (groupCheckBox.Checked || learntCheckBox.Checked)
            {
                DataGridViewRowCollection rows = dataGridView1.Rows;

                IList<string> names = new List<string>();
                StringBuilder sb = new StringBuilder();
                int i = 0;
                foreach (DataGridViewRow r in rows)
                {
                    string selectedName = Convert.ToString(r.Cells[NAME_CELL_NO].Value);

                    if (!string.IsNullOrEmpty(selectedName) || !StringUtil.IsNullOrWhiteSpace(selectedName))
                    {
                        sb.Append("@Name" + i.ToString());
                        sb.Append(",");

                        names.Add(selectedName);
                        i++;
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                string whereClause = sb.ToString();

                LearntTypeEnum learntType = (LearntTypeEnum)learntComboBox.SelectedIndex;
                int groupNo = (int)groupComboBox.Items[groupComboBox.SelectedIndex];
                int CorrectnessCount = 0;
                _wordDatabase.UpdateCorrectnessCount(groupNo, CorrectnessCount, whereClause, names);

                Take_DataGridView_Snapshot();
                LoadToDataGridView();
                Restore_DataGridView_Snapshot();

                string str = string.Empty;
            }
        }

        private void resetMaxGlassButton_Click(object sender, EventArgs e)
        {
            if (groupCheckBox.Checked || learntCheckBox.Checked)
            {
                DataGridViewRowCollection rows = dataGridView1.Rows;

                IList<string> names = new List<string>();
                StringBuilder sb = new StringBuilder();
                int i = 0;
                foreach (DataGridViewRow r in rows)
                {
                    string selectedName = Convert.ToString(r.Cells[NAME_CELL_NO].Value);

                    if (!string.IsNullOrEmpty(selectedName) || !StringUtil.IsNullOrWhiteSpace(selectedName))
                    {
                        sb.Append("@Name" + i.ToString());
                        sb.Append(",");

                        names.Add(selectedName);
                        i++;
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                string whereClause = sb.ToString();

                LearntTypeEnum learntType = (LearntTypeEnum)learntComboBox.SelectedIndex;
                int groupNo = (int)groupComboBox.Items[groupComboBox.SelectedIndex];
                int CorrectnessCount = InMemoryValues.CorrectnessRepetition;
                _wordDatabase.UpdateCorrectnessCount(groupNo, CorrectnessCount, whereClause, names);

                Take_DataGridView_Snapshot();
                LoadToDataGridView();
                Restore_DataGridView_Snapshot();

                string str = string.Empty;
            }
        }
    }
}