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
    public partial class User_search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public User_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x= "select Name from Reader where Name='" + textBox1.Text + "'";
            search_display sd = new search_display();
            Context_search cs;
            cs = new Context_search(new bool_search());
            cs.do_search(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
