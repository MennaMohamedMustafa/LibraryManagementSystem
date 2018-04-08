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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deletion d = new Deletion();
            d.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_up su = new Sign_up();
            su.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_Deletion de = new User_Deletion();
            de.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_search_display us = new user_search_display();
            us.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Book_search bs = new Book_search();
            bs.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void display_users_btn_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            string Query = "select * from Reader";
            librarian.Display(Query,show_grd);
           
        }

        private void display_books_btn_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            string Query = "select * from Book";
            librarian.Display(Query, show_grd);
        }

        private void book_return_btn_Click(object sender, EventArgs e)
        {
            Return_Book r = new Return_Book();
            r.Show();
        }

        private void show_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_requests_grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           System_ s=new System_();
           s.due_date();
    }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string con = "Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(con);
            SqlCommand CmdDataBase = new SqlCommand("select * from Request_Table", conDataBase);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = CmdDataBase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            show_grd.DataSource = bsource;
            sda.Update(dbdataset);
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Show_Request sh = new Show_Request();
            sh.Show();
            this.Close();
        }
    }
}

