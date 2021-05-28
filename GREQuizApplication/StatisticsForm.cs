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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();

            int repetition = InMemoryValues.CorrectnessRepetition;

            WordBLL wordDatabase = new WordBLL();

            IList<Word> total = wordDatabase.Get();
            if(total !=null)
            {
                label4.Text = total.Count.ToString();
            }

            IList<Word> learnt = wordDatabase.GetByCorrectnessBeyond(repetition);
            if (learnt != null)
            {
                label5.Text = learnt.Count.ToString();
            }

            IList<Word> yetToLearn = wordDatabase.GetByCorrectnessBelow(repetition);
            if (yetToLearn != null)
            {
                label6.Text = yetToLearn.Count.ToString();
            }
        }
    }
}
