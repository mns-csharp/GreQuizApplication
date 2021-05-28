namespace QuizApplication
{
    partial class WordEntityForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.exampleTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.hintTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meaningTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etymologyTestBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.synonymsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectPhotoButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.correctnessTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastEnteredWordLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.learntCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.closeButton.Location = new System.Drawing.Point(178, 479);
            this.closeButton.Margin = new System.Windows.Forms.Padding(1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(85, 24);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Example :";
            // 
            // exampleTextBox
            // 
            this.exampleTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleTextBox.Location = new System.Drawing.Point(674, 136);
            this.exampleTextBox.Multiline = true;
            this.exampleTextBox.Name = "exampleTextBox";
            this.exampleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exampleTextBox.Size = new System.Drawing.Size(503, 205);
            this.exampleTextBox.TabIndex = 12;
            this.exampleTextBox.Text = "●";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveButton.Location = new System.Drawing.Point(76, 479);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 24);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.photoPictureBox.Location = new System.Drawing.Point(674, 346);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(179, 129);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 10;
            this.photoPictureBox.TabStop = false;
            // 
            // hintTextBox
            // 
            this.hintTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintTextBox.Location = new System.Drawing.Point(76, 74);
            this.hintTextBox.Multiline = true;
            this.hintTextBox.Name = "hintTextBox";
            this.hintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hintTextBox.Size = new System.Drawing.Size(503, 57);
            this.hintTextBox.TabIndex = 5;
            this.hintTextBox.Text = "●";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hint :";
            // 
            // meaningTextBox
            // 
            this.meaningTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.meaningTextBox.Location = new System.Drawing.Point(269, 38);
            this.meaningTextBox.Name = "meaningTextBox";
            this.meaningTextBox.Size = new System.Drawing.Size(310, 31);
            this.meaningTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(76, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 31);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word :";
            // 
            // etymologyTestBox
            // 
            this.etymologyTestBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etymologyTestBox.Location = new System.Drawing.Point(76, 137);
            this.etymologyTestBox.Multiline = true;
            this.etymologyTestBox.Name = "etymologyTestBox";
            this.etymologyTestBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.etymologyTestBox.Size = new System.Drawing.Size(503, 341);
            this.etymologyTestBox.TabIndex = 18;
            this.etymologyTestBox.Text = "●";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Etymology :";
            // 
            // synonymsTextBox
            // 
            this.synonymsTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synonymsTextBox.Location = new System.Drawing.Point(674, 38);
            this.synonymsTextBox.Multiline = true;
            this.synonymsTextBox.Name = "synonymsTextBox";
            this.synonymsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.synonymsTextBox.Size = new System.Drawing.Size(503, 93);
            this.synonymsTextBox.TabIndex = 16;
            this.synonymsTextBox.Text = "●";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Synonyms :";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearButton.Location = new System.Drawing.Point(494, 479);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 24);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // selectPhotoButton
            // 
            this.selectPhotoButton.Location = new System.Drawing.Point(857, 346);
            this.selectPhotoButton.Margin = new System.Windows.Forms.Padding(1);
            this.selectPhotoButton.Name = "selectPhotoButton";
            this.selectPhotoButton.Size = new System.Drawing.Size(85, 24);
            this.selectPhotoButton.TabIndex = 20;
            this.selectPhotoButton.Text = "Select Photo";
            this.selectPhotoButton.UseVisualStyleBackColor = true;
            this.selectPhotoButton.Click += new System.EventHandler(this.btnSelectPhoto_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Photo :";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(76, 7);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(187, 21);
            this.groupComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Group :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Correctness :";
            // 
            // correctnessTextBox
            // 
            this.correctnessTextBox.Enabled = false;
            this.correctnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctnessTextBox.Location = new System.Drawing.Point(358, 2);
            this.correctnessTextBox.Name = "correctnessTextBox";
            this.correctnessTextBox.ReadOnly = true;
            this.correctnessTextBox.Size = new System.Drawing.Size(38, 31);
            this.correctnessTextBox.TabIndex = 25;
            this.correctnessTextBox.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lastEnteredWordLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Last word : ";
            // 
            // lastEnteredWordLabel
            // 
            this.lastEnteredWordLabel.Name = "lastEnteredWordLabel";
            this.lastEnteredWordLabel.Size = new System.Drawing.Size(109, 17);
            this.lastEnteredWordLabel.Text = "toolStripStatusLabel2";
            // 
            // learntCheckBox
            // 
            this.learntCheckBox.AutoSize = true;
            this.learntCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learntCheckBox.Location = new System.Drawing.Point(405, 10);
            this.learntCheckBox.Name = "learntCheckBox";
            this.learntCheckBox.Size = new System.Drawing.Size(62, 17);
            this.learntCheckBox.TabIndex = 29;
            this.learntCheckBox.Text = "Learnt";
            this.learntCheckBox.UseVisualStyleBackColor = true;
            this.learntCheckBox.CheckedChanged += new System.EventHandler(this.learntCheckBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(674, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 35);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "●";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(1187, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.learntCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.correctnessTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectPhotoButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.etymologyTestBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.synonymsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exampleTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.hintTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meaningTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndividualForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntityForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox meaningTextBox;
        private System.Windows.Forms.TextBox hintTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox exampleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox etymologyTestBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox synonymsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button selectPhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correctnessTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lastEnteredWordLabel;
        private System.Windows.Forms.CheckBox learntCheckBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}