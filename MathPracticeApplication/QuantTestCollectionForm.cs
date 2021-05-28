using QuizApplicationLibrary;
using QuizApplicationLibrary.BLL;
using QuizApplicationLibrary.POCO;
using Simple.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathPracticeApplication
{
    public partial class QuantTestCollectionForm : Form
    {
        private QuantTestBLL _quantDatabase = null;

        public QuantTestCollectionForm()
        {
            InitializeComponent();

            _quantDatabase = new QuantTestBLL();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            QuantTestEntityForm f = new QuantTestEntityForm(FormViewMode.Add, null);
            f.ItemStateChangeEvent += f_ItemStateChangeEvent;
            f.ShowDialog();
        }

        #region editButton_Click()
        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    QuantTest item = dataGridView1.SelectedRows[0].Tag as QuantTest;

                    if (item != null)
                    {
                        QuantTestEntityForm f = new QuantTestEntityForm(FormViewMode.Edit, item);
                        f.ItemStateChangeEvent += f_ItemStateChangeEvent;
                        f.ShowDialog();
                    }
                }
            }
        } 
        #endregion

        void f_ItemStateChangeEvent()
        {
            LoadToDataGridView();
        }

        #region LoadToDataGridView()
        private void LoadToDataGridView()
        {
            dataGridView1.Rows.Clear();

            IList<QuantTest> list = _quantDatabase.Get();

            if (list != null)
            {
                if (list.Count > 0)
                {
                    int i = 0;
                    foreach (QuantTest item in list)
                    {
                        dataGridView1.Rows.Add(item.ID, item.CreatedBy, item.CreateDate, item.TotalNumberOfQuestions);
                        dataGridView1.Rows[i].Tag = item;
                        i++;
                    }
                }
            }
        } 
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton_Click(sender, e);
        }
    }
}
