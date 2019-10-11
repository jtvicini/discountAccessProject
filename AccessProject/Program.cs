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

            public static void createTable(string tableName)
            {


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\test.txt";

                using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine("CREATE TABLE " + tableName + "\n" ); }
            }

            public static void createRow(string rowName)
            {


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "\\test.txt";

                using (StreamWriter sw = File.AppendText(path)) { sw.WriteLine("(" + rowName + ")" ); }
            }
        }
    }
}

