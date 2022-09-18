namespace Regex_Tasks
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
            this.MatchBTN = new System.Windows.Forms.Button();
            this.TestTXT = new System.Windows.Forms.TextBox();
            this.PatternTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MatchBTN
            // 
            this.MatchBTN.Location = new System.Drawing.Point(495, 251);
            this.MatchBTN.Name = "MatchBTN";
            this.MatchBTN.Size = new System.Drawing.Size(181, 66);
            this.MatchBTN.TabIndex = 0;
            this.MatchBTN.Text = "Match Text";
            this.MatchBTN.UseVisualStyleBackColor = true;
            this.MatchBTN.Click += new System.EventHandler(this.MatchBTN_Click);
            // 
            // TestTXT
            // 
            this.TestTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestTXT.Location = new System.Drawing.Point(274, 105);
            this.TestTXT.Multiline = true;
            this.TestTXT.Name = "TestTXT";
            this.TestTXT.Size = new System.Drawing.Size(402, 30);
            this.TestTXT.TabIndex = 1;
            // 
            // PatternTXT
            // 
            this.PatternTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatternTXT.Location = new System.Drawing.Point(274, 170);
            this.PatternTXT.Multiline = true;
            this.PatternTXT.Name = "PatternTXT";
            this.PatternTXT.Size = new System.Drawing.Size(402, 30);
            this.PatternTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SAMPLE TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "PATTERN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatternTXT);
            this.Controls.Add(this.TestTXT);
            this.Controls.Add(this.MatchBTN);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MatchBTN;
        private System.Windows.Forms.TextBox TestTXT;
        private System.Windows.Forms.TextBox PatternTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

