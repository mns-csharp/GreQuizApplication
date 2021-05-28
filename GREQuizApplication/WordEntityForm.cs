using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Simple.Framework;
using QuizApplicationLibrary;
using QuizApplicationLibrary.POCO;
using QuizApplicationLibrary.BLL;

namespace QuizApplication
{
    public partial class WordEntityForm : BaseForm
    {
        public Word Word { get; set; }
        private MaxGroupBll _maxGroupDatabase = null;        
        private WordBLL _wordDatabase = null;
        private FormViewMode _formViewMode = FormViewMode.Nothing;
        //private Word _greWord = null;
        private IList<Word> _wordList = null;
        private int CURRENT_WORD_INDEX = -99;

        public WordEntityForm(FormViewMode formViewMode, Word item)
        {
            InitializeComponent();

            _maxGroupDatabase = new MaxGroupBll();            
            _wordDatabase = new WordBLL();

            _wordList = _wordDatabase.Get();
            
            CURRENT_WORD_INDEX = _wordList.IndexOf(item);


            _formViewMode = formViewMode;

            LoadGroups();

            if (formViewMode == FormViewMode.Edit)
            {
                groupComboBox.Enabled = true;
                correctnessTextBox.Enabled = true;
                MapObjectToControls(item);
            }
            else
            {
                EntityForm_Load();
            }
        }        

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
                    item = _wordList[CURRENT_WORD_INDEX];//_greWord;
                }

                MaxGroup mg = _maxGroupDatabase.Get();

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
                item.Hint = hintTextBox.Text;
                item.Meaning = meaningTextBox.Text;
                item.Synonyms = synonymsTextBox.Text;
                item.Etymology = etymologyTestBox.Text;
                item.ExampleEnglishSentence = exampleTextBox.Text;

                if (photoPictureBox.Image != null)
                {
                    item.Photo = ConvertImage.ToByteArray(photoPictureBox.Image);
                }

                int returns = -99;

                if (item.ID == null)
                {
                    returns  = _wordDatabase.Save(item);
                }
                else
                {
                    returns = _wordDatabase.Update(item);
                }

                Word = item;

                OnItemStateChanged();

                if (_formViewMode == FormViewMode.Add)
                {
                    ClearControls();
                    //this.Close();
                }
                if (_formViewMode == FormViewMode.Edit)
                {
                    //MessageBox.Show(returns.ToString());

                    this.Close();
                }

                lastEnteredWordLabel.Text = item.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGroups()
        {
            groupComboBox.Items.Clear();

            int maxGroup = (int)_maxGroupDatabase.Get().GroupNo;

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
                hintTextBox.Text = item.Hint;
                meaningTextBox.Text=item.Meaning;

                synonymsTextBox.Text = item.Synonyms;
                etymologyTestBox.Text= item.Etymology;
                exampleTextBox.Text = item.ExampleEnglishSentence;
                photoPictureBox.Image = ConvertImage.ToImage(item.Photo);

                //Clipboard.GetImage()
            }
        }

        private void ClearControls()
        {
            _formViewMode = FormViewMode.Add;

            //groupComboBox.SelectedIndex = 0;
            correctnessTextBox.Text = "0";
            nameTextBox.Text = string.Empty;
            hintTextBox.Text = string.Empty;
            meaningTextBox.Text = string.Empty;            
            synonymsTextBox.Text = string.Empty;
            etymologyTestBox.Text = string.Empty;
            exampleTextBox.Text = string.Empty;
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

                Word item = _wordDatabase.GetByName(word);

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
    }
}
