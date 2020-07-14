namespace courseProjQ22
{
    partial class TriviaWindow
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.ans3 = new System.Windows.Forms.Button();
            this.ans1 = new System.Windows.Forms.Button();
            this.ans2 = new System.Windows.Forms.Button();
            this.ans4 = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(48, 735);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(897, 125);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Back to menu";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LightCoral;
            this.startBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startBtn.Location = new System.Drawing.Point(1024, 735);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(396, 125);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // ans3
            // 
            this.ans3.BackColor = System.Drawing.Color.Blue;
            this.ans3.Font = new System.Drawing.Font("SF Pro Display", 20F, System.Drawing.FontStyle.Bold);
            this.ans3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ans3.Location = new System.Drawing.Point(48, 535);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(674, 158);
            this.ans3.TabIndex = 10;
            this.ans3.UseVisualStyleBackColor = false;
            this.ans3.Click += new System.EventHandler(this.ans3_Click);
            // 
            // ans1
            // 
            this.ans1.BackColor = System.Drawing.Color.Red;
            this.ans1.Font = new System.Drawing.Font("SF Pro Display", 20F, System.Drawing.FontStyle.Bold);
            this.ans1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ans1.Location = new System.Drawing.Point(48, 350);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(674, 158);
            this.ans1.TabIndex = 11;
            this.ans1.UseVisualStyleBackColor = false;
            this.ans1.Click += new System.EventHandler(this.ans1_Click);
            // 
            // ans2
            // 
            this.ans2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ans2.Font = new System.Drawing.Font("SF Pro Display", 20F, System.Drawing.FontStyle.Bold);
            this.ans2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ans2.Location = new System.Drawing.Point(746, 350);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(674, 158);
            this.ans2.TabIndex = 13;
            this.ans2.UseVisualStyleBackColor = false;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // ans4
            // 
            this.ans4.BackColor = System.Drawing.Color.Yellow;
            this.ans4.Font = new System.Drawing.Font("SF Pro Display", 20F, System.Drawing.FontStyle.Bold);
            this.ans4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ans4.Location = new System.Drawing.Point(746, 535);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(674, 158);
            this.ans4.TabIndex = 12;
            this.ans4.UseVisualStyleBackColor = false;
            this.ans4.Click += new System.EventHandler(this.ans4_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionTextBox.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(48, 41);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(1372, 277);
            this.QuestionTextBox.TabIndex = 14;
            this.QuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TriviaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 893);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "TriviaWindow";
            this.Text = "TriviaWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button ans3;
        private System.Windows.Forms.Button ans1;
        private System.Windows.Forms.Button ans2;
        private System.Windows.Forms.Button ans4;
        private System.Windows.Forms.TextBox QuestionTextBox;
    }
}