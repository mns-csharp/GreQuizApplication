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
    public partial class QuantTestEntityForm : BaseForm
    {
        private QuantTestBLL _quantTestBll = null;
        private FormViewMode _formViewMode = FormViewMode.Nothing;
        private QuantTest _quantTest = null;

        public QuantTestEntityForm(FormViewMode formViewMode, QuantTest quantTest)
        {
            InitializeComponent();

            _quantTestBll = new QuantTestBLL();
            this._formViewMode = formViewMode;
            this._quantTest = quantTest;

            if (formViewMode == FormViewMode.Edit)
            {
                MapObjectToControls();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                QuantTest item = null;

                if (_formViewMode == FormViewMode.Add)
                {
                    item = new QuantTest();
                }
                else if (_formViewMode == FormViewMode.Edit)
                {
                    item = _quantTest;
                }

                //item.ID = idTextBox.Text;
                item.CreateDate = creationDateDateTimePicker.Value;
                item.CreatedBy = createdByTextBox.Text;
                item.TotalNumberOfQuestions = (int)totalNumberOfQuestionsNumericUpDown.Value;
                                
                if (item.ID == null)
                {
                    _quantTestBll.Save(item);
                }
                else
                {
                    _quantTestBll.Update(item);
                }

                OnItemStateChanged();

                if (_formViewMode == FormViewMode.Add)
                {
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MapObjectToControls()
        {
            if (_quantTest != null)
            {
                idTextBox.Text = _quantTest.ID.ToString();
                creationDateDateTimePicker.Value = _quantTest.CreateDate;
                createdByTextBox.Text = _quantTest.CreatedBy;
                totalNumberOfQuestionsNumericUpDown.Value = _quantTest.TotalNumberOfQuestions;
            }
        }

        private void ClearControls()
        {
            idTextBox.Text = string.Empty;
            creationDateDateTimePicker.Value = DateTime.Now;
            createdByTextBox.Text = string.Empty;
            totalNumberOfQuestionsNumericUpDown.Value = totalNumberOfQuestionsNumericUpDown.Minimum;
        }
    }
}
