using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using System.Threading.Tasks;

namespace Bank.Lib.Data.FileOperation
{
    public class FileWriter
    {
        private readonly FileOpening openfile;
        public FileWriter(FileOpening fileOpening)
        {
            openfile = fileOpening;
        }
        public void FileWrite(List<string> record, string filename)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var file = openfile.OpenFile(filename, "create");
            using StreamWriter writer = new StreamWriter(file);
            
            foreach(var item in record)
            {
                stringBuilder.Append(item + ";");
                //writer.Write(item+";");
            }
            writer.WriteLine(stringBuilder);
        }


        public void FileUpdateLine(string key, string filename, List<string> record)
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            string path = openfile.FilePathConstruct(filename);
            //StreamReader sr = new StreamReader(file);
            string[] AllLines = File.ReadAllLines(path);
            var file = openfile.OpenFile(filename, "readwrite");
            StreamWriter sw = new StreamWriter(file);
            for(int line=0;  line<AllLines.Length; line++)
            {
                if (AllLines[line].IndexOf(key, StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    foreach (var item in record)
                    {
                        stringBuilder.Append(item + ";");
                        //writer.Write(item+";");
                    }
                    sw.WriteLine(stringBuilder);
                    break;
                }
            }
            sw.Close();
            //sr.Close();
        }
    }
}
