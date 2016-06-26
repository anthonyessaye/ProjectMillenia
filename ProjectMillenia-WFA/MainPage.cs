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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            
        }


        Metronome tone = new Metronome(120, 1);
       

        private void StartMetBtnOnClick(object sender, EventArgs e)
        {
            

            if (tone.isWorking == true)
            {
                tone.Stop();
                StartMetBtn.Text = "Start";
                tone.isWorking = false;
            }
            
            else
            {
                tone.BPM = Convert.ToInt32(selectorBPM.Value);
                tone.scale = Convert.ToDouble(selectorScale.SelectedItem);

                tone.Start();
                StartMetBtn.Text = "Stop";
                tone.isWorking = true;
            }

            
        }

        
    }
}
