using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjectMillenia_WFA
{
    class Metronome
    {
        private Timer mTime = new Timer();
        private int aMinute = 60000;

        private double mInterval;

        public int BPM { get; set; }
        public double scale { get; set;}

        private int beepCounter = 1;
        public bool isWorking = false;



        public Metronome(int bpm, double ScaleSize)
        {
            this.mTime.Elapsed += MTime_Elapsed;

            this.BPM = bpm;
            this.scale = ScaleSize;

            this.mInterval = aMinute*bpm;
            mTime.Interval += mInterval;


        }

        public void Start()
        {
            mTime.Start();
           
        }
        public void Stop()
        {
           
            mTime.Stop();
           
        }
      


        


        private void MTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            

            if (beepCounter % scale == 0)
            {
                Console.Beep(4000, 100);
                beepCounter = 1;
            }

            else
            {
                Console.Beep(5000, 100);
                beepCounter++;
            }

        }
    }
}
