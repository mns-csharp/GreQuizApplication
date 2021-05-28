using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Simple.Framework;


namespace QuizApplication
{
    using QuizApplicationLibrary;
    using QuizApplicationLibrary.BLL;
    using QuizApplicationLibrary.POCO;
    public partial class WordEntityFormCopy : BaseForm
    {
        //public Word Word { get; set; }
        private FormViewMode _formViewMode = FormViewMode.Nothing;
        //private Word _greWord = null;
        private IList<Word> _wordList = null;
        private int CURRENT_WORD_INDEX = -99;
        private Word _item = null;
        private LearntTypeEnum _learntType;

        public WordEntityFormCopy(FormViewMode formViewMode, Word item, LearntTypeEnum learnType)
        {
            InitializeComponent();


            WordBLL wordDatabase = new WordBLL();
            _wordList = wordDatabase.Get();
            wordDatabase.Dispose();
            
            
            CURRENT_WORD_INDEX = _wordList.IndexOf(item);


            _formViewMode = formViewMode;

            LoadGroups();

            if (formViewMode == FormViewMode.Edit)
            {
                _item = item;
                _learntType = learnType;
                groupComboBox.Enabled = true;
                correctnessTextBox.Enabled = true;
                MapObjectToControls(item);
            }
            else
            {
                EntityForm_Load();
            }
        }

        #region Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Word item = null;

                if (_formViewMode == FormViewMode.Add)
                {
                    item = new Word();
                }
                else if (_formViewMode == FormViewMode.Edit)
                {
                    item = _item;
                }

                MaxGroupBll _maxGroupDatabase = new MaxGroupBll();
                MaxGroup mg = _maxGroupDatabase.Get();
                _maxGroupDatabase.Dispose();

                Random random = new Random();

                item.GroupNo = (int)groupComboBox.SelectedItem;

                if (_formViewMode == FormViewMode.Add)
                {
                    item.CorrectnessCount = 0;
                }
                else
                {
                    item.CorrectnessCount = Convert.ToInt32(correctnessTextBox.Text);
                }

                item.Name = StringHelpers.ToSentanceCase(nameTextBox.Text, ' ');
                //item.Hint = hintTextBox.Text;
                item.Meaning = banglaMeaningTextBox.Text;
                //item.Synonyms = synonymsTextBox.Text;
                item.Etymology = exampleTextBox.Text;
                //item.ExampleEnglishSentence = exampleTextBox.Text;

                if (photoPictureBox.Image != null)
                {
                    item.Photo = ConvertImage.ToByteArray(photoPictureBox.Image);
                }

                int returns = -99;

                WordBLL wordDatabase = new WordBLL();
                if (item.ID == null)
                {                    
                    returns = wordDatabase.Save(item);
                }
                else
                {
                    returns = wordDatabase.Update(item);
                }
                wordDatabase.Dispose();

                //Word item;

                OnItemStateChanged();

                if (_formViewMode == FormViewMode.Add)
                {
                    ClearControls();
                    //this.Close();
                }
                if (_formViewMode == FormViewMode.Edit)
                {
                    goToRightButton_Click(sender, e);
                }

                lastEnteredWordLabel.Text = item.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        private void LoadGroups()
        {
            groupComboBox.Items.Clear();

            MaxGroupBll _maxGroupDatabase = new MaxGroupBll();
            int maxGroup = (int)_maxGroupDatabase.Get().GroupNo;
            _maxGroupDatabase.Dispose();

            for(int i=0 ; i<maxGroup ; i++)
            {
                groupComboBox.Items.Add(i+1);
            }

            groupComboBox.SelectedIndex = 0;
        }

