using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Agile_Extension.Classes
{
    class clsFileHandler
    {

        #region INSTANCE_VARIABLES
        private static string path = Path.GetTempPath();
        private const string ROLE_FILE = "\\Role.txt";
        private const string USER_INFO = "\\User.txt";
        private const string PROJECTS_INFO = "\\Projects.txt";
        private const string CURRENT_PROJ = "\\Current_Project.txt";
        private const string CURRENT_SPR = "\\Current_Sprint.txt";
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

        public string get_current_project()
        {
            return CURRENT_PROJ;
        }

        public string get_current_sprint()
        {
            return CURRENT_SPR;
        }
        
        #region METHODS
        public void writeToFile(string param, string file)
        {
            try
            {
                Debug.WriteLine("WRITE TO FILE: " + path);
                using (StreamWriter writer = new StreamWriter(path + file))
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
                using (StreamReader reader = new StreamReader(path + file))
                {
                    line = reader.ReadToEnd();
                    line = line.Trim();
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
                using(StreamReader reader = new StreamReader(path + file))
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

            public void writeMutlipleLines(JArray content, string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path + file))
                {
                    for (int i = 0; i < content.Count; i++)
                    {
                        writer.Write(content[i].ToString() +"\r\n");
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
                File.Delete(path + file);
            }
            catch(IOException e)
            {
                Debug.WriteLine(e);
            }
        }
        #endregion
    }
}
