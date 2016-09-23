using NAudio.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMillenia_WFA
{
    public class OpenAudio
    {
        public OpenFileDialog ChooseWav = new OpenFileDialog();
        public NAudio.Wave.WaveFileReader OpenedWave = null;
        public NAudio.Wave.DirectSoundOut WhereToPlayWav = null;
      

        public OpenAudio()
        {
            ChooseWav.Filter = "Wave File (*.wav) | *.wav;";
            if (ChooseWav.ShowDialog() != DialogResult.OK) return;

            DisposeWave();
            
            OpenedWave = new NAudio.Wave.WaveFileReader(ChooseWav.FileName);
            WhereToPlayWav = new NAudio.Wave.DirectSoundOut();
            WhereToPlayWav.Init(new NAudio.Wave.WaveChannel32(OpenedWave));
           
            /*
             * OpenedWave is used to work with the opened wav file. WhereToPlayWav is just the output device
             * In this constructor I am first choosing the type of the dialog opened (wav)
             * Then i am disposing of any file that was created before. Then the wav file is chosen
             * After that the wav file is just transfered to the direct output
             */
        }

        public void Play()
        {
            WhereToPlayWav.Play();
        }

        public string EndTime()
        {
            int Minutes = Convert.ToInt32(OpenedWave.TotalTime.TotalMinutes);
            int Seconds = Convert.ToInt32(OpenedWave.TotalTime.TotalSeconds);
            return Minutes.ToString() + " : " + Seconds.ToString();
        }

        public void draw(CustomWaveViewer DrawWave)
        {
           DrawWave.WaveStream = new NAudio.Wave.WaveFileReader(ChooseWav.FileName);
           DrawWave.FitToScreen();
        }

        public void UnDraw(CustomWaveViewer WaveToUnDraw)
        {
            WaveToUnDraw.WaveStream = null;
        }


        public void DisposeWave()
        {
            if (WhereToPlayWav != null)
            {
                if (WhereToPlayWav.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    WhereToPlayWav.Stop();

                WhereToPlayWav.Dispose();
                WhereToPlayWav = null;
            }

            if (OpenedWave != null)
            {
                OpenedWave.Dispose();
                OpenedWave = null;
            }
        }
    }
}
