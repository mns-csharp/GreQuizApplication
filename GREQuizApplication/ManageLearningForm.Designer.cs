namespace QuizApplication
{
    partial class ManageLearningForm
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
            this.yetToLearnListBox = new System.Windows.Forms.ListBox();
            this.alreadyLearntListBox = new System.Windows.Forms.ListBox();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnUnlearn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yetToLearnListBox
            // 
            this.yetToLearnListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yetToLearnListBox.FormattingEnabled = true;
            this.yetToLearnListBox.ItemHeight = 16;
            this.yetToLearnListBox.Location = new System.Drawing.Point(13, 28);
            this.yetToLearnListBox.Name = "yetToLearnListBox";
            this.yetToLearnListBox.Size = new System.Drawing.Size(312, 420);
            this.yetToLearnListBox.TabIndex = 0;
            // 
            // alreadyLearntListBox
            // 
            this.alreadyLearntListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyLearntListBox.FormattingEnabled = true;
            this.alreadyLearntListBox.ItemHeight = 16;
            this.alreadyLearntListBox.Location = new System.Drawing.Point(431, 28);
            this.alreadyLearntListBox.Name = "alreadyLearntListBox";
            this.alreadyLearntListBox.Size = new System.Drawing.Size(312, 420);
            this.alreadyLearntListBox.TabIndex = 1;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(340, 184);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(75, 23);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = ">>";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnUnlearn
            // 
            this.btnUnlearn.Location = new System.Drawing.Point(340, 223);
            this.btnUnlearn.Name = "btnUnlearn";
            this.btnUnlearn.Size = new System.Drawing.Size(75, 23);
            this.btnUnlearn.TabIndex = 3;
            this.btnUnlearn.Text = "<<";
            this.btnUnlearn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Learning Candidate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Learnt :";
            // 
            // ManageLearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnlearn);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.alreadyLearntListBox);
            this.Controls.Add(this.yetToLearnListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLearningForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArrangeWordsForLearningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox yetToLearnListBox;
        private System.Windows.Forms.ListBox alreadyLearntListBox;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnUnlearn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}