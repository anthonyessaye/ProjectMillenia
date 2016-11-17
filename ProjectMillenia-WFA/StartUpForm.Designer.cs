namespace ProjectMillenia_WFA
{
    partial class StartUpForm
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
            this.LearnBtn = new System.Windows.Forms.Button();
            this.transcribeBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.subTitleLbl = new System.Windows.Forms.Label();
            this.LearnDescTxt = new System.Windows.Forms.Label();
            this.LearnTxtBox = new System.Windows.Forms.RichTextBox();
            this.TranscribeTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LearnBtn
            // 
            this.LearnBtn.Font = new System.Drawing.Font("CityBlueprint", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LearnBtn.Location = new System.Drawing.Point(306, 240);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(214, 201);
            this.LearnBtn.TabIndex = 0;
            this.LearnBtn.Text = "Learn";
            this.LearnBtn.UseVisualStyleBackColor = true;
            // 
            // transcribeBtn
            // 
            this.transcribeBtn.Font = new System.Drawing.Font("CityBlueprint", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.transcribeBtn.Location = new System.Drawing.Point(740, 240);
            this.transcribeBtn.Name = "transcribeBtn";
            this.transcribeBtn.Size = new System.Drawing.Size(214, 201);
            this.transcribeBtn.TabIndex = 1;
            this.transcribeBtn.Text = "Transcribe";
            this.transcribeBtn.UseVisualStyleBackColor = true;
            this.transcribeBtn.Click += new System.EventHandler(this.transcribeBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("CityBlueprint", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TitleLbl.Location = new System.Drawing.Point(425, 21);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(431, 154);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Millennia";
            // 
            // subTitleLbl
            // 
            this.subTitleLbl.AutoSize = true;
            this.subTitleLbl.Font = new System.Drawing.Font("CityBlueprint", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.subTitleLbl.Location = new System.Drawing.Point(497, 157);
            this.subTitleLbl.Name = "subTitleLbl";
            this.subTitleLbl.Size = new System.Drawing.Size(301, 36);
            this.subTitleLbl.TabIndex = 3;
            this.subTitleLbl.Text = "by musicians, for musicians";
            // 
            // LearnDescTxt
            // 
            this.LearnDescTxt.AutoSize = true;
            this.LearnDescTxt.Location = new System.Drawing.Point(245, 455);
            this.LearnDescTxt.Name = "LearnDescTxt";
            this.LearnDescTxt.Size = new System.Drawing.Size(0, 17);
            this.LearnDescTxt.TabIndex = 4;
            // 
            // LearnTxtBox
            // 
            this.LearnTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.LearnTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LearnTxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LearnTxtBox.Font = new System.Drawing.Font("CityBlueprint", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LearnTxtBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LearnTxtBox.Location = new System.Drawing.Point(231, 447);
            this.LearnTxtBox.Name = "LearnTxtBox";
            this.LearnTxtBox.ReadOnly = true;
            this.LearnTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LearnTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LearnTxtBox.Size = new System.Drawing.Size(363, 124);
            this.LearnTxtBox.TabIndex = 5;
            this.LearnTxtBox.Text = "Learn Section is dedicated to teaching music theory. With divided lessons and ass" +
    "isting tools that can help anyone start a journey into an artistic world with pe" +
    "ople who speak this language";
            // 
            // TranscribeTxtBox
            // 
            this.TranscribeTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.TranscribeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TranscribeTxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TranscribeTxtBox.Font = new System.Drawing.Font("CityBlueprint", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TranscribeTxtBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TranscribeTxtBox.Location = new System.Drawing.Point(673, 447);
            this.TranscribeTxtBox.Name = "TranscribeTxtBox";
            this.TranscribeTxtBox.ReadOnly = true;
            this.TranscribeTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TranscribeTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TranscribeTxtBox.Size = new System.Drawing.Size(363, 93);
            this.TranscribeTxtBox.TabIndex = 6;
            this.TranscribeTxtBox.Text = "Transcribe section is dedicated to musicians who want to improvise a melody witho" +
    "ut forgetting what they played. This section is dedicated to transcribe any reco" +
    "rding";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.TranscribeTxtBox);
            this.Controls.Add(this.LearnTxtBox);
            this.Controls.Add(this.LearnDescTxt);
            this.Controls.Add(this.subTitleLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.transcribeBtn);
            this.Controls.Add(this.LearnBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Millennia";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LearnBtn;
        private System.Windows.Forms.Button transcribeBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label subTitleLbl;
        private System.Windows.Forms.Label LearnDescTxt;
        private System.Windows.Forms.RichTextBox LearnTxtBox;
        private System.Windows.Forms.RichTextBox TranscribeTxtBox;
    }
}