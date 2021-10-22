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

        #region INSTANCE_VARIABLES
        private static string path = Application.StartupPath;
        private static string file_folder = "\\Role";
        private static string full_path = path + file_folder;
        private const string ROLE_FILE = "\\Role.txt";
        private const string USER_INFO = "\\User.txt";
        private const string PROJECTS_INFO = "\\Projects.txt";
        #endregion

        public string get_role_file()
        {
            return ROLE_FILE;
        }

        public string get_user_file()
        {
            return USER_INFO;
        }

        public string get_project_file()
        {
            return PROJECTS_INFO;
        }

        
        #region METHODS
        public void writeToFile(string param, string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(full_path + file))
                {
                    writer.WriteLine(param);
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }
        public string readFromFile(string file)
        {
            try
            {
                string line;
                using (StreamReader reader = new StreamReader(full_path + file))
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

        public List<string> readMultipleLinesFromFIle(string file)
        {
            try
            {
                List<string> list = new List<string>();
                using(StreamReader reader = new StreamReader(full_path + file))
                {
                    while(!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if(line != "")
                        {
                            list.Add(line);
                        }
                    }
                    return list;
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine(e);
            }

            return null;
        }

            public void writeMutlipleLines(List<string> list, string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(full_path + file))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        writer.Write(list[i].ToString());
                    }
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }

        public void deleteFile(string file)
        {
            try
            {
                File.Delete(full_path + file);
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }
        #endregion
    }
}
