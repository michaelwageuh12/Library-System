﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet3.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter1.Fill(this.libraryDataSet3.MEMBER);
            // TODO: This line of code loads data into the 'libraryDataSet1.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.libraryDataSet1.MEMBER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
