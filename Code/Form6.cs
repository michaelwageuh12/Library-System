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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");
            SqlCommand sqlCommend = new SqlCommand();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            
            sqlCommend.CommandText = "DELETE FROM BORROW WHERE MEMBERID = '" + textBox1.Text + "'";
            sqlCommend.ExecuteNonQuery();

            sqlCommend.CommandText = "DELETE FROM [READ] WHERE BOOKID = '" + textBox1.Text + "'";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = "DELETE FROM MOBILENUMBERS WHERE MEMBERID = '" + textBox1.Text + "'";
            sqlCommend.ExecuteNonQuery();
            sqlCommend.CommandText = "DELETE FROM MEMBER WHERE MEMBERID = '" + textBox1.Text + "'";
            sqlCommend.ExecuteNonQuery();
          

            sqlConnection.Close();
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();

        }
    }
}
