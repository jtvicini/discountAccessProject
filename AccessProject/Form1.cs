﻿using System;
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


            String[,] tableContentArray = new string[3,4]
            {

            {
            textBox_tblName1.Text,
            textBox_tbl1Cont1.Text,
            textBox_tbl1Cont2.Text,
            textBox_tbl1Cont3.Text,
            },
            
            {
            textBox_tblName2.Text,
            textBox_tbl2Cont1.Text,
            textBox_tbl2Cont2.Text,
            textBox_tbl2Cont3.Text,
            },

            {
            textBox_tblName3.Text,
            textBox_tbl1Cont3.Text,
            textBox_tbl1Cont3.Text,
            textBox_tbl3Cont3.Text,
            }

            };



            for (int i = 0; i < tableNameArray.Length; i++)
            {

                Writer.createTable(tableNameArray[i]);


                /*for (int n = 0; n < tableNameArray.GetUpperBound(0); n++)
                {
                    Writer.createRow(tableContentArray[0,i]);
                    Writer.createRow(tableContentArray[1, i]);
                    Writer.createRow(tableContentArray[2, i]);
                }*/

                Writer.createRow(tableContentArray);
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
