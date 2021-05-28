namespace QuizApplication
{
    partial class LearnUnlearnForm
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
            this.playTextGlassButton = new EnhancedGlassButton.GlassButton();
            this.glassButton1 = new EnhancedGlassButton.GlassButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playTextGlassButton
            // 
            this.playTextGlassButton.BackColor = System.Drawing.Color.Navy;
            this.playTextGlassButton.GlowColor = System.Drawing.Color.Red;
            this.playTextGlassButton.Location = new System.Drawing.Point(155, 118);
            this.playTextGlassButton.Name = "playTextGlassButton";
            this.playTextGlassButton.OuterBorderColor = System.Drawing.Color.Transparent;
            this.playTextGlassButton.Size = new System.Drawing.Size(100, 37);
            this.playTextGlassButton.TabIndex = 36;
            this.playTextGlassButton.Text = "Learnt";
            this.playTextGlassButton.Click += new System.EventHandler(this.playTextGlassButton_Click);
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.Navy;
            this.glassButton1.GlowColor = System.Drawing.Color.Red;
            this.glassButton1.Location = new System.Drawing.Point(270, 118);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glassButton1.Size = new System.Drawing.Size(100, 37);
            this.glassButton1.TabIndex = 37;
            this.glassButton1.Text = "not Learnt";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 100);
            this.textBox1.TabIndex = 38;
            // 
            // LearnUnlearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 170);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.playTextGlassButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LearnUnlearnForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnUnlearnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EnhancedGlassButton.GlassButton playTextGlassButton;
        private EnhancedGlassButton.GlassButton glassButton1;
        private System.Windows.Forms.TextBox textBox1;

    }
}