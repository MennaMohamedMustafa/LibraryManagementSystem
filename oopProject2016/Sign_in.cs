using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace oopProject2016
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Librarian L = new Librarian();
            L.Email = Email_txt.Text;
            L.passWord = Password_txt.Text;
            string Query1 = "select Email from Librarian where Email='" + L.Email + "'";
            string Query2 = "select Password from Librarian where Password='" + L.passWord + "'";
            if (L.sign_in(Query1, Query2))
            {
                Form6 f6 = new Form6();
                f6.Show();
                this.Hide();
            }
          /*  con.Open();
            SqlDataAdapter dp4 = new SqlDataAdapter("select Email from Librarian where Email='" + Email_txt.Text + "'", con);
            DataTable db4 = new DataTable();
            dp4.Fill(db4);

            if (db4.Rows.Count != 0)
            {

                SqlDataAdapter dp3 = new SqlDataAdapter("select Password from Librarian where Password='" + Password_txt.Text + "'", con);
                DataTable db3 = new DataTable();
                dp3.Fill(db3);

                if (db3.Rows.Count != 0)
                {
                    MessageBox.Show("Authorized");
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }

            }
            else
            {
                MessageBox.Show("Email is incorrect");
            }
            con.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reader r = new Reader();
            r.Email = Email_txt.Text;
            r.passWord = Password_txt.Text;
            string Query1 = "select Email from Reader where Email='" + r.Email + "'";
            string Query2 = "select Password from Reader where Password='" + r.passWord + "'";
           if( r.sign_in(Query1,Query2))
           {
               Form4 f4 = new Form4();
               f4.Show();
               this.Hide();
           }
        }
    }
}
