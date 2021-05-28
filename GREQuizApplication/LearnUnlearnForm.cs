using QuizApplicationLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class LearnUnlearnForm : Form
    {
        public LearntTypeEnum ConvertType { get; private set; }

        public LearnUnlearnForm(string list)
        {
            InitializeComponent();

            textBox1.Text = list;

            ConvertType = LearntTypeEnum.All;
        }

        private void playTextGlassButton_Click(object sender, EventArgs e)
        {
            ConvertType = LearntTypeEnum.Learnt;

            this.Close();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            ConvertType = LearntTypeEnum.NotLearnt;

            this.Close();
        }
    }
}
