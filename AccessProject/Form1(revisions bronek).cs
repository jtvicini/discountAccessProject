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

            String[] tableContentArray = new string[9]
            {
                textBox_tbl1Cont1.Text, textBox_tbl1Cont2.Text, textBox_tbl1Cont3.Text,
                textBox_tbl2Cont1.Text, textBox_tbl2Cont2.Text, textBox_tbl2Cont3.Text,
                textBox_tbl1Cont3.Text, textBox_tbl1Cont3.Text, textBox_tbl3Cont3.Text
            };

            String[] dataTypeArray = new string[3]
            {
                comboBox_dataType1.Text, comboBox_dataType2.Text, comboBox_dataType3.Text

            };

            //CREATE MULTIDIMENSIONAL ARRAY 3 ROWS 3 COLUMNS
            /*for (int i = 0; i < tableNameArray.Length; i++)
            {

                Writer.createTable(tableNameArray[i]);
                int n , j;
                for (n = 0, j = 0; n < tableContentArray.Length; j < tableNameArray.Length; n++)
                {
                    Writer.createRow(tableContentArray[n], tableNameArray, dataTypeArray );
                }
            }
            */

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dataType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
