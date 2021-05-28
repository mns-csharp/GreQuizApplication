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
using Simple.Framework;
namespace QuizApplication
{
    public partial class SelectGroupForm : BaseForm
    {
        public int GroupNo { get; set; }
        private WordBLL _wordDatabase = new WordBLL();
        private MaxGroupBll _maxGroupDatabase = new MaxGroupBll();
        private MaxGroup _maxGroupItem = null;
        private LearnFormTypeEnum _formType;

        public SelectGroupForm(LearnFormTypeEnum learnFormType)
        {
            InitializeComponent();

            _maxGroupItem = _maxGroupDatabase.Get();
            _formType = learnFormType;

            GroupNo = 1;

            LoadToListBox();
        }

        void LoadToListBox()
        {
            for (int i = 1; i <= _maxGroupItem.GroupNo; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            GroupNo = (Int32)listBox1.SelectedItem;


            this.Close();
            //OnItemStateChanged();
        }
    }
}
