using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class CongratulationsForm : Form
    {
        public CongratulationsForm(string word)
        {
            InitializeComponent();

            label1.Text = word.ToLower();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
