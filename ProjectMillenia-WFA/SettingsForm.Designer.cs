namespace ProjectMillenia_WFA
{
    partial class SettingsForm
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
            this.SettingsTabMenu = new System.Windows.Forms.TabControl();
            this.inputSettingsTab = new System.Windows.Forms.TabPage();
            this.InputSubPanelLeft = new System.Windows.Forms.Panel();
            this.ChooseInputLbl = new System.Windows.Forms.Label();
            this.inputDevicesSelector = new System.Windows.Forms.ComboBox();
            this.InputSubPanelRight = new System.Windows.Forms.Panel();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.RefreshSourcesBtn = new System.Windows.Forms.Button();
            this.outputSettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsTabMenu.SuspendLayout();
            this.inputSettingsTab.SuspendLayout();
            this.InputSubPanelLeft.SuspendLayout();
            this.InputSubPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTabMenu
            // 
            this.SettingsTabMenu.Controls.Add(this.inputSettingsTab);
            this.SettingsTabMenu.Controls.Add(this.outputSettingsTab);
            this.SettingsTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTabMenu.Location = new System.Drawing.Point(0, 0);
            this.SettingsTabMenu.Name = "SettingsTabMenu";
            this.SettingsTabMenu.SelectedIndex = 0;
            this.SettingsTabMenu.Size = new System.Drawing.Size(1037, 652);
            this.SettingsTabMenu.TabIndex = 0;
            // 
            // inputSettingsTab
            // 
            this.inputSettingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.inputSettingsTab.Controls.Add(this.InputSubPanelLeft);
            this.inputSettingsTab.Controls.Add(this.InputSubPanelRight);
            this.inputSettingsTab.Location = new System.Drawing.Point(4, 25);
            this.inputSettingsTab.Name = "inputSettingsTab";
            this.inputSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputSettingsTab.Size = new System.Drawing.Size(1029, 623);
            this.inputSettingsTab.TabIndex = 0;
            this.inputSettingsTab.Text = "Input";
            // 
            // InputSubPanelLeft
            // 
            this.InputSubPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputSubPanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputSubPanelLeft.Controls.Add(this.ChooseInputLbl);
            this.InputSubPanelLeft.Controls.Add(this.inputDevicesSelector);
            this.InputSubPanelLeft.Location = new System.Drawing.Point(6, 7);
            this.InputSubPanelLeft.Name = "InputSubPanelLeft";
            this.InputSubPanelLeft.Size = new System.Drawing.Size(724, 608);
            this.InputSubPanelLeft.TabIndex = 3;
            // 
            // ChooseInputLbl
            // 
            this.ChooseInputLbl.AutoSize = true;
            this.ChooseInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChooseInputLbl.Location = new System.Drawing.Point(3, 10);
            this.ChooseInputLbl.Name = "ChooseInputLbl";
            this.ChooseInputLbl.Size = new System.Drawing.Size(169, 20);
            this.ChooseInputLbl.TabIndex = 0;
            this.ChooseInputLbl.Text = "Choose Input Device:";
            // 
            // inputDevicesSelector
            // 
            this.inputDevicesSelector.FormattingEnabled = true;
            this.inputDevicesSelector.Location = new System.Drawing.Point(197, 6);
            this.inputDevicesSelector.Name = "inputDevicesSelector";
            this.inputDevicesSelector.Size = new System.Drawing.Size(522, 24);
            this.inputDevicesSelector.TabIndex = 1;
            // 
            // InputSubPanelRight
            // 
            this.InputSubPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputSubPanelRight.BackColor = System.Drawing.SystemColors.Control;
            this.InputSubPanelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputSubPanelRight.Controls.Add(this.saveSettingsBtn);
            this.InputSubPanelRight.Controls.Add(this.RefreshSourcesBtn);
            this.InputSubPanelRight.Location = new System.Drawing.Point(736, 7);
            this.InputSubPanelRight.Name = "InputSubPanelRight";
            this.InputSubPanelRight.Size = new System.Drawing.Size(287, 608);
            this.InputSubPanelRight.TabIndex = 2;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsBtn.Location = new System.Drawing.Point(3, 569);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(279, 34);
            this.saveSettingsBtn.TabIndex = 2;
            this.saveSettingsBtn.Text = "Save Settings";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // RefreshSourcesBtn
            // 
            this.RefreshSourcesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshSourcesBtn.Location = new System.Drawing.Point(3, 3);
            this.RefreshSourcesBtn.Name = "RefreshSourcesBtn";
            this.RefreshSourcesBtn.Size = new System.Drawing.Size(279, 34);
            this.RefreshSourcesBtn.TabIndex = 1;
            this.RefreshSourcesBtn.Text = "Refresh Input Devices List";
            this.RefreshSourcesBtn.UseVisualStyleBackColor = true;
            this.RefreshSourcesBtn.Click += new System.EventHandler(this.RefreshSourcesBtn_Click);
            // 
            // outputSettingsTab
            // 
            this.outputSettingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.outputSettingsTab.Location = new System.Drawing.Point(4, 25);
            this.outputSettingsTab.Name = "outputSettingsTab";
            this.outputSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputSettingsTab.Size = new System.Drawing.Size(1029, 623);
            this.outputSettingsTab.TabIndex = 1;
            this.outputSettingsTab.Text = "Output";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 652);
            this.Controls.Add(this.SettingsTabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.SettingsTabMenu.ResumeLayout(false);
            this.inputSettingsTab.ResumeLayout(false);
            this.InputSubPanelLeft.ResumeLayout(false);
            this.InputSubPanelLeft.PerformLayout();
            this.InputSubPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsTabMenu;
        private System.Windows.Forms.TabPage inputSettingsTab;
        private System.Windows.Forms.TabPage outputSettingsTab;
        private System.Windows.Forms.Label ChooseInputLbl;
        private System.Windows.Forms.Panel InputSubPanelRight;
        private System.Windows.Forms.Button RefreshSourcesBtn;
        private System.Windows.Forms.Panel InputSubPanelLeft;
        private System.Windows.Forms.Button saveSettingsBtn;
        public System.Windows.Forms.ComboBox inputDevicesSelector;
    }
}