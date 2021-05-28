using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecLog
{
    public class LogJournal
    {
        public string PathFile;
        public byte[] BinaryData;
        public StringBuilder Data = new StringBuilder();

        public LogJournal(string pathFile)
        {
            PathFile = pathFile;

            using (StreamReader file = new StreamReader(pathFile))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Data.Append("\n");
                    Data.Append(line);
                    Data.Append("\n");
                }
            }

            BinaryData = File.ReadAllBytes(pathFile);
        }
    }
}
    