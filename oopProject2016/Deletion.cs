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
    public partial class Deletion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public Deletion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person p = new person();
            p.Name = textBox1.Text;
            string Query3 = "select BookName from Book where BookName='" + p.Name + "'";
            /*con.Open();
            SqlDataAdapter dp=new SqlDataAdapter("select BookName from Book where BookName='"+textBox1.Text+"'",con);
            DataTable db=new DataTable();
            dp.Fill(db);

            if(db.Rows.Count!=0)
            {
                string Query ;
                Query = "delete from Book where BookName='"+textBox1.Text+"'";
                cmd.CommandText = Query;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Deleted");
               
            }
           else
            {
                MessageBox.Show("Book Doesn't exist");
            }
             con.Close();*/
        }

        private void Deletion_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
