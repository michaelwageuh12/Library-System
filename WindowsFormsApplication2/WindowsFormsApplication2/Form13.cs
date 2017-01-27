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
    public partial class Form13 : Form
    {
        

        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BookName ;
            string CategoryName;
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True"); 
           /* SqlCommand  sqlCommend = new SqlCommand (ID ,sqlConnection);
            SqlDataReader Read ;
            Read = sqlCommend.ExecuteReader();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommend.ExecuteReader();*/
            SqlCommand sqlCommend = new SqlCommand();
            sqlConnection.Open();
            sqlCommend.Connection = sqlConnection;
            sqlCommend.CommandText = "Select  BOOK.BOOKName , Category.CategoryName  FROM BOOK,CATEGORY  WHERE BOOK.BOOKID = " + textBox1.Text + " And BOOK.CategoryID = Category.CategoryID";
            sqlCommend.ExecuteNonQuery();
            SqlDataReader read = sqlCommend.ExecuteReader();
            //DataTable table = new DataTable();
            while(read.Read()){
                textBox2.Text = read["BookName"].ToString();
                textBox3.Text = read["CategoryName"].ToString(); 
            }
            sqlConnection.Close();
           /* this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();*/


         }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }



            
        }
    }

