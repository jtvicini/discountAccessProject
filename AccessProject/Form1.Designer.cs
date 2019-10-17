namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_dbNamePrompt = new System.Windows.Forms.Label();
            this.label_tblNamePrompt = new System.Windows.Forms.Label();
            this.textBox_dbName = new System.Windows.Forms.TextBox();
            this.textBox_tblName3 = new System.Windows.Forms.TextBox();
            this.textBox_tblName1 = new System.Windows.Forms.TextBox();
            this.textBox_tblName2 = new System.Windows.Forms.TextBox();
            this.label_dataTypePrompt = new System.Windows.Forms.Label();
            this.comboBox_dataType1 = new System.Windows.Forms.ComboBox();
            this.comboBox_dataType3 = new System.Windows.Forms.ComboBox();
            this.comboBox_dataType2 = new System.Windows.Forms.ComboBox();
            this.button_submitVals = new System.Windows.Forms.Button();
            this.label_tblContentsPrompt = new System.Windows.Forms.Label();
            this.textBox_tbl1Cont1 = new System.Windows.Forms.TextBox();
            this.textBox_tbl1Cont3 = new System.Windows.Forms.TextBox();
            this.textBox_tbl1Cont2 = new System.Windows.Forms.TextBox();
            this.textBox_tbl2Cont1 = new System.Windows.Forms.TextBox();
            this.textBox_tbl3Cont1 = new System.Windows.Forms.TextBox();
            this.textBox_tbl2Cont2 = new System.Windows.Forms.TextBox();
            this.textBox_tbl3Cont2 = new System.Windows.Forms.TextBox();
            this.textBox_tbl2Cont3 = new System.Windows.Forms.TextBox();
            this.textBox_tbl3Cont3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_dbNamePrompt
            // 
            this.label_dbNamePrompt.AutoSize = true;
            this.label_dbNamePrompt.Location = new System.Drawing.Point(12, 9);
            this.label_dbNamePrompt.Name = "label_dbNamePrompt";
            this.label_dbNamePrompt.Size = new System.Drawing.Size(115, 13);
            this.label_dbNamePrompt.TabIndex = 0;
            this.label_dbNamePrompt.Text = "Enter Database Name:";
            // 
            // label_tblNamePrompt
            // 
            this.label_tblNamePrompt.AutoSize = true;
            this.label_tblNamePrompt.Location = new System.Drawing.Point(20, 75);
            this.label_tblNamePrompt.Name = "label_tblNamePrompt";
            this.label_tblNamePrompt.Size = new System.Drawing.Size(107, 13);
            this.label_tblNamePrompt.TabIndex = 1;
            this.label_tblNamePrompt.Text = "Enter Table Name(s):";
            // 
            // textBox_dbName
            // 
            this.textBox_dbName.Location = new System.Drawing.Point(133, 6);
            this.textBox_dbName.Name = "textBox_dbName";
            this.textBox_dbName.Size = new System.Drawing.Size(100, 20);
            this.textBox_dbName.TabIndex = 2;
            // 
            // textBox_tblName3
            // 
            this.textBox_tblName3.Location = new System.Drawing.Point(133, 127);
            this.textBox_tblName3.Name = "textBox_tblName3";
            this.textBox_tblName3.Size = new System.Drawing.Size(100, 20);
            this.textBox_tblName3.TabIndex = 3;
            // 
            // textBox_tblName1
            // 
            this.textBox_tblName1.Location = new System.Drawing.Point(133, 75);
            this.textBox_tblName1.Name = "textBox_tblName1";
            this.textBox_tblName1.Size = new System.Drawing.Size(100, 20);
            this.textBox_tblName1.TabIndex = 4;
            // 
            // textBox_tblName2
            // 
            this.textBox_tblName2.Location = new System.Drawing.Point(133, 101);
            this.textBox_tblName2.Name = "textBox_tblName2";
            this.textBox_tblName2.Size = new System.Drawing.Size(100, 20);
            this.textBox_tblName2.TabIndex = 5;
            // 
            // label_dataTypePrompt
            // 
            this.label_dataTypePrompt.AutoSize = true;
            this.label_dataTypePrompt.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dataTypePrompt.Location = new System.Drawing.Point(237, 59);
            this.label_dataTypePrompt.Name = "label_dataTypePrompt";
            this.label_dataTypePrompt.Size = new System.Drawing.Size(55, 13);
            this.label_dataTypePrompt.TabIndex = 6;
            this.label_dataTypePrompt.Text = "Data Type";
            // 
            // comboBox_dataType1
            // 
            this.comboBox_dataType1.FormattingEnabled = true;
            this.comboBox_dataType1.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "TIME",
            "CHAR",
            "TEXT"});
            this.comboBox_dataType1.Location = new System.Drawing.Point(240, 75);
            this.comboBox_dataType1.Name = "comboBox_dataType1";
            this.comboBox_dataType1.Size = new System.Drawing.Size(44, 21);
            this.comboBox_dataType1.TabIndex = 7;
            // 
            // comboBox_dataType3
            // 
            this.comboBox_dataType3.FormattingEnabled = true;
            this.comboBox_dataType3.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "TIME",
            "CHAR",
            "TEXT"});
            this.comboBox_dataType3.Location = new System.Drawing.Point(240, 126);
            this.comboBox_dataType3.Name = "comboBox_dataType3";
            this.comboBox_dataType3.Size = new System.Drawing.Size(44, 21);
            this.comboBox_dataType3.TabIndex = 8;
            // 
            // comboBox_dataType2
            // 
            this.comboBox_dataType2.FormattingEnabled = true;
            this.comboBox_dataType2.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "DATE",
            "TIME",
            "CHAR",
            "TEXT"});
            this.comboBox_dataType2.Location = new System.Drawing.Point(240, 102);
            this.comboBox_dataType2.Name = "comboBox_dataType2";
            this.comboBox_dataType2.Size = new System.Drawing.Size(44, 21);
            this.comboBox_dataType2.TabIndex = 9;
            // 
            // button_submitVals
            // 
            this.button_submitVals.Location = new System.Drawing.Point(23, 415);
            this.button_submitVals.Name = "button_submitVals";
            this.button_submitVals.Size = new System.Drawing.Size(75, 23);
            this.button_submitVals.TabIndex = 10;
            this.button_submitVals.Text = "Submit";
            this.button_submitVals.UseVisualStyleBackColor = true;
            this.button_submitVals.Click += new System.EventHandler(this.button_submitVals_Click);
            // 
            // label_tblContentsPrompt
            // 
            this.label_tblContentsPrompt.AutoSize = true;
            this.label_tblContentsPrompt.Location = new System.Drawing.Point(298, 75);
            this.label_tblContentsPrompt.Name = "label_tblContentsPrompt";
            this.label_tblContentsPrompt.Size = new System.Drawing.Size(85, 13);
            this.label_tblContentsPrompt.TabIndex = 11;
            this.label_tblContentsPrompt.Text = "Table Contents: ";
            // 
            // textBox_tbl1Cont1
            // 
            this.textBox_tbl1Cont1.Location = new System.Drawing.Point(389, 72);
            this.textBox_tbl1Cont1.Name = "textBox_tbl1Cont1";
            this.textBox_tbl1Cont1.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl1Cont1.TabIndex = 12;
            this.textBox_tbl1Cont1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox_tbl1Cont3
            // 
            this.textBox_tbl1Cont3.Location = new System.Drawing.Point(601, 72);
            this.textBox_tbl1Cont3.Name = "textBox_tbl1Cont3";
            this.textBox_tbl1Cont3.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl1Cont3.TabIndex = 13;
            this.textBox_tbl1Cont3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_tbl1Cont2
            // 
            this.textBox_tbl1Cont2.Location = new System.Drawing.Point(495, 72);
            this.textBox_tbl1Cont2.Name = "textBox_tbl1Cont2";
            this.textBox_tbl1Cont2.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl1Cont2.TabIndex = 14;
            // 
            // textBox_tbl2Cont1
            // 
            this.textBox_tbl2Cont1.Location = new System.Drawing.Point(389, 98);
            this.textBox_tbl2Cont1.Name = "textBox_tbl2Cont1";
            this.textBox_tbl2Cont1.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl2Cont1.TabIndex = 15;
            // 
            // textBox_tbl3Cont1
            // 
            this.textBox_tbl3Cont1.Location = new System.Drawing.Point(389, 124);
            this.textBox_tbl3Cont1.Name = "textBox_tbl3Cont1";
            this.textBox_tbl3Cont1.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl3Cont1.TabIndex = 16;
            // 
            // textBox_tbl2Cont2
            // 
            this.textBox_tbl2Cont2.Location = new System.Drawing.Point(495, 98);
            this.textBox_tbl2Cont2.Name = "textBox_tbl2Cont2";
            this.textBox_tbl2Cont2.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl2Cont2.TabIndex = 17;
            // 
            // textBox_tbl3Cont2
            // 
            this.textBox_tbl3Cont2.Location = new System.Drawing.Point(495, 124);
            this.textBox_tbl3Cont2.Name = "textBox_tbl3Cont2";
            this.textBox_tbl3Cont2.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl3Cont2.TabIndex = 18;
            // 
            // textBox_tbl2Cont3
            // 
            this.textBox_tbl2Cont3.Location = new System.Drawing.Point(601, 98);
            this.textBox_tbl2Cont3.Name = "textBox_tbl2Cont3";
            this.textBox_tbl2Cont3.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl2Cont3.TabIndex = 19;
            // 
            // textBox_tbl3Cont3
            // 
            this.textBox_tbl3Cont3.Location = new System.Drawing.Point(601, 124);
            this.textBox_tbl3Cont3.Name = "textBox_tbl3Cont3";
            this.textBox_tbl3Cont3.Size = new System.Drawing.Size(100, 20);
            this.textBox_tbl3Cont3.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add more tables";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_tbl3Cont3);
            this.Controls.Add(this.textBox_tbl2Cont3);
            this.Controls.Add(this.textBox_tbl3Cont2);
            this.Controls.Add(this.textBox_tbl2Cont2);
            this.Controls.Add(this.textBox_tbl3Cont1);
            this.Controls.Add(this.textBox_tbl2Cont1);
            this.Controls.Add(this.textBox_tbl1Cont2);
            this.Controls.Add(this.textBox_tbl1Cont3);
            this.Controls.Add(this.textBox_tbl1Cont1);
            this.Controls.Add(this.label_tblContentsPrompt);
            this.Controls.Add(this.button_submitVals);
            this.Controls.Add(this.comboBox_dataType2);
            this.Controls.Add(this.comboBox_dataType3);
            this.Controls.Add(this.comboBox_dataType1);
            this.Controls.Add(this.label_dataTypePrompt);
            this.Controls.Add(this.textBox_tblName2);
            this.Controls.Add(this.textBox_tblName1);
            this.Controls.Add(this.textBox_tblName3);
            this.Controls.Add(this.textBox_dbName);
            this.Controls.Add(this.label_tblNamePrompt);
            this.Controls.Add(this.label_dbNamePrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dbNamePrompt;
        private System.Windows.Forms.Label label_tblNamePrompt;
        private System.Windows.Forms.TextBox textBox_dbName;
        private System.Windows.Forms.TextBox textBox_tblName3;
        private System.Windows.Forms.TextBox textBox_tblName1;
        private System.Windows.Forms.TextBox textBox_tblName2;
        private System.Windows.Forms.Label label_dataTypePrompt;
        private System.Windows.Forms.ComboBox comboBox_dataType1;
        private System.Windows.Forms.ComboBox comboBox_dataType3;
        private System.Windows.Forms.ComboBox comboBox_dataType2;
        private System.Windows.Forms.Button button_submitVals;
        private System.Windows.Forms.Label label_tblContentsPrompt;
        private System.Windows.Forms.TextBox textBox_tbl1Cont1;
        private System.Windows.Forms.TextBox textBox_tbl1Cont3;
        private System.Windows.Forms.TextBox textBox_tbl1Cont2;
        private System.Windows.Forms.TextBox textBox_tbl2Cont1;
        private System.Windows.Forms.TextBox textBox_tbl3Cont1;
        private System.Windows.Forms.TextBox textBox_tbl2Cont2;
        private System.Windows.Forms.TextBox textBox_tbl3Cont2;
        private System.Windows.Forms.TextBox textBox_tbl2Cont3;
        private System.Windows.Forms.TextBox textBox_tbl3Cont3;
        private System.Windows.Forms.Button button1;
    }
}

