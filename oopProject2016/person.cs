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
    class person
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public string Name;
        public string PhoneNumber;
        public string Email;
        public string passWord;
        public int ID;
        public person()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
            passWord = "";
            ID = 0;
        }
        public person(string Name, string PhoneNumber, string Email, string passWord, int ID)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.passWord = passWord;
            this.ID = ID;
        }
        public bool sign_in(string Query1 , string Query2)
        {
            bool ok = false;
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter(Query1, con);
            DataTable db = new DataTable();
            dp.Fill(db);

            if (db.Rows.Count != 0)
            {

                SqlDataAdapter dp2 = new SqlDataAdapter(Query2, con);
                DataTable db2 = new DataTable();
                dp2.Fill(db2);

                if (db2.Rows.Count != 0)
                {
                    MessageBox.Show("Authorized");
                    ok = true;   
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
            con.Close();
            return ok;
        }
        public void delete(string Query3 , string Query4)
        {
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter(Query3 , con);
            DataTable db = new DataTable();
            dp.Fill(db);

            if (db.Rows.Count != 0)
            {
                cmd.CommandText = Query4;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Deleted");

            }
            else
            {
                MessageBox.Show("Reader Doesn't exist");
            }
            con.Close();
        }
    }
}