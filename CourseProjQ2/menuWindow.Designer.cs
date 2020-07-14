namespace courseProjQ22
{
    partial class menuWindow
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
            this.learnBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.menuText = new System.Windows.Forms.Label();
            this.instructionsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // learnBtn
            // 
            this.learnBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.learnBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.learnBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.learnBtn.Location = new System.Drawing.Point(120, 595);
            this.learnBtn.Name = "learnBtn";
            this.learnBtn.Size = new System.Drawing.Size(530, 228);
            this.learnBtn.TabIndex = 0;
            this.learnBtn.Text = "Learn";
            this.learnBtn.UseVisualStyleBackColor = false;
            this.learnBtn.Click += new System.EventHandler(this.learnBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Crimson;
            this.playBtn.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold);
            this.playBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playBtn.Location = new System.Drawing.Point(764, 595);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(530, 228);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // menuText
            // 
            this.menuText.AutoSize = true;
            this.menuText.Font = new System.Drawing.Font("SF Pro Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuText.Location = new System.Drawing.Point(125, 56);
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(0, 86);
            this.menuText.TabIndex = 2;
            // 
            // instructionsText
            // 
            this.instructionsText.AutoSize = true;
            this.instructionsText.Font = new System.Drawing.Font("SF Pro Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsText.Location = new System.Drawing.Point(125, 170);
            this.instructionsText.Name = "instructionsText";
            this.instructionsText.Size = new System.Drawing.Size(0, 86);
            this.instructionsText.TabIndex = 3;
            // 
            // menuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 893);
            this.Controls.Add(this.instructionsText);
            this.Controls.Add(this.menuText);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.learnBtn);
            this.Name = "menuWindow";
            this.Text = "menuWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button learnBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label menuText;
        private System.Windows.Forms.Label instructionsText;
    }
}