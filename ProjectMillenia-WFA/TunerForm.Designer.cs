namespace ProjectMillenia_WFA
{
    partial class TunerForm
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
            this.listenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listenBtn
            // 
            this.listenBtn.Location = new System.Drawing.Point(548, 13);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(205, 66);
            this.listenBtn.TabIndex = 0;
            this.listenBtn.Text = "Start";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // TunerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 482);
            this.Controls.Add(this.listenBtn);
            this.Name = "TunerForm";
            this.Text = "TunerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listenBtn;
    }
}