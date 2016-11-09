using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidiSheetMusic;
using NAudio;
using System.IO;
using System.Drawing;

namespace ProjectMillenia_WFA
{
    class MidiHandler
    {
        private OpenFileDialog midiFile = null;
        public string StaticPngLocation { get; set; }
        public int StaticPageNumber { get; set; }
        public int PageNumber = 1;
        public string image_filename { get; set; }
        private string[] argv;
        

        public string SheetFileSaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Project Millenia/Sheets/";

        public MidiHandler()
        {
           

            
                midiFile = new OpenFileDialog();
                midiFile.Filter = "Midi File (*.mid)|*.mid";
                if (midiFile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                //ext = Path.GetExtension(midiFile.FileName);

                argv = new string[] { midiFile.FileName };
                image_filename = Path.GetFileNameWithoutExtension(midiFile.FileName);
            

        }

       


        public void ParseToSheet()
        {
            
            string filename = argv[0];
            SheetMusic sheet = new SheetMusic(filename, null);

            int numpages = sheet.GetTotalPages();
            StaticPageNumber = numpages;

            bool removeExt = false;
            string[] image_filenameWithExtension = filename.Split('.');
            foreach (string s in image_filenameWithExtension)
            {
                if (removeExt == false)
                {
                    image_filenameWithExtension[0] = s;
                    removeExt = true;
                }

            }

            
            StaticPngLocation = SheetFileSaveLocation + image_filename;

            for (int page = 1; page <= numpages; page++)
            {
                Bitmap bitmap = new Bitmap(SheetMusic.PageWidth + 40,
                                           SheetMusic.PageHeight + 40);
                Graphics pngSheetDraw = Graphics.FromImage(bitmap);
                sheet.DoPrint(pngSheetDraw, page);
                bitmap.Save(SheetFileSaveLocation + image_filename + "_" + page + ".png",
                            System.Drawing.Imaging.ImageFormat.Png);
                pngSheetDraw.Dispose();
                bitmap.Dispose();
            }
        }


    }
}
