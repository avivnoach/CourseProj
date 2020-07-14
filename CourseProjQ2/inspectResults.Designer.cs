namespace courseProjQ22
{
    partial class inspectResults
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.questionTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correctAnswerTextBox = new System.Windows.Forms.TextBox();
            this.backToMenuBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nextBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextBtn.Location = new System.Drawing.Point(974, 752);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(446, 129);
            this.nextBtn.TabIndex = 9;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.previousBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.previousBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousBtn.Location = new System.Drawing.Point(449, 752);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(446, 129);
            this.previousBtn.TabIndex = 10;
            this.previousBtn.Text = "previous";
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionTextBox.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(45, 95);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(1372, 209);
            this.QuestionTextBox.TabIndex = 15;
            this.QuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // questionTitle
            // 
            this.questionTitle.AutoSize = true;
            this.questionTitle.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitle.Location = new System.Drawing.Point(43, 20);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(356, 62);
            this.questionTitle.TabIndex = 16;
            this.questionTitle.Text = "The Question:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 62);
            this.label1.TabIndex = 17;
            this.label1.Text = "The correct answer:";
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.correctAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correctAnswerTextBox.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerTextBox.Location = new System.Drawing.Point(45, 378);
            this.correctAnswerTextBox.Multiline = true;
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.ReadOnly = true;
            this.correctAnswerTextBox.Size = new System.Drawing.Size(1373, 209);
            this.correctAnswerTextBox.TabIndex = 18;
            this.correctAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backToMenuBtn
            // 
            this.backToMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backToMenuBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.backToMenuBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backToMenuBtn.Location = new System.Drawing.Point(12, 756);
            this.backToMenuBtn.Name = "backToMenuBtn";
            this.backToMenuBtn.Size = new System.Drawing.Size(330, 125);
            this.backToMenuBtn.TabIndex = 19;
            this.backToMenuBtn.Text = "Menu";
            this.backToMenuBtn.UseVisualStyleBackColor = false;
            this.backToMenuBtn.Click += new System.EventHandler(this.backToMenuBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 62);
            this.label2.TabIndex = 20;
            this.label2.Text = "Did you got it right?";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(529, 606);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 62);
            this.answerLabel.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 62);
            this.label3.TabIndex = 22;
            this.label3.Text = "Time to answer:";
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Font = new System.Drawing.Font("SF Pro Display", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millisecondsLabel.Location = new System.Drawing.Point(448, 668);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(0, 62);
            this.millisecondsLabel.TabIndex = 23;
            // 
            // inspectResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 893);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backToMenuBtn);
            this.Controls.Add(this.correctAnswerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionTitle);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Name = "inspectResults";
            this.Text = "inspectResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correctAnswerTextBox;
        private System.Windows.Forms.Button backToMenuBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label millisecondsLabel;
    }
}