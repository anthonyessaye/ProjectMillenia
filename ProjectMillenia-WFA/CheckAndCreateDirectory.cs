using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMillenia_WFA
{
    class CheckAndCreateDirectory
    {
       public string folderName { get; set; }
       public string RecordingString { get; set; }
       public string SheetString { get; set; }

        public CheckAndCreateDirectory()
        {
             folderName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Project Millenia/";
             RecordingString = System.IO.Path.Combine(folderName, "Recordings");
             SheetString = System.IO.Path.Combine(folderName, "Sheets");
        }

        public void iMustCreate()
        {
            if (!System.IO.File.Exists(RecordingString))
                System.IO.Directory.CreateDirectory(RecordingString);

            if (!System.IO.File.Exists(SheetString))
                System.IO.Directory.CreateDirectory(SheetString);
            

        }

    }
}
