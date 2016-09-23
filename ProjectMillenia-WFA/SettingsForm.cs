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
    public partial class SettingsForm : Form
    {
        public NAudio.Wave.WaveIn sourceStream { get; set; }
        public NAudio.Wave.DirectSoundOut outputDevice { get; set; }

        public SettingsForm()
        {
            InitializeComponent();

            List<NAudio.Wave.WaveInCapabilities> InputSourcesList = new List<NAudio.Wave.WaveInCapabilities>();

            for(int i=0; i< NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                InputSourcesList.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
                 
            }

            inputDevicesSelector.Items.Clear();
            foreach(var input in InputSourcesList)
            {
                inputDevicesSelector.Items.Add(input.ProductName);
            }



        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            //Thanks for Tim Huffman for this solution

            
        }

        private void RefreshSourcesBtn_Click(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> InputSourcesList = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                InputSourcesList.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            }

            inputDevicesSelector.Items.Clear();
            foreach (var input in InputSourcesList)
            {
                inputDevicesSelector.Items.Add(input.ProductName);
            }
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            if (inputDevicesSelector.SelectedItem == null)
            {
                MessageBox.Show("No Input Device Selected");
                return;
            }

            int deviceNumber = inputDevicesSelector.SelectedIndex;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            //NAudio.Wave.WaveInProvider waveIn = new NAudio.Wave.WaveIn(sourceStream);

            outputDevice = new NAudio.Wave.DirectSoundOut();
            //outputDevice.Init(waveIn);

           // outputDevice.Play();

            Hide();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Project Millennia\n\nYou have to configure settings before use.");
        }
    }
}
