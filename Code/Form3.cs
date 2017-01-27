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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");
            SqlCommand sqlCommend = new SqlCommand();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommend.CommandText = "Insert Into MEMBER Values ('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox12.Text+"','"+textBox13.Text+"')";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = " Insert Into MOBILENUMBERS Values ('" + textBox1.Text + "', '" + textBox10.Text+"')";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = " Insert Into MOBILENUMBERS Values ('" + textBox1.Text + "', '" + textBox11.Text+"')";
            sqlCommend.ExecuteNonQuery();
            //sqlConnection.Close();
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");
            SqlCommand sqlCommend = new SqlCommand();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommend.CommandText = "Insert Into MEMBER Values ('" + textBox1.Text + "' , '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = " Insert Into MOBILENUMBERS Values ('" + textBox1.Text + "', '" + textBox10.Text + "')";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = " Insert Into MOBILENUMBERS Values ('" + textBox1.Text + "', '" + textBox11.Text + "')";
            sqlCommend.ExecuteNonQuery();
           // sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
