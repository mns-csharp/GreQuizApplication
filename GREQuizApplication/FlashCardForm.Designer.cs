namespace QuizApplication
{
    partial class FlashCardForm
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
            this.revealButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // revealButton
            // 
            this.revealButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealButton.Location = new System.Drawing.Point(12, 90);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(396, 46);
            this.revealButton.TabIndex = 23;
            this.revealButton.Text = "Reveal";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.wordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.ForeColor = System.Drawing.Color.Blue;
            this.wordTextBox.Location = new System.Drawing.Point(12, 9);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(396, 74);
            this.wordTextBox.TabIndex = 22;
            this.wordTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.ForeColor = System.Drawing.Color.Blue;
            this.answerTextBox.Location = new System.Drawing.Point(12, 149);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(396, 74);
            this.answerTextBox.TabIndex = 24;
            this.answerTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.wordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FlashCardForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Label wordTextBox;
        private System.Windows.Forms.Label answerTextBox;
    }
}