using QuizApplicationLibrary.BLL;
using QuizApplicationLibrary.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathPracticeApplication
{
    public partial class AssociateQuestionsWithTestsForm : Form
    {
        private QuantitativeProblemBLL _quantitativeProblemDatabase = null;
        private QuantTestBLL _quantTestDatabase = null;

        public AssociateQuestionsWithTestsForm()
        {
            InitializeComponent();

            _quantitativeProblemDatabase = new QuantitativeProblemBLL();
            _quantTestDatabase = new QuantTestBLL();

            LoadQuantProblems();
            LoadQuantTests();
        }

        private void LoadQuantTests()
        {
            listBox1.Items.Clear();

            IList<QuantTest> list = _quantTestDatabase.Get();

            foreach (QuantTest item in list)
            {
                listBox1.Items.Add(item);
            }

            listBox1.DisplayMember = "ID";
            listBox1.ValueMember = "ID";
        }

        private void LoadQuantProblems()
        {
            checkedListBox1.Items.Clear();

            IList<QuantitativeProblem> list = _quantitativeProblemDatabase.Get();

            foreach (QuantitativeProblem item in list)
            {
                checkedListBox1.Items.Add(item);
            }

            ListBox clb = (ListBox)checkedListBox1;

            clb.DisplayMember = "ProblemText";
            clb.ValueMember = "ID";
        }
    }
}
