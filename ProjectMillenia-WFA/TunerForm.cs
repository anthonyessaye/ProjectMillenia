using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectMillenia_WFA
{
    public partial class TunerForm : Form
    {

        SettingsForm openSettingsForm = new ProjectMillenia_WFA.SettingsForm();
        public TunerForm(SettingsForm OpenedSettings)
        {
            InitializeComponent();
            openSettingsForm = OpenedSettings;
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
