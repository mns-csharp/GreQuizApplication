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
    public partial class DataGridViewDataBindingForm1 : Form
    {
        DataSet _dataSet = null;

        public DataGridViewDataBindingForm1()
        {
            InitializeComponent();

            WordBLL wordDatabase = new WordBLL();

            _dataSet = wordDatabase.GetDataSet();

            DataTable dataTable = _dataSet.Tables[0];

            dataGridView1.DataSource = dataTable;


            string filterString = string.Format("[{0}] LIKE '%{1}%'", "Name", textBox1.Text);

            dataTable.DefaultView.RowFilter = filterString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = _dataSet.Tables[0];

            string filterString = string.Format("[{0}] LIKE '%{1}%'", "Name", textBox1.Text);

            dataTable.DefaultView.RowFilter = filterString;
        }
    }
}
