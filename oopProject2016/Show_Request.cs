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
    public partial class Show_Request : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Show_Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();            
            cmd.CommandText = "insert into Loaned_books (ID, ISBN,Start_Date, Due_Date,Type) values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "' )";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlCommand com = new SqlCommand("delete  from Request_Table where ID = '" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
          /*  SqlCommand cm = new SqlCommand("select * From Book where ISBN = '"+textBox2.Text+"'",con);
            cm.ExecuteNonQuery();
            SqlDataReader read = (null);
            read = cm.ExecuteReader();
            string num = (read["NumberOfCopies"].ToString());
            int number = int.Parse(num);
            number--;
            SqlCommand update = new SqlCommand("update Book set NumberOfCopies = '" + number + "'");
            update.Connection = con;
            update.ExecuteNonQuery();*/
            cmd.Clone();
            MessageBox.Show("Accepted...");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = "Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(con);
            SqlCommand CmdDataBase = new SqlCommand("select * from Request_Table ", conDataBase);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = CmdDataBase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            dataGridView1.DataSource = bsource;
            sda.Update(dbdataset);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["ID"].Value.ToString();
                textBox2.Text = row.Cells["ISBN"].Value.ToString();
                textBox3.Text = row.Cells["Start_Date"].Value.ToString();
                textBox4.Text = row.Cells["Due_Date"].Value.ToString();
                textBox5.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("delete  from Request_Table where ID = '" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
            cmd.Clone();
            MessageBox.Show("Refused...");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
