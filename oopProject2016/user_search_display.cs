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
    public partial class user_search_display : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public user_search_display()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_display sd = new search_display();
            Context_search cs;
            cs = new Context_search(new bool_search());
            show_user_data_grd.DataSource = cs.do_search(user_search_txt.Text);
        }

        private void show_data_btn_Click(object sender, EventArgs e)
        {
            search_display sd = new search_display();
            Context_search cs;
            cs = new Context_search(new search_display());
            show_user_data_grd.DataSource = cs.do_search(user_search_txt.Text);
            ;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }

     }
}
