using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ChangeName
    {
        public void  ChanceName(string folderpath)
        {
            int i = 1;
           
            foreach (var file in Directory.GetFiles(folderpath))
            {
                try
                {
                    string fullFileName = file;
                    string fileExtention = Path.GetExtension(fullFileName);
                    string name = Path.GetFileName(fullFileName);
                    string path = fullFileName.Replace(name, "");
                    string newName = string.Format("{0}{1}", i, fileExtention);
                    File.Move(fullFileName, path + newName);
                    i++;
                }
                catch (Exception)
                {

                    i++;
                }
}

        }
    }
}
