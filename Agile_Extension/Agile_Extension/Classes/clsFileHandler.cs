using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Agile_Extension.Classes
{
    class clsFileHandler
    {
      
        private static string path = Application.StartupPath;
        private static string file_folder = "\\Role";
        private static string full_path = path + file_folder;
        private static string file_name = full_path += "\\role.txt";
        public void writeToFile(string role)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file_name))
                {
                    writer.WriteLine(role);
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }

        public string readFromFile()
        {
            try
            {
                string line;
                using (StreamReader reader = new StreamReader(file_name))
                {
                    line = reader.ReadToEnd();
                    return line;
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }

            return "file not found";
        }

        public void deleteFile()
        {
            try
            {
                File.Delete(file_name);
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
