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
namespace QuizApplication
{
    public partial class ManageLearningForm : Form
    {
        private readonly int CORRECTNESS_COUNT; 
        private WordBLL _wordDatabase = null; 

        public ManageLearningForm()
        {
            InitializeComponent();

            CORRECTNESS_COUNT = InMemoryValues.CorrectnessRepetition;

            _wordDatabase = new WordBLL();

            IList<Word> notYetLearnt = _wordDatabase.GetByCorrectnessBelow(CORRECTNESS_COUNT);
            IList<Word> alreadyLearnt = _wordDatabase.GetByCorrectnessBeyond(CORRECTNESS_COUNT);

            if (notYetLearnt != null)
            {
                if (notYetLearnt.Count > 0)
                {
                    foreach (Word w in notYetLearnt)
                    {
                        yetToLearnListBox.Items.Add(w);
                    }

                    yetToLearnListBox.DisplayMember = "Name";
                    yetToLearnListBox.ValueMember = "ID";
                }
            }

            if (alreadyLearnt != null)
            {
                if (alreadyLearnt.Count > 0)
                {
                    foreach (Word w in alreadyLearnt)
                    {
                        alreadyLearntListBox.Items.Add(w);
                    }

                    alreadyLearntListBox.DisplayMember = "Name";
                    alreadyLearntListBox.ValueMember = "ID";
                }
            }
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            Object obj = yetToLearnListBox.SelectedItem;
            yetToLearnListBox.Items.Remove(obj);

            Word item = obj as Word;
            item.CorrectnessCount = InMemoryValues.CorrectnessRepetition;

            _wordDatabase.Update(item);

            IList<Word> alreadyLearnt = _wordDatabase.GetByCorrectnessBeyond(CORRECTNESS_COUNT);

            if (alreadyLearnt != null)
            {
                if (alreadyLearnt.Count > 0)
                {
                    alreadyLearntListBox.Items.Clear();

                    foreach (Word w in alreadyLearnt)
                    {
                        alreadyLearntListBox.Items.Add(w);
                    }
                }
            }
        }
    }
}
