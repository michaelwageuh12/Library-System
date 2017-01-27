using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection ("Data Source=MICHAEL/SQL2008;Initial Catalog=Library;Integrated Security=True"); 

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 f = new Form10();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 f = new Form9();
            f.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 f = new Form14();
            f.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f =new Form5();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 f = new Form7();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 F = new Form11();
            F.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
