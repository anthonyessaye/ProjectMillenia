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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            toCenter();
        }

        private void toCenter (string description)
        {
            richTextBox.Text= description;
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void toCenter()
        {
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0)
               toCenter("Project Millennia\nA software developed by Anthony Essaye\n\nThe aim of this application is to process RAW data recorded by musicians and output the corresponding music sheet calculated using algorithms that follow the rules of the music theory to the up-most accuracy\n\nThis project wouldn’t be possible if it weren't for the components used in it. Listed to the left are the components used with proper credits for each piece of code used.");

            if (listBox.SelectedIndex == 1)
                toCenter("NAudio\n\nNAudio is an open source .NET audio and MIDI library, containing dozens of useful audio related classes intended to speed development of audio related utilities in .NET. It has been in development since 2002 and has grown to include a wide variety of features. While some parts of the library are relatively new and incomplete, the more mature features have undergone extensive testing and can be quickly used to add audio capabilities to an existing .NET application. NAudio can be quickly added to your .NET application using NuGet\n\nhttps://naudio.codeplex.com/");

        }
    }
}