        private void MapObjectToControls(Word item)
        {
            if (item != null)
            {
                if(item.CorrectnessCount >= InMemoryValues.CorrectnessRepetition)
                {
                    learntCheckBox.Checked = true;
                }
                else
                {
                    learntCheckBox.Checked = false;
                }

                groupComboBox.SelectedItem = item.GroupNo;
                correctnessTextBox.Text = item.CorrectnessCount.ToString();
                nameTextBox.Text=item.Name;
                //hintTextBox.Text = item.Hint;
                banglaMeaningTextBox.Text=item.Meaning;

                //synonymsTextBox.Text = item.Synonyms;
                exampleTextBox.Text= item.Etymology;
                //exampleTextBox.Text = item.ExampleEnglishSentence;

                WordBLL wordDatabase = new WordBLL();
                Word temp = wordDatabase.GetByName(item.Name);
                if(temp.Photo!=null)
                {
                    photoPictureBox.Image = ConvertImage.ToImage(temp.Photo);
                }
                //Clipboard.GetImage()
            }
        }

        private void ClearControls()
        {
            _formViewMode = FormViewMode.Add;

            //groupComboBox.SelectedIndex = 0;
            correctnessTextBox.Text = "0";
            nameTextBox.Text = string.Empty;
            //hintTextBox.Text = string.Empty;
            banglaMeaningTextBox.Text = string.Empty;            
            //synonymsTextBox.Text = string.Empty;
            exampleTextBox.Text = string.Empty;
            //exampleTextBox.Text = string.Empty;
            photoPictureBox.Image = null;

            nameTextBox.Focus();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();

            //string selectedFileName = openFileDialog1.FileName;

            //photoPictureBox.ImageLocation = selectedFileName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //btnSave_Click(sender, e);
            this.Close();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            groupComboBox.SelectedIndex = 0;
        }

        private void btnSelectPhoto_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string selectedFileName = openFileDialog1.FileName;

            photoPictureBox.ImageLocation = selectedFileName;
        }

        private void EntityForm_Load()
        {
            Console.WriteLine("Load()...");
            ApplicationData appData = InMemoryValues.ApplicationData;
            
            groupComboBox.SelectedIndex = (int)appData.LastSelectedGroup____EntityForm;
            lastEnteredWordLabel.Text = appData.LastEnteredWord____EntityForm;
        }

        private void EntityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationData appData = InMemoryValues.ApplicationData;
            appData.LastSelectedGroup____EntityForm = groupComboBox.SelectedIndex;
            appData.LastEnteredWord____EntityForm = lastEnteredWordLabel.Text;

            InMemoryValues.ApplicationData = appData;
            InMemoryValues.Save();
        }

        private void learntCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(learntCheckBox.Checked)
            {
                correctnessTextBox.Text = InMemoryValues.CorrectnessRepetition.ToString();
            }
            else
            {
                correctnessTextBox.Text = "0";
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_formViewMode == FormViewMode.Add)
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) || StringUtil.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    nameTextBox.BackColor = SystemColors.Window;
                }

                string word = nameTextBox.Text.Trim();

                WordBLL _wordDatabase = new WordBLL();
                Word item = _wordDatabase.GetByName(word);
                _wordDatabase.Dispose();

                if (item != null)//word already exists
                {
                    nameTextBox.BackColor = Color.Firebrick;
                }
                else//word is new
                {
                    nameTextBox.BackColor = SystemColors.Window;
                }
            }
        }

        private void goToRightButton_Click(object sender, EventArgs e)
        {
            WordBLL _wordDatabase = new WordBLL();
            IList<Word> list = _wordDatabase.GetByLearnt((int)_item.GroupNo, _learntType);
            _wordDatabase.Dispose();

            int index = list.IndexOf(_item);

            if (index < list.Count-1)
            {
                Word newWord = list[index + 1];

                //////////////////////////////
                _item = newWord;
                MapObjectToControls(newWord);
            }
            else
            {
                MessageBox.Show("End of list reached!", ">>", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void goToLeftButton_Click(object sender, EventArgs e)
        {
            WordBLL _wordDatabase = new WordBLL();
            IList<Word> list = _wordDatabase.GetByLearnt((int)_item.GroupNo, _learntType);
            _wordDatabase.Dispose();

            int index = list.IndexOf(_item);

            if (index > 0)
            {
                Word newWord = list[index - 1];

                //////////////////////////////
                _item = newWord;
                MapObjectToControls(newWord);
            }
            else
            {
                MessageBox.Show("Beginning of list reached!", "<<", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
