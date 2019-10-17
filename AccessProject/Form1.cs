using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;


namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_submitVals_Click(object sender, EventArgs e)
        {
            Writer.createDatabase(textBox_dbName.Text);

            List<string> tableNames = new List<string>
            {
                textBox_tblName1.Text,textBox_tblName2.Text,textBox_tblName3.Text
            };

            
            List<string> tableContents = new List<string>
            {
                textBox_tbl1Cont1.Text,
                textBox_tbl1Cont2.Text,
                textBox_tbl1Cont3.Text,

                textBox_tbl2Cont1.Text,
                textBox_tbl2Cont2.Text,
                textBox_tbl2Cont3.Text,

                textBox_tbl3Cont1.Text,
                textBox_tbl3Cont2.Text,
                textBox_tbl3Cont3.Text,


            };

            List<string> tableContentDataType = new List<string>
            {
                comboBox_dataType1.Text,
                comboBox_dataType2.Text,
                comboBox_dataType3.Text
            };


            //while (tableContentsEmpty = false){}  
            //It might be better to turn each table into a class instead of using an array
            //Class Table 
            //Could create a button to add additional tables, every time that button is clicked the table total goes up,
            //getTableAmount method should return a total amount of entries into a table, 
            //getTableName will use textBox_tableName(x).Text
            //getTableContents will use textBox_table(x)Cont(x).Text
            //
            //

                       
            Writer.createTable(tableNames);
            Writer.createRow(tableNames, tableContents, tableContentDataType);
            

        }


        class Table
        {
            public string tableName { get { return tableName; } set { tableName = value;} }
            public int tableEntries { get { return tableEntries; } set { tableEntries = value; } }
            public string tableContents { get { return tableContents; } set { tableContents = value;} }
            public string tableContentsTypes { get { return tableContentsTypes; } set { tableContentsTypes = value; } }


            public Table ()
            {

                
                /*void getTableName(string _tableName)
                {
                    tableName = _tableName;
                };

                void getTableEntries(int _tableEntries)
                {
                    tableEntries = _tableEntries;
                };

                void getTableContents(string _tableContents)
                {
                    tableContents = _tableContents;
                };*/
            }

            

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
