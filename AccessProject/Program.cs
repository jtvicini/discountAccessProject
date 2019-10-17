using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        
       
        public class Writer
        {


            public static void createDatabase(string databaseName)
            {


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\test.txt";

                using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine("CREATE DATABASE " + databaseName + ";" + "\n" + "USE " + databaseName + ";" + "\n"); }
            }
            
            public static void createTable(List<string> tableName)
            {


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\test.txt";

                for (int i = 0; i < 3;)
                {
                    using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine("CREATE TABLE " + tableName[i] + "\n"); }
                    i++;
                }
            }

           

            public static void createRow(List<string> tableName, List<string> rowName, List<string> dataType)
            {


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\test.txt";
                for (int i = 0, n = 0; i < 3;)//rowName.GetUpperBound(0); i++)
                {



                    
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        if (i == 1){ n = 3; }
                        if (i == 2){ n = 6; }                                                                          //tablename    //tableBox1      //datatype1        //tableBox2        //datatype1        //tableBox3     //datatype1`   
                        sw.WriteLine(String.Format("ALTER TABLE {0} \nADD {1}{2},{3}{4},{5}{6};\n", tableName[i], rowName[n], dataType[i], rowName[n+1], dataType[i], rowName[n+2], dataType[i]));
                        i++;                                                                     //|_____________| |_________________________________| |____________________________________| |________________________________|    
                        
                    }
                }
            }
        }
    }
}

