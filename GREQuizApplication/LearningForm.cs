using QuizApplicationLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizApplicationLibrary.BLL;
using QuizApplicationLibrary.POCO;
using Simple.Framework.Orm;

namespace QuizApplication
{
    public partial class LearningForm : Form
    {
        private readonly int GROUP_NO;
        private readonly int MULTIPLE_CHOICE_COUNT;
        private readonly int CORRECTNESS_REPETITION;
        WordBLL _wordDatabase = null;
        private IList<Word> _list = null;
        IList<Word> _selectedWords = null;

        public LearningForm(int groupNo)
        {
            InitializeComponent();

            GROUP_NO = groupNo;
            MULTIPLE_CHOICE_COUNT = InMemoryValues.MultipleChoiceCount;
            CORRECTNESS_REPETITION = InMemoryValues.CorrectnessRepetition;
            
            _wordDatabase = new WordBLL();            

            StartLearning();
        }

        int _questionIndex = 0;

        private void StartLearning()
        {
            if (_list != null)
            {
                _list.Clear();
                _list = null;
            }

            _list = _wordDatabase.GetByCorrectnessBelow(GROUP_NO, CORRECTNESS_REPETITION);            
            
            if (_list != null)
            {
                ShuffleList.Shuffle<Word>(_list);
                ShuffleList.Shuffle<Word>(_list);

                if (_list.Count > 0)
                {
                    showAnswersButton.Enabled = true;
                    groupBox1.Visible = false;

                    toolStripStatusLabel2.Text = _list.Count.ToString();
                    
                    if (_selectedWords != null)
                    {
                        _selectedWords.Clear();
                        _selectedWords = null;
                    }

                    int selWorCout = (_list.Count < MULTIPLE_CHOICE_COUNT)? _list.Count : MULTIPLE_CHOICE_COUNT;
                    _selectedWords = new List<Word>(selWorCout);

                    int x = 30, y = 50;

                    groupBox1.Controls.Clear();

                    //Select a random word from 5
                    //to ask a question.
                    URandom randomQuestion = new URandom();
                    _questionIndex = randomQuestion.Next(0, selWorCout);

                    //Obtain 5 random words from _list
                    //Create 5 buttons and 5 labels
                    URandom randomWord = new URandom();
                    for (int i = 0; i < selWorCout; i++)
                    {
                        //Obtain a random index
                        int listIndex = randomWord.Next(0, _list.Count);
                        Word item = _list[listIndex];
                        _selectedWords.Add(item);

                        //Create a button
                        Button b = new Button();
                        b.Tag = i;
                        b.Text = item.Meaning.ToLower()+" ("+ item.CorrectnessCount.ToString()+")" ;
                        b.Size = new System.Drawing.Size(375, 45);
                        b.Font = new System.Drawing.Font("Calibri", 18);
                        b.Location = new Point(x, y);
                        b.AutoSize = false;
                        b.TextAlign = ContentAlignment.MiddleCenter;
                        b.MouseClick += wordButton_MouseClick;
                        groupBox1.Controls.Add(b);                        

                        y = y + 54;
                    }

                    ResetAnswerButtonColors();
                    EnableButtons(true);
                    
                    Word w = _selectedWords[_questionIndex];

                    answerTextBox.Tag = w;
                    answerTextBox.Text = w.Name.ToLower();
                }
                else
                {
                    CongratulationsForm f = new CongratulationsForm("Group #1");
                    f.ShowDialog();

                    this.Close();
                }
            }
            else
            {
                CongratulationsForm f = new CongratulationsForm("Group #1");
                f.ShowDialog();

                this.Close();
            }
        }

        

        void wordButton_MouseClick(object sender, MouseEventArgs e)
        {
            showAnswersButton.Enabled = false;

            Button correctButton = (Button)(groupBox1.Controls[_questionIndex]);
            Button clickedButton = (Button)sender;

            int clickedBtnIndex = ((int)(clickedButton).Tag);
            
            EnableButtons(false);          
            MarkCorrectAnswer(_questionIndex, clickedBtnIndex);

            Word clickedWord = _selectedWords[clickedBtnIndex];
            Word correctWord = _selectedWords[_questionIndex];

            if (_questionIndex == clickedBtnIndex)
            {
                clickedWord.CorrectnessCount++;
                _wordDatabase.Update(clickedWord);
            }
            else
            {
                correctWord.CorrectnessCount = 0;
                clickedWord.CorrectnessCount = 0;

                _wordDatabase.Update(correctWord);
                _wordDatabase.Update(clickedWord);
            }

            correctButton.Text = correctWord.Meaning.ToLower() + " (" + correctWord.CorrectnessCount + ")";
            clickedButton.Text = clickedWord.Meaning.ToLower() + " (" + clickedWord.CorrectnessCount + ")";

            if (clickedWord.CorrectnessCount >= CORRECTNESS_REPETITION)
            {
                CongratulationsForm f = new CongratulationsForm(correctWord.Name);
                f.ShowDialog();
            }

            nextButton.Enabled = true;
        }        

        private void nextButton_Click(object sender, EventArgs e)
        {
            //nextButton.Enabled = false;
            
            
            StartLearning();            
        }

        private void ResetAnswerButtonColors()
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.BackColor = SystemColors.Control;
                c.ForeColor = SystemColors.ControlText;
            }
        }

        int [] UpdateWordCount(Word correctWord, Word clickedWord, int correctAnswerIndex, int selectedIndex)
        {
            return new int[] { correctWord.CorrectnessCount, clickedWord.CorrectnessCount };
        }

        void MarkCorrectAnswer(int correctIndex, int selectedIndex)
        {
            Color green = Color.Green;
            Color red = Color.Red;

            if (correctIndex == selectedIndex)
            {
                groupBox1.Controls[correctIndex].BackColor = green;

                groupBox1.Controls[correctIndex].ForeColor = SystemColors.Info;
            }
            else
            {
                groupBox1.Controls[correctIndex].BackColor = green;
                groupBox1.Controls[selectedIndex].BackColor = red;

                groupBox1.Controls[correctIndex].ForeColor = SystemColors.Info;
            }
        }

        void EnableButtons(bool enable)
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = enable;
            }
        }

        private void manageWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLearningForm f = new ManageLearningForm();
            f.ShowDialog();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGroupsForm f = new ManageGroupsForm();
            f.ShowDialog();
        }

        private void showAnswersButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            showAnswersButton.Enabled = false;
        }

        private void answerTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (nextButton.Enabled)
            {
                if (answerTextBox.Tag != null)
                {
                    Word item = answerTextBox.Tag as Word;

                    WordEntityForm f = new WordEntityForm(FormViewMode.Edit, item);
                    f.ShowDialog();

                    answerTextBox.Tag = f.Word;
                }
            }
        }
    }
}
