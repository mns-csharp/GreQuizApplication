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
    public partial class QuantitativeProblemCollectionForm : Form
    {
        private QuantitativeProblemBLL _quantDatabase = null;

        public QuantitativeProblemCollectionForm()
        {
            InitializeComponent();

            _quantDatabase = new QuantitativeProblemBLL();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadToDataGridView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            QuantitativeProblemEntityForm f = new QuantitativeProblemEntityForm(null, FormViewMode.Add);
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
                    QuantitativeProblem item = dataGridView1.SelectedRows[0].Tag as QuantitativeProblem;

                    if (item != null)
                    {
                        QuantitativeProblemEntityForm f = new QuantitativeProblemEntityForm(item, FormViewMode.Edit);
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

            IList<QuantitativeProblem> list = _quantDatabase.Get();

            if (list != null)
            {
                if (list.Count > 0)
                {
                    int i = 0;
                    foreach (QuantitativeProblem item in list)
                    {
                        dataGridView1.Rows.Add(item.ProblemText, ConvertImage.ToImage(item.ProblemPhoto));
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
