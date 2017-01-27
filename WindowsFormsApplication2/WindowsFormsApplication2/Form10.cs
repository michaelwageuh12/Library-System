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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection("Data Source=MICHAEL\\SQL2008;Initial Catalog=Library;Integrated Security=True");
            SqlCommand sqlCommend = new SqlCommand();
            sqlCommend.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommend.CommandText = "Select BOOKID, BOOKNMAE,CATEGORYNAME, FROM BOOK INNER JOIN CATEGORY ON BOOK.CATEGORYID = CATEGORY.CATEGORYID";
            sqlCommend.ExecuteNonQuery();
            sqlConnection.Close();
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet5.BOOK_CATEGORY' table. You can move, or remove it, as needed.
            this.bOOK_CATEGORYTableAdapter.Fill(this.libraryDataSet5.BOOK_CATEGORY);
            // TODO: This line of code loads data into the 'libraryDataSet3.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.libraryDataSet3.BOOK);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
