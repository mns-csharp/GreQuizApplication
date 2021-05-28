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
    public partial class QuantitativeProblemEntityForm : BaseForm
    {
        private QuantitativeProblemBLL _wordDatabase = null;
        private AnswerTypeBLL _answerTypeDatabase = null;
        private QuantitativeProblemTypeBLL _quantitativeProblemTypeDatabase = null;
        private OpenFileDialog ofd = new OpenFileDialog();
        private QuantitativeProblem _item = null;
        private FormViewMode _formViewMode;

        public QuantitativeProblemEntityForm(QuantitativeProblem item, FormViewMode formViewMode)
        {
            InitializeComponent();

            _wordDatabase = new QuantitativeProblemBLL();
            _answerTypeDatabase = new AnswerTypeBLL();
            _quantitativeProblemTypeDatabase = new QuantitativeProblemTypeBLL();

            _item = item;
            _formViewMode = formViewMode;

            LoadAnswerType();
            LoadQuantitativeProblemType();

            if (_formViewMode == FormViewMode.Edit)
            {
                MapObjectToControl(_item);
            }
        }

        #region LoadQuantitativeProblemType()
        private void LoadQuantitativeProblemType()
        {
            quantitativeProblemTypeComboBox.Items.Clear();
            IList<QuantitativeProblemType> list = _quantitativeProblemTypeDatabase.Get();

            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (QuantitativeProblemType item in list)
                    {
                        quantitativeProblemTypeComboBox.Items.Add(item);
                    }

                    quantitativeProblemTypeComboBox.ValueMember = "ID";
                    quantitativeProblemTypeComboBox.DisplayMember = "TypeName";
                    quantitativeProblemTypeComboBox.SelectedIndex = 0;
                }
            }
        } 
        #endregion

        #region LoadAnswerType()
        private void LoadAnswerType()
        {
            answerTypeComboBox.Items.Clear();
            IList<AnswerType> list = _answerTypeDatabase.Get();

            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (AnswerType item in list)
                    {
                        answerTypeComboBox.Items.Add(item);
                    }

                    answerTypeComboBox.ValueMember = "ID";
                    answerTypeComboBox.DisplayMember = "TypeName";
                    answerTypeComboBox.SelectedIndex = 0;
                }
            }
        } 
        #endregion

        private void browseForProblemPhotoButtom_Click(object sender, EventArgs e)
        {            
            ofd.ShowDialog();

            string filePath = ofd.FileName;

            if (FilePathVerifier.IsValidPath(filePath))
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(filePath);

                problemPhotoPictureBox.Image = img;
            }
        }

        private void browseForSolutionPhotoButtom_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            string filePath = ofd.FileName;
            if (FilePathVerifier.IsValidPath(filePath))
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(filePath);

                solutionPhotoPictureBox.Image = img;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            QuantitativeProblem item = null;

            if (_formViewMode == FormViewMode.Add)
            {
                item = new QuantitativeProblem();
            }
            else if(_formViewMode == FormViewMode.Edit)
            {
                item = _item;
            }

            item.ProblemText = problemTextTextBox.Text;
            item.SolutionText = solutionTextTextBox.Text;
            item.ProblemPhoto = problemPhotoPictureBox.Image!=null?ConvertImage.ToByteArray(problemPhotoPictureBox.Image):null;
            item.SolutionPhoto = solutionPhotoPictureBox.Image!=null?ConvertImage.ToByteArray(solutionPhotoPictureBox.Image):null;
            item.AnswerText = answerTextTextBox.Text;

            AnswerType answerType = answerTypeComboBox.SelectedItem as AnswerType;
            QuantitativeProblemType quantitativeProblemType = quantitativeProblemTypeComboBox.SelectedItem as QuantitativeProblemType;

            item.AnswerType = EnumConverter<AnswerTypeEnum>.ToEnum(answerType.TypeName);
            item.QuantitativeProblemType = EnumConverter<QuantitativeProblemTypeEnum>.ToEnum(quantitativeProblemType.TypeName);

            if (string.IsNullOrEmpty(item.ProblemText))
            {
                if (item.ProblemPhoto != null)
                {
                    if (item.ProblemPhoto.Length > 0)
                    {
                        item.ContentType = ContentTypeEnum.Photo;
                    }
                    else
                    {
                        item.ContentType = ContentTypeEnum.Text;
                    }
                }
                else 
                {
                    item.ContentType = ContentTypeEnum.Text;
                }
            }
            else
            {
                item.ContentType = ContentTypeEnum.Photo;
            }

            if (item.ID == null)
            {
                 _wordDatabase.Save(item);
            }
            else
            {
                 _wordDatabase.Update(item);
            }

            OnItemStateChanged();
        }

        private void MapObjectToControl(QuantitativeProblem item)
        {
            if (item != null)
            {
                problemTextTextBox.Text = item.ProblemText;
                solutionTextTextBox.Text = item.SolutionText;
                problemPhotoPictureBox.Image = ConvertImage.ToImage(item.ProblemPhoto);
                solutionPhotoPictureBox.Image = ConvertImage.ToImage(item.SolutionPhoto);
                answerTypeComboBox.SelectedIndex = EnumConverter<AnswerTypeEnum>.ToInt32(item.AnswerType)-1;
                quantitativeProblemTypeComboBox.SelectedIndex = EnumConverter<QuantitativeProblemTypeEnum>.ToInt32(item.QuantitativeProblemType)-1;
                answerTextTextBox.Text = item.AnswerText;
            }
        }
    }
}
