using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bank.Lib.Data.FileOperation
{
    class FileReader
    {
        private readonly FileOpening _fileopen;
        public FileReader(FileOpening fileOpening)
        {
            _fileopen = fileOpening;
        }
        /// <summary>
        /// Retrieve one record from file 
        /// </summary>
        /// <param name="Searchkey"></param>
        /// <param name="filename"></param>
        /// <returns>it can return a null or an Array of Field in file</returns>
        public string[] ReadOne(string Searchkey, string filename)
        {
            var file = _fileopen.OpenFile(filename, "read");
            var sr = new StreamReader(file);
            String[] RecordField = null;
            //sr = StreamRead(filename);
            while (!sr.EndOfStream)
            {
                RecordField = Find(sr, Searchkey);
                break;
            }
            sr.Close();
            return RecordField;
        }
        /// <summary>
        /// Search the file using a specified key
        /// </summary>
        /// <param name="Searchkey"></param>
        /// <param name="filename"></param>
        /// <returns>bool</returns>
        public bool Search(string Searchkey, string filename)
        {
            var file = _fileopen.OpenFile(filename, "read");
            var sr = new StreamReader(file);
            bool isFound = false;
            //sr = StreamRead(filename);
            while (!sr.EndOfStream)
            {
               if(Find(sr, Searchkey) != null)
                   isFound = true;
            }
            sr.Close();
            return isFound;
        }
        /// <summary>
        /// Read Many Record from the file
        /// </summary>
        /// <param name="Searchkey"></param>
        /// <param name="filename"></param>
        /// <returns>List of records or Empty List</returns>
        public List<string[]> ReadMany(string Searchkey, string filename)
        {
            List<String[]> listOfRecord = new List<string[]>();
            //String[] RecordField = null;
            var sr = StreamRead(filename);
            while (!sr.EndOfStream)
            {
                listOfRecord.Add(Find(sr,Searchkey));
            }
            sr.Close();
            return listOfRecord;
        }
        /// <summary>
        /// Finds a particular record and returns it
        /// </summary>
        /// <param name="sr"></param>
        /// <param name="SearchKey"></param>
        /// <returns>null or An Array of Records</returns>
        private string[] Find(StreamReader sr, string SearchKey)
        {
            string[] RecordField = null;
            string line = sr.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                
                if (line.IndexOf(SearchKey, StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    RecordField = line.Split(";");
                    break;
                }
                line = sr.ReadLine();

            }
                
            return RecordField;
        }
        /// <summary>
        /// Open Stream for read of file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>StreamReader</returns>
        private StreamReader StreamRead(string filename)
        {
            var file = _fileopen.OpenFile(filename, "read");
            var sr = new StreamReader(file);
            return sr;
        }
    }
}
