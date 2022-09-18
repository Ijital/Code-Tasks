namespace My_Regrexs
{
    partial class Form1
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
            this.TestText = new System.Windows.Forms.TextBox();
            this.PatternTxt = new System.Windows.Forms.TextBox();
            this.MatchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestText
            // 
            this.TestText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestText.Location = new System.Drawing.Point(187, 103);
            this.TestText.Name = "TestText";
            this.TestText.Size = new System.Drawing.Size(316, 22);
            this.TestText.TabIndex = 0;
            // 
            // PatternTxt
            // 
            this.PatternTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatternTxt.Location = new System.Drawing.Point(187, 170);
            this.PatternTxt.Name = "PatternTxt";
            this.PatternTxt.Size = new System.Drawing.Size(316, 22);
            this.PatternTxt.TabIndex = 1;
            // 
            // MatchBtn
            // 
            this.MatchBtn.Location = new System.Drawing.Point(187, 229);
            this.MatchBtn.Name = "MatchBtn";
            this.MatchBtn.Size = new System.Drawing.Size(316, 23);
            this.MatchBtn.TabIndex = 2;
            this.MatchBtn.Text = "Check If Test Text Matches Pattern";
            this.MatchBtn.UseVisualStyleBackColor = true;
            this.MatchBtn.Click += new System.EventHandler(this.MatchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pattern";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatchBtn);
            this.Controls.Add(this.PatternTxt);
            this.Controls.Add(this.TestText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TestText;
        private System.Windows.Forms.TextBox PatternTxt;
        private System.Windows.Forms.Button MatchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

