namespace ProjectMillenia_WFA
{
    partial class TranscribePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranscribePage));
            this.labelBPM = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.selectorBPM = new System.Windows.Forms.NumericUpDown();
            this.ScaleNumeratorScroll = new System.Windows.Forms.NumericUpDown();
            this.ScaleDenominatorScroll = new System.Windows.Forms.NumericUpDown();
            this.DividentText = new System.Windows.Forms.Label();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.StartMetBtn = new System.Windows.Forms.Button();
            this.PlayWavBtn = new System.Windows.Forms.Button();
            this.StopWavBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMidiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tunerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordBtn = new System.Windows.Forms.Button();
            this.TheEverythingTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CanvasBox = new System.Windows.Forms.GroupBox();
            this.MusicSheetBox = new System.Windows.Forms.GroupBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.NextImageBtn = new System.Windows.Forms.Button();
            this.PrevImageBtn = new System.Windows.Forms.Button();
            this.WaveFormBox = new System.Windows.Forms.GroupBox();
            this.EndTime_Lbl = new System.Windows.Forms.Label();
            this.WaveForm = new ProjectMillenia_WFA.CustomWaveViewer();
            this.StartTime_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectorBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeratorScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleDenominatorScroll)).BeginInit();
            this.SettingsBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TheEverythingTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CanvasBox.SuspendLayout();
            this.MusicSheetBox.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.WaveFormBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBPM
            // 
            this.labelBPM.AutoSize = true;
            this.labelBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBPM.Location = new System.Drawing.Point(21, 45);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(51, 20);
            this.labelBPM.TabIndex = 1;
            this.labelBPM.Text = "BPM:";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelScale.Location = new System.Drawing.Point(21, 78);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(56, 20);
            this.labelScale.TabIndex = 2;
            this.labelScale.Text = "Scale:";
            // 
            // selectorBPM
            // 
            this.selectorBPM.Location = new System.Drawing.Point(113, 43);
            this.selectorBPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.selectorBPM.Name = "selectorBPM";
            this.selectorBPM.Size = new System.Drawing.Size(138, 22);
            this.selectorBPM.TabIndex = 3;
            this.selectorBPM.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // ScaleNumeratorScroll
            // 
            this.ScaleNumeratorScroll.Location = new System.Drawing.Point(113, 78);
            this.ScaleNumeratorScroll.Name = "ScaleNumeratorScroll";
            this.ScaleNumeratorScroll.Size = new System.Drawing.Size(58, 22);
            this.ScaleNumeratorScroll.TabIndex = 4;
            this.ScaleNumeratorScroll.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ScaleDenominatorScroll
            // 
            this.ScaleDenominatorScroll.Location = new System.Drawing.Point(197, 78);
            this.ScaleDenominatorScroll.Name = "ScaleDenominatorScroll";
            this.ScaleDenominatorScroll.Size = new System.Drawing.Size(54, 22);
            this.ScaleDenominatorScroll.TabIndex = 5;
            this.ScaleDenominatorScroll.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // DividentText
            // 
            this.DividentText.AutoSize = true;
            this.DividentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DividentText.Location = new System.Drawing.Point(177, 80);
            this.DividentText.Name = "DividentText";
            this.DividentText.Size = new System.Drawing.Size(14, 20);
            this.DividentText.TabIndex = 6;
            this.DividentText.Text = "/";
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.labelBPM);
            this.SettingsBox.Controls.Add(this.DividentText);
            this.SettingsBox.Controls.Add(this.labelScale);
            this.SettingsBox.Controls.Add(this.ScaleDenominatorScroll);
            this.SettingsBox.Controls.Add(this.selectorBPM);
            this.SettingsBox.Controls.Add(this.ScaleNumeratorScroll);
            this.SettingsBox.Location = new System.Drawing.Point(34, 27);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(298, 128);
            this.SettingsBox.TabIndex = 7;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "SettingsBox";
            // 
            // StartMetBtn
            // 
            this.StartMetBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StartMetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartMetBtn.BackgroundImage")));
            this.StartMetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartMetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StartMetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartMetBtn.Location = new System.Drawing.Point(34, 161);
            this.StartMetBtn.Name = "StartMetBtn";
            this.StartMetBtn.Size = new System.Drawing.Size(61, 55);
            this.StartMetBtn.TabIndex = 0;
            this.StartMetBtn.UseVisualStyleBackColor = false;
            this.StartMetBtn.Click += new System.EventHandler(this.StartMetBtnOnClick);
            // 
            // PlayWavBtn
            // 
            this.PlayWavBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayWavBtn.BackgroundImage")));
            this.PlayWavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayWavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PlayWavBtn.Location = new System.Drawing.Point(7, 23);
            this.PlayWavBtn.Name = "PlayWavBtn";
            this.PlayWavBtn.Size = new System.Drawing.Size(66, 40);
            this.PlayWavBtn.TabIndex = 9;
            this.PlayWavBtn.UseVisualStyleBackColor = true;
            this.PlayWavBtn.Visible = false;
            this.PlayWavBtn.Click += new System.EventHandler(this.PlayWavBtnClick);
            // 
            // StopWavBtn
            // 
            this.StopWavBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopWavBtn.BackgroundImage")));
            this.StopWavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopWavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StopWavBtn.Location = new System.Drawing.Point(71, 23);
            this.StopWavBtn.Name = "StopWavBtn";
            this.StopWavBtn.Size = new System.Drawing.Size(67, 40);
            this.StopWavBtn.TabIndex = 10;
            this.StopWavBtn.UseVisualStyleBackColor = true;
            this.StopWavBtn.Visible = false;
            this.StopWavBtn.Click += new System.EventHandler(this.StopWavBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openMidiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.openToolStripMenuItem.Text = "Open Wav";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openWavStripBtn);
            // 
            // openMidiToolStripMenuItem
            // 
            this.openMidiToolStripMenuItem.Name = "openMidiToolStripMenuItem";
            this.openMidiToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.openMidiToolStripMenuItem.Text = "Open Midi";
            this.openMidiToolStripMenuItem.Click += new System.EventHandler(this.openMidiToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tunerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // tunerToolStripMenuItem
            // 
            this.tunerToolStripMenuItem.Name = "tunerToolStripMenuItem";
            this.tunerToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.tunerToolStripMenuItem.Text = "Tuner";
            this.tunerToolStripMenuItem.Click += new System.EventHandler(this.tunerOnClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenu,
            this.settingsToolStripMenu,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenu
            // 
            this.viewHelpToolStripMenu.Image = global::ProjectMillenia_WFA.Properties.Resources.help_icon;
            this.viewHelpToolStripMenu.Name = "viewHelpToolStripMenu";
            this.viewHelpToolStripMenu.Size = new System.Drawing.Size(152, 26);
            this.viewHelpToolStripMenu.Text = "View Help";
            this.viewHelpToolStripMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // settingsToolStripMenu
            // 
            this.settingsToolStripMenu.Name = "settingsToolStripMenu";
            this.settingsToolStripMenu.Size = new System.Drawing.Size(152, 26);
            this.settingsToolStripMenu.Text = "Settings";
            this.settingsToolStripMenu.Click += new System.EventHandler(this.settingsToolStripMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(6, 69);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(132, 40);
            this.recordBtn.TabIndex = 12;
            this.recordBtn.Text = "Record";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // TheEverythingTab
            // 
            this.TheEverythingTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheEverythingTab.Controls.Add(this.tabPage2);
            this.TheEverythingTab.Controls.Add(this.tabPage1);
            this.TheEverythingTab.Location = new System.Drawing.Point(338, 31);
            this.TheEverythingTab.Name = "TheEverythingTab";
            this.TheEverythingTab.SelectedIndex = 0;
            this.TheEverythingTab.Size = new System.Drawing.Size(506, 542);
            this.TheEverythingTab.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Whatever";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.CanvasBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transcribe";
            // 
            // CanvasBox
            // 
            this.CanvasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasBox.Controls.Add(this.MusicSheetBox);
            this.CanvasBox.Controls.Add(this.recordBtn);
            this.CanvasBox.Controls.Add(this.WaveFormBox);
            this.CanvasBox.Controls.Add(this.StopWavBtn);
            this.CanvasBox.Controls.Add(this.PlayWavBtn);
            this.CanvasBox.Location = new System.Drawing.Point(-4, -17);
            this.CanvasBox.Name = "CanvasBox";
            this.CanvasBox.Size = new System.Drawing.Size(506, 546);
            this.CanvasBox.TabIndex = 9;
            this.CanvasBox.TabStop = false;
            this.CanvasBox.Text = "Canvas";
            // 
            // MusicSheetBox
            // 
            this.MusicSheetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicSheetBox.Controls.Add(this.imagePanel);
            this.MusicSheetBox.Controls.Add(this.NextImageBtn);
            this.MusicSheetBox.Controls.Add(this.PrevImageBtn);
            this.MusicSheetBox.Location = new System.Drawing.Point(7, 151);
            this.MusicSheetBox.Name = "MusicSheetBox";
            this.MusicSheetBox.Size = new System.Drawing.Size(493, 389);
            this.MusicSheetBox.TabIndex = 10;
            this.MusicSheetBox.TabStop = false;
            this.MusicSheetBox.Text = "Music Sheet";
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.AutoScroll = true;
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Location = new System.Drawing.Point(52, 21);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(389, 362);
            this.imagePanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(383, 359);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // NextImageBtn
            // 
            this.NextImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextImageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextImageBtn.BackgroundImage")));
            this.NextImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextImageBtn.Enabled = false;
            this.NextImageBtn.Location = new System.Drawing.Point(447, 174);
            this.NextImageBtn.Name = "NextImageBtn";
            this.NextImageBtn.Size = new System.Drawing.Size(40, 40);
            this.NextImageBtn.TabIndex = 1;
            this.NextImageBtn.UseVisualStyleBackColor = true;
            // 
            // PrevImageBtn
            // 
            this.PrevImageBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrevImageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrevImageBtn.BackgroundImage")));
            this.PrevImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrevImageBtn.Enabled = false;
            this.PrevImageBtn.Location = new System.Drawing.Point(6, 174);
            this.PrevImageBtn.Name = "PrevImageBtn";
            this.PrevImageBtn.Size = new System.Drawing.Size(40, 40);
            this.PrevImageBtn.TabIndex = 0;
            this.PrevImageBtn.UseVisualStyleBackColor = true;
            // 
            // WaveFormBox
            // 
            this.WaveFormBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaveFormBox.Controls.Add(this.EndTime_Lbl);
            this.WaveFormBox.Controls.Add(this.WaveForm);
            this.WaveFormBox.Controls.Add(this.StartTime_Lbl);
            this.WaveFormBox.Location = new System.Drawing.Point(141, 21);
            this.WaveFormBox.Name = "WaveFormBox";
            this.WaveFormBox.Size = new System.Drawing.Size(359, 123);
            this.WaveFormBox.TabIndex = 9;
            this.WaveFormBox.TabStop = false;
            this.WaveFormBox.Text = "Wave Form";
            // 
            // EndTime_Lbl
            // 
            this.EndTime_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTime_Lbl.AutoSize = true;
            this.EndTime_Lbl.Location = new System.Drawing.Point(322, 107);
            this.EndTime_Lbl.Name = "EndTime_Lbl";
            this.EndTime_Lbl.Size = new System.Drawing.Size(48, 17);
            this.EndTime_Lbl.TabIndex = 13;
            this.EndTime_Lbl.Text = "- - : - -";
            // 
            // WaveForm
            // 
            this.WaveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaveForm.Location = new System.Drawing.Point(3, 18);
            this.WaveForm.Name = "WaveForm";
            this.WaveForm.PenColor = System.Drawing.Color.DodgerBlue;
            this.WaveForm.PenWidth = 1F;
            this.WaveForm.SamplesPerPixel = 128;
            this.WaveForm.Size = new System.Drawing.Size(353, 102);
            this.WaveForm.StartPosition = ((long)(0));
            this.WaveForm.TabIndex = 0;
            this.WaveForm.WaveStream = null;
            // 
            // StartTime_Lbl
            // 
            this.StartTime_Lbl.AutoSize = true;
            this.StartTime_Lbl.Location = new System.Drawing.Point(6, 107);
            this.StartTime_Lbl.Name = "StartTime_Lbl";
            this.StartTime_Lbl.Size = new System.Drawing.Size(48, 17);
            this.StartTime_Lbl.TabIndex = 12;
            this.StartTime_Lbl.Text = "- - : - -";
            // 
            // MainPage
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 585);
            this.Controls.Add(this.TheEverythingTab);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.StartMetBtn);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Project Millennia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectorBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumeratorScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleDenominatorScroll)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TheEverythingTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CanvasBox.ResumeLayout(false);
            this.MusicSheetBox.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.WaveFormBox.ResumeLayout(false);
            this.WaveFormBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.NumericUpDown selectorBPM;
        private System.Windows.Forms.NumericUpDown ScaleNumeratorScroll;
        private System.Windows.Forms.NumericUpDown ScaleDenominatorScroll;
        private System.Windows.Forms.Label DividentText;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button StartMetBtn;
        private System.Windows.Forms.Button PlayWavBtn;
        private System.Windows.Forms.Button StopWavBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tunerToolStripMenuItem;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.ToolStripMenuItem openMidiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl TheEverythingTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox CanvasBox;
        private System.Windows.Forms.GroupBox MusicSheetBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button NextImageBtn;
        private System.Windows.Forms.Button PrevImageBtn;
        private System.Windows.Forms.GroupBox WaveFormBox;
        private System.Windows.Forms.Label EndTime_Lbl;
        private CustomWaveViewer WaveForm;
        private System.Windows.Forms.Label StartTime_Lbl;
        private System.Windows.Forms.TabPage tabPage2;
    }
}