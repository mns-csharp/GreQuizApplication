namespace MathPracticeApplication
{
    partial class QuantTestEntityForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.creationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalNumberOfQuestionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.totalNumberOfQuestionsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(145, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create date:";
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.Location = new System.Drawing.Point(145, 75);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.Size = new System.Drawing.Size(200, 20);
            this.createdByTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Created by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total # of questions:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // creationDateDateTimePicker
            // 
            this.creationDateDateTimePicker.Location = new System.Drawing.Point(145, 49);
            this.creationDateDateTimePicker.Name = "creationDateDateTimePicker";
            this.creationDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.creationDateDateTimePicker.TabIndex = 9;
            // 
            // totalNumberOfQuestionsNumericUpDown
            // 
            this.totalNumberOfQuestionsNumericUpDown.Location = new System.Drawing.Point(146, 102);
            this.totalNumberOfQuestionsNumericUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.totalNumberOfQuestionsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalNumberOfQuestionsNumericUpDown.Name = "totalNumberOfQuestionsNumericUpDown";
            this.totalNumberOfQuestionsNumericUpDown.Size = new System.Drawing.Size(199, 20);
            this.totalNumberOfQuestionsNumericUpDown.TabIndex = 10;
            this.totalNumberOfQuestionsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalNumberOfQuestionsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuantTestEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 273);
            this.Controls.Add(this.totalNumberOfQuestionsNumericUpDown);
            this.Controls.Add(this.creationDateDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "QuantTestEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTestEntityForm";
            ((System.ComponentModel.ISupportInitialize)(this.totalNumberOfQuestionsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker creationDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown totalNumberOfQuestionsNumericUpDown;
    }
}