using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using System.Threading;
using System.IO;
using MidiToSheetMusic;
using MidiSheetMusic;





/* I implemented the NAudio Class in OpenAudio.cs and RecordAudio.cs */
// Metronome icon by Dale Humphries (used with permission)
// Play icon by Oliver
// Help icon from freeiconspng.com Uploader: Unknown

namespace ProjectMillenia_WFA
{
    public partial class MainPage : Form
    {
        SettingsForm openSettingsForm = new ProjectMillenia_WFA.SettingsForm();
        CheckAndCreateDirectory ProjectFolders = new CheckAndCreateDirectory();
        

        public MainPage()
        {
            InitializeComponent();

            
            Thread SplashThread = new Thread(new ThreadStart(splash));
            SplashThread.Start();
            Thread.Sleep(3000);
            SplashThread.Abort();

            ProjectFolders.iMustCreate();
            openSettingsForm.Show();


        

        }

        public void splash()
        {
            Application.Run(new SplashScreen());
        }

        private string RecordFileSaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Project Millenia/Recordings/";
        private string RecordFileSaveLocationUpgrader(string FileName, string FilePath)
        {
            
            int tries = 1;
            string validatedName = FileName + tries.ToString() + ".wav";
            while (File.Exists( FilePath + validatedName))
            {
                //validatedName = string.Format("{0} [{1}]", FileName, tries++);
                tries++;
                validatedName = FileName + tries.ToString() + ".wav";
            }


            return FilePath + validatedName;
        }
        


        Metronome BasicTone = new Metronome();
        OpenAudio TheWavSignal;
        MidiHandler TheMidi;
       


        private NAudio.Wave.WaveFileWriter waveWriter = null;
        public bool isSheetClicked = false;
        public bool isSettingsOpen = false;
        public bool isRecording = false;


        private void StartMetBtnOnClick(object sender, EventArgs e)
        {
            

            if (BasicTone.isWorking == false)
            {

                BasicTone.BPM = Convert.ToInt32(selectorBPM.Value);
                BasicTone.scaleDenominator = Convert.ToDouble(ScaleDenominatorScroll.Value);
                BasicTone.scaleNumerator = Convert.ToDouble(ScaleNumeratorScroll.Value);
                BasicTone.SetInterval();

                SettingsBox.Enabled = false;
                BasicTone.Start();
                BasicTone.isWorking = true;
                
            }

            else
            {
                BasicTone.Stop();
                SettingsBox.Enabled = true;
                BasicTone.isWorking = false;
                
            }

           
        }
       
        private void MainPage_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("Welcome to Project Millenia\n\nYou have to configure settings before use.");
        }

        private void openWavStripBtn(object sender, EventArgs e )
        {
            TheWavSignal = new OpenAudio();
            TheWavSignal.draw(WaveForm);

            

            StartTime_Lbl.Text = WaveForm.StartPosition.ToString();
            EndTime_Lbl.Text = TheWavSignal.EndTime();

            PlayWavBtn.Visible = true;
            StopWavBtn.Visible = true;
            StopWavBtn.Enabled = false;


            /*  This piece of code was written to represent the way to load file
              into a picture box as a concept. */

            /* DONE- ---- --- -- TO-DO: save png files into a static file and load it from there
             The solution to this was to create a folder in a users Documents Folder and a static folder for the program */

            //  pictureBox.ImageLocation = "C:/Users/antho/Pictures/ashes.png";
            //  pictureBox.SizeMode = PictureBoxSizeMode.Zoom;  
            //  this.pictureBox.MouseClick += new MouseEventHandler(ZoomInControl);




        }

        
        private void openMidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheMidi = new MidiHandler();
            TheMidi.ParseToSheet();


            if (TheMidi.StaticPageNumber > 1)
              NextImageBtn.Enabled = true;
            
              pictureBox.ImageLocation = TheMidi.SheetFileSaveLocation + TheMidi.image_filename + "_" + TheMidi.PageNumber.ToString() + ".png";
              pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox.MouseClick += new MouseEventHandler(ZoomInControl);
            pictureBox.MouseClick += new MouseEventHandler(ZoomOutControl);
             


