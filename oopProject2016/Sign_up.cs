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
    public partial class Sign_up : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader ;
        public Sign_up()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            
            con.Open();
            cmd.CommandText = "insert into Reader (Name,Email,Password,Phone_number) values('"+Name_up_txt.Text+"' ,'"+Email_up_txt.Text+"' ,'"+Pass_up_txt.Text+"','"+Phone_up_txt.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
