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


            String[] tableNameArray = new string[3] { textBox_tblName1.Text, textBox_tblName2.Text, textBox_tblName3.Text };


            String[,] tableContentArray = new string[3,5]
            {
            //AN SQL COMMAND WILL LOOK LIKE THIS; 
            //ALTER TABLE table_name
            //ADD column_name data_type, column_name data_type, column_name data_type;
            
            //table_name is contained in [0,0], [1,0], and [2,0]
            //column_names are contained in [tableNumber , 1-3]
            //data_type is contained in [tableNumber, 4]
            
            //TODO
            //(need to add in a 4th row for datatype)-ADD columnName data_type- DONE 10/15/19; 
            //
            {
            textBox_tblName1.Text, // [0,0]
            textBox_tbl1Cont1.Text,// [0,1]
            textBox_tbl1Cont2.Text,// [0,2]
            textBox_tbl1Cont3.Text,// [0,3]
            comboBox_dataType1.Text// [0,4]
            },
            
            {
            textBox_tblName2.Text, // [1,0]
            textBox_tbl2Cont1.Text,// [1,1]
            textBox_tbl2Cont2.Text,// [1,2]
            textBox_tbl2Cont3.Text,// [1,3]
            comboBox_dataType2.Text// [0,4]
            },

            {
            textBox_tblName3.Text, // [2,0]
            textBox_tbl3Cont1.Text,// [2,1]
            textBox_tbl3Cont2.Text,// [2,2]
            textBox_tbl3Cont3.Text,// [2,3]
            comboBox_dataType3.Text// [2,4]
            }

            };


            Writer.createTable(tableContentArray);
            Writer.createRow(tableContentArray);
          

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
