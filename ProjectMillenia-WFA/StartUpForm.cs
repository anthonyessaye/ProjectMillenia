using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMillenia_WFA
{
    public partial class StartUpForm : Form
    {
        Thread TranscribeThread;
        Thread LearnThread;


        public StartUpForm()
        {
            InitializeComponent();

            Thread SplashThread = new Thread(new ThreadStart(splash));
            SplashThread.Start();
            Thread.Sleep(3000);
            SplashThread.Abort();

            LearnTxtBox.SelectAll();
            LearnTxtBox.SelectionAlignment = HorizontalAlignment.Center;
            TranscribeTxtBox.SelectAll();
            TranscribeTxtBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void splash()
        {
            Application.Run(new SplashScreen());
        }

        private void transcribeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TranscribeThread = new Thread(openTrancribeForm);
            TranscribeThread.SetApartmentState(ApartmentState.STA);
            TranscribeThread.Start();
        }

        private void openTrancribeForm()
        {
            Application.Run(new TranscribePage());
        }
    }
}