            MessageBox.Show("This Midi File has been successfully transcribed");
        }

        private void PlayWavBtnClick(object sender, EventArgs e)
        {
            if (TheWavSignal.WhereToPlayWav != null)
            {
                if (TheWavSignal.WhereToPlayWav.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    TheWavSignal.WhereToPlayWav.Pause();
                    PlayWavBtn.BackgroundImage = ProjectMillenia_WFA.Properties.Resources.play_button;


                }

                else 
                {
                    TheWavSignal.Play();
                    TheWavSignal.WhereToPlayWav.Play();
                    PlayWavBtn.BackgroundImage = ProjectMillenia_WFA.Properties.Resources.pause_button;
                    StopWavBtn.Enabled = true;
                }
            }

        }

        private void StopWavBtn_Click(object sender, EventArgs e)
        {
            PlayWavBtn.Text = "Play Wav";

            StopWavBtn.Visible = false;
            PlayWavBtn.Visible = false;

            TheWavSignal.UnDraw(WaveForm);
            TheWavSignal.DisposeWave();

        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
           // TheWavSignal.DisposeWave();

        }

        private void settingsToolStripMenu_Click(object sender, EventArgs e)
        {
                openSettingsForm.Show();
            
        }


        private void ZoomInControl(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Left = imagePanel.Width / 10;
          

            }

       
        }
        private void ZoomOutControl(object sender, MouseEventArgs e)
        {


            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
    

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = imagePanel.Width;
                pictureBox.Height = imagePanel.Height;
                pictureBox.Left = 0 ;
         
                
                
                
            }
        }


        private void tunerOnClick(object sender, EventArgs e)
        {

            TunerForm tuner = new ProjectMillenia_WFA.TunerForm(openSettingsForm);
            tuner.Show();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {


            if (isRecording == false)
            {
                

                openSettingsForm.sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
                waveWriter = new NAudio.Wave.WaveFileWriter(RecordFileSaveLocationUpgrader("Recording", RecordFileSaveLocation), openSettingsForm.sourceStream.WaveFormat);


                openSettingsForm.sourceStream.StartRecording();
                recordBtn.Text = "Stop Recording";
                isRecording = true;
            }


            else
            {
                if (waveWriter != null)
                {
                    openSettingsForm.sourceStream.StopRecording();
                    waveWriter.Dispose();
                    waveWriter = null;
                    isRecording = false;
                    recordBtn.Text = "Record";
                }
            }
            

        }

        public void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
            
        }

        private void NextImageBtn_Click(object sender, EventArgs e)
        {
            if (TheMidi.PageNumber <= TheMidi.StaticPageNumber - 1)
            {
                TheMidi.PageNumber++;
                PrevImageBtn.Enabled = true;
                pictureBox.ImageLocation = TheMidi.StaticPngLocation + "_" + TheMidi.PageNumber.ToString() + ".png";
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (TheMidi.PageNumber == TheMidi.StaticPageNumber)

                {
                    NextImageBtn.Enabled = false;
                  
                }

            }

            
        }

        private void PrevImageBtn_Click(object sender, EventArgs e)
        {

            if (TheMidi.PageNumber <= TheMidi.StaticPageNumber && TheMidi.PageNumber > 1)
            {
                    
                TheMidi.PageNumber--;
                NextImageBtn.Enabled = true;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.ImageLocation = TheMidi.StaticPngLocation + "_" + TheMidi.PageNumber.ToString() + ".png";

                if (TheMidi.PageNumber == 1)
                    PrevImageBtn.Enabled = false;

            }

           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutPage = new AboutForm();
            aboutPage.Show();
        }






        //private void exec_cmd(string arguments)
        //{
        //    System.Diagnostics.Process process = new System.Diagnostics.Process();
        //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        //    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        //    startInfo.FileName = "cmd.exe";
        //    startInfo.Arguments = arguments;
        //    process.StartInfo = startInfo;
        //    process.Start();
        //}
    }
}
