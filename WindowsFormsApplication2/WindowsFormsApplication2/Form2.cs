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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True"); 
            SqlCommand  sqlCommend = new SqlCommand ();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommend.CommandText =  "Insert Into Book Values ('"+ textBox1.Text +"' , '"+textBox3.Text+"','"+textBox2.Text+"','1')";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = "Insert Into author Values ('" + textBox4.Text + "','Null')";
            sqlCommend.ExecuteNonQuery();

            sqlCommend.CommandText = " Insert Into WRITE Values ('" + textBox1.Text + "', '" + textBox4.Text + "')";
            sqlCommend.ExecuteNonQuery();
            sqlConnection.Close();
            this.Visible = false;             
           Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
            //SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");
            //SqlCommand sqlCommend = new SqlCommand();
            //sqlCommend.Connection = sqlConnection;
            //sqlConnection.Open();
            //sqlCommend.CommandText = "Insert Into Book Values ('" + textBox1.Text + "' , '" + textBox3.Text + "','" + textBox2.Text + "','1')";
            //sqlCommend.ExecuteNonQuery();
            //sqlCommend.CommandText = "Insert Into author Values ('" + textBox4.Text + "','Null')";
            //sqlCommend.ExecuteNonQuery();
            //sqlCommend.CommandText = " Insert Into WRITE Values ('" + textBox1.Text + "', '" + textBox4.Text + "')";
            //sqlCommend.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
