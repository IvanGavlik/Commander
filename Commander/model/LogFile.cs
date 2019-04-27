using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.model
{
    public class LogFile
    {

        public static void info(params String[] values)
        {
            String filePath = Settings.GetInstance().LogFilePath;
            if (filePath == null)
            {
                return;
            }

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    writeToFile(sw, values);
                    sw.Close();
                }
            }

            using (StreamWriter sw = File.AppendText(filePath))
            {
                writeToFile(sw, values);
                sw.Close();
            }
        }

        private static void writeToFile(StreamWriter sw, params String[] values) {
            foreach(String value in values)
            {
                sw.WriteLine(DateTime.Now.ToString() + "::"+ value);
            }
        }
    }
}
