using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bank.Lib.Data.FileOperation
{
    public class FileOpening
    {
        public FileStream OpenFile(string textFileName, string mode)
        {
            var filepath = FilePathConstruct(textFileName);
            FileStream stream = null;
            FileInfo file = new FileInfo(filepath);
            if (mode == "read" && file.Exists)
                stream = file.Open(FileMode.Open);
            else if (mode == "read" && !file.Exists)
                throw new FileNotFoundException("File Does not Exist");
            else if (mode == "create" && !file.Exists)
                stream = file.Open(FileMode.Create);
            else if (mode == "create" && file.Exists)
                stream = file.Open(FileMode.Append);
            else if (mode == "readwrite" && file.Exists)
                stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
            return stream;
        }

        public string FilePathConstruct(string textFileName)
        {
            var currDir = Environment.CurrentDirectory;
            string newPath = "";
            String[] currArr = currDir.Split('\\');
            for (int i = 0; i < currArr.Length; i++)
            {
                if (currArr[i] == "Bank")
                {
                    newPath += currArr[i] + "\\";
                    break;
                }
                newPath += currArr[i] + "\\";
            }
            var path = newPath + "Bank.Lib.Data" + "\\";
            path += textFileName.Trim();
            return path;
        }
    }
}
