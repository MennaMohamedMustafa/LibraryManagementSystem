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
using System.Data.Sql;


namespace oopProject2016
{
    public partial class Book_search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public Book_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool_search bs = new bool_search();
            string x ="select BookName from Book where BookName='" + textBox1.Text + "'";
            bs.search(x);
        }

        private void show_data_btn_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            string x = "select * from Book where BookName='"+textBox1.Text+"'";
            b.Book_search(x,show_data_book_grd);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book_search_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Close();
        }
    }
}
