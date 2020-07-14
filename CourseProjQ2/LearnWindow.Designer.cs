namespace courseProjQ22
{
    partial class LearnWindow
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
            this.factNumText = new System.Windows.Forms.Label();
            this.FactTextBox = new System.Windows.Forms.TextBox();
            this.topicText = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.LightCoral;
            this.nextBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextBtn.Location = new System.Drawing.Point(929, 720);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(396, 125);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // factNumText
            // 
            this.factNumText.AutoSize = true;
            this.factNumText.Font = new System.Drawing.Font("SF Pro Rounded", 30F, System.Drawing.FontStyle.Bold);
            this.factNumText.Location = new System.Drawing.Point(77, 45);
            this.factNumText.Name = "factNumText";
            this.factNumText.Size = new System.Drawing.Size(394, 72);
            this.factNumText.TabIndex = 4;
            this.factNumText.Text = "Fact Number ";
            // 
            // FactTextBox
            // 
            this.FactTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FactTextBox.Font = new System.Drawing.Font("SF Pro Rounded", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactTextBox.Location = new System.Drawing.Point(89, 330);
            this.FactTextBox.Multiline = true;
            this.FactTextBox.Name = "FactTextBox";
            this.FactTextBox.ReadOnly = true;
            this.FactTextBox.Size = new System.Drawing.Size(1236, 286);
            this.FactTextBox.TabIndex = 5;
            this.FactTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topicText
            // 
            this.topicText.AutoSize = true;
            this.topicText.Font = new System.Drawing.Font("SF Pro Rounded", 30F, System.Drawing.FontStyle.Bold);
            this.topicText.Location = new System.Drawing.Point(77, 140);
            this.topicText.Name = "topicText";
            this.topicText.Size = new System.Drawing.Size(205, 72);
            this.topicText.TabIndex = 6;
            this.topicText.Text = "Topic: ";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(89, 720);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(703, 125);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Back to menu";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LearnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 893);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.topicText);
            this.Controls.Add(this.FactTextBox);
            this.Controls.Add(this.factNumText);
            this.Controls.Add(this.nextBtn);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "LearnWindow";
            this.Text = "LearnWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label factNumText;
        private System.Windows.Forms.TextBox FactTextBox;
        private System.Windows.Forms.Label topicText;
        private System.Windows.Forms.Button exitBtn;
    }
}