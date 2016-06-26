namespace ProjectMillenia_WFA
{
    partial class MainPage
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
            this.StartMetBtn = new System.Windows.Forms.Button();
            this.labelBPM = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.selectorBPM = new System.Windows.Forms.NumericUpDown();
            this.selectorScale = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectorBPM)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMetBtn
            // 
            this.StartMetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.StartMetBtn.Location = new System.Drawing.Point(87, 184);
            this.StartMetBtn.Name = "StartMetBtn";
            this.StartMetBtn.Size = new System.Drawing.Size(289, 189);
            this.StartMetBtn.TabIndex = 0;
            this.StartMetBtn.Text = "Start";
            this.StartMetBtn.UseVisualStyleBackColor = true;
            this.StartMetBtn.Click += new System.EventHandler(this.StartMetBtnOnClick);
            // 
            // labelBPM
            // 
            this.labelBPM.AutoSize = true;
            this.labelBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBPM.Location = new System.Drawing.Point(27, 23);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(51, 20);
            this.labelBPM.TabIndex = 1;
            this.labelBPM.Text = "BPM:";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelScale.Location = new System.Drawing.Point(27, 56);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(56, 20);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Scale:";
            // 
            // selectorBPM
            // 
            this.selectorBPM.Location = new System.Drawing.Point(119, 21);
            this.selectorBPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.selectorBPM.Name = "selectorBPM";
            this.selectorBPM.Size = new System.Drawing.Size(133, 22);
            this.selectorBPM.TabIndex = 3;
            // 
            // selectorScale
            // 
            this.selectorScale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectorScale.FormattingEnabled = true;
            this.selectorScale.Items.AddRange(new object[] {
            "0.25"});
            this.selectorScale.Location = new System.Drawing.Point(119, 56);
            this.selectorScale.Name = "selectorScale";
            this.selectorScale.Size = new System.Drawing.Size(133, 24);
            this.selectorScale.TabIndex = 4;
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(452, 385);
            this.Controls.Add(this.selectorScale);
            this.Controls.Add(this.selectorBPM);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.labelBPM);
            this.Controls.Add(this.StartMetBtn);
            this.Name = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.selectorBPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartMetBtn;
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown selectorBPM;
        private System.Windows.Forms.ComboBox selectorScale;
    }
}