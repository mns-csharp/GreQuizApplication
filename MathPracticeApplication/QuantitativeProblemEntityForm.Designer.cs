namespace MathPracticeApplication
{
    partial class QuantitativeProblemEntityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.problemTextTextBox = new System.Windows.Forms.TextBox();
            this.solutionTextTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.problemPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.solutionPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.browseForProblemPhotoButton = new System.Windows.Forms.Button();
            this.browseForSolutionPhotoButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.answerTextTextBox = new System.Windows.Forms.TextBox();
            this.answerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantitativeProblemTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.problemPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem Test:";
            // 
            // problemTextTextBox
            // 
            this.problemTextTextBox.Location = new System.Drawing.Point(91, 14);
            this.problemTextTextBox.Multiline = true;
            this.problemTextTextBox.Name = "problemTextTextBox";
            this.problemTextTextBox.Size = new System.Drawing.Size(313, 92);
            this.problemTextTextBox.TabIndex = 1;
            // 
            // SolutionTextTextBox
            // 
            this.solutionTextTextBox.Location = new System.Drawing.Point(488, 10);
            this.solutionTextTextBox.Multiline = true;
            this.solutionTextTextBox.Name = "SolutionTextTextBox";
            this.solutionTextTextBox.Size = new System.Drawing.Size(313, 96);
            this.solutionTextTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solution Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Problem Photo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Solution Photo:";
            // 
            // problemPhotoPictureBox
            // 
            this.problemPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.problemPhotoPictureBox.Location = new System.Drawing.Point(102, 128);
            this.problemPhotoPictureBox.Name = "problemPhotoPictureBox";
            this.problemPhotoPictureBox.Size = new System.Drawing.Size(295, 120);
            this.problemPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.problemPhotoPictureBox.TabIndex = 6;
            this.problemPhotoPictureBox.TabStop = false;
            // 
            // solutionPhotoPictureBox
            // 
            this.solutionPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.solutionPhotoPictureBox.Location = new System.Drawing.Point(488, 128);
            this.solutionPhotoPictureBox.Name = "solutionPhotoPictureBox";
            this.solutionPhotoPictureBox.Size = new System.Drawing.Size(295, 120);
            this.solutionPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solutionPhotoPictureBox.TabIndex = 7;
            this.solutionPhotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.browseForProblemPhotoButton.Location = new System.Drawing.Point(322, 255);
            this.browseForProblemPhotoButton.Name = "button1";
            this.browseForProblemPhotoButton.Size = new System.Drawing.Size(75, 23);
            this.browseForProblemPhotoButton.TabIndex = 8;
            this.browseForProblemPhotoButton.Text = "Browse";
            this.browseForProblemPhotoButton.UseVisualStyleBackColor = true;
            this.browseForProblemPhotoButton.Click += new System.EventHandler(this.browseForProblemPhotoButtom_Click);
            // 
            // button2
            // 
            this.browseForSolutionPhotoButton.Location = new System.Drawing.Point(708, 255);
            this.browseForSolutionPhotoButton.Name = "button2";
            this.browseForSolutionPhotoButton.Size = new System.Drawing.Size(75, 23);
            this.browseForSolutionPhotoButton.TabIndex = 9;
            this.browseForSolutionPhotoButton.Text = "Browse";
            this.browseForSolutionPhotoButton.UseVisualStyleBackColor = true;
            this.browseForSolutionPhotoButton.Click += new System.EventHandler(this.browseForSolutionPhotoButtom_Click);
            // 
            // button3
            // 
            this.saveButton.Location = new System.Drawing.Point(708, 317);
            this.saveButton.Name = "button3";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ANswerText:";
            // 
            // answerTextTextBox
            // 
            this.answerTextTextBox.Location = new System.Drawing.Point(102, 325);
            this.answerTextTextBox.Name = "answerTextTextBox";
            this.answerTextTextBox.Size = new System.Drawing.Size(295, 20);
            this.answerTextTextBox.TabIndex = 12;
            // 
            // answerTypeComboBox
            // 
            this.answerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answerTypeComboBox.FormattingEnabled = true;
            this.answerTypeComboBox.Location = new System.Drawing.Point(102, 290);
            this.answerTypeComboBox.Name = "answerTypeComboBox";
            this.answerTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.answerTypeComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "answer type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ProblemType";
            // 
            // quantitativeProblemTypeComboBox
            // 
            this.quantitativeProblemTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitativeProblemTypeComboBox.FormattingEnabled = true;
            this.quantitativeProblemTypeComboBox.Location = new System.Drawing.Point(488, 290);
            this.quantitativeProblemTypeComboBox.Name = "quantitativeProblemTypeComboBox";
            this.quantitativeProblemTypeComboBox.Size = new System.Drawing.Size(295, 21);
            this.quantitativeProblemTypeComboBox.TabIndex = 15;
            // 
            // QuantitativeProblemEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantitativeProblemTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerTypeComboBox);
            this.Controls.Add(this.answerTextTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseForSolutionPhotoButton);
            this.Controls.Add(this.browseForProblemPhotoButton);
            this.Controls.Add(this.solutionPhotoPictureBox);
            this.Controls.Add(this.problemPhotoPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solutionTextTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.problemTextTextBox);
            this.Controls.Add(this.label1);
            this.Name = "QuantitativeProblemEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuantProblemInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.problemPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemTextTextBox;
        private System.Windows.Forms.TextBox solutionTextTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox problemPhotoPictureBox;
        private System.Windows.Forms.PictureBox solutionPhotoPictureBox;
        private System.Windows.Forms.Button browseForProblemPhotoButton;
        private System.Windows.Forms.Button browseForSolutionPhotoButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox answerTextTextBox;
        private System.Windows.Forms.ComboBox answerTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox quantitativeProblemTypeComboBox;
    }
}