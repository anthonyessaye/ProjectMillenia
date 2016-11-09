using NAudio.Gui;
using NAudio.Wave;
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



            using (WaveFileReader reader = new WaveFileReader(ChooseWav.FileName))
            {
                IWaveProvider stream32 = new Wave16ToFloatProvider(reader);
                IWaveProvider stream16 = new WaveFloatTo16Provider(stream32);
                using (WaveFileWriter converted = new WaveFileWriter("C:/Millennia/test.wav", stream16.WaveFormat))
                {
                    // buffer length needs to be a power of 2 for FFT to work nicely
                    // however, make the buffer too long and pitches aren't detected fast enough
                    // successful buffer sizes: 8192, 4096, 2048, 1024
                    // (some pitch detection algorithms need at least 2048)
                    byte[] buffer = new byte[131072];
                    int bytesRead;
                    do
                    {
                        bytesRead = stream16.Read(buffer, 0, buffer.Length);
                        converted.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0 && converted.Length < reader.Length);
                }MessageBox.Show("FFT has been applied here, but it has not been implemented yet!");
            }

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
