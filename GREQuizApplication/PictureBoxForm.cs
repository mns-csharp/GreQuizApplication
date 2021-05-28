using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class PictureBoxForm : Form
    {
        public PictureBoxForm(Image image)
        {
            InitializeComponent();

            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
