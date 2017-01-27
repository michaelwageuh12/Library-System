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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BookName;
            string StartDate;
            string DueDate;
            int FINE;
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");

            SqlCommand sqlCommend = new SqlCommand();
            sqlConnection.Open();
            sqlCommend.Connection = sqlConnection;
            sqlCommend.CommandText = "Select  BOOK.BOOKName , BORROW.STARTDATE ,BORROW.DUEDATE,BORROW.FINE FROM BOOK,BORROW  WHERE BORROW.BOOKID = " + textBox2.Text + " And BORROW.BOOKID = BOOK.BOOKID AND BORROW.MemberID = "+textBox1.Text+"";
         
            SqlDataReader read = sqlCommend.ExecuteReader();
            //DataTable table = new DataTable();
            while (read.Read())
            {
                textBox3.Text = read["BookName"].ToString();
                textBox4.Text = read["StartDate"].ToString();
                textBox5.Text = read["DueDate"].ToString();
                textBox6.Text = read["Fine"].ToString();
            }
            sqlConnection.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
