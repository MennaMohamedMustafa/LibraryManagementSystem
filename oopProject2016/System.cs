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
    class System_
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void due_date()
        {
            /*string str = DateTime.Now.ToString();
            string[] time = str.Split(' ');
            string date = time[0];
            MessageBox.Show(date);*/
           
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select * from loaned_books where Due_Date > 20 ", con);
            DataTable db = new DataTable();
            dp.Fill(db);

            if (db.Rows.Count != 0)
            {
                for (int i = 0; i < db.Rows.Count ; i++ )
                {
                   /* if (DateTime.Parse(date) >= DateTime.Parse(db.Rows[i][3].ToString()))
                    {*/
                    cmd.CommandText = "insert into Blocked_user(ID,ISBN,Start_Date,Due_Date) values(' " + db.Rows[i][0] + " ' ,' " + db.Rows[i][1] + " ' ,' " + db.Rows[i][2] + " ',' " + db.Rows[i][3] + " ')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    SqlCommand com = new SqlCommand("delete  from loaned_books where ID = '" + db.Rows[i][0] + "'", con);
                    com.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Removed some readers to Blocked table...");
                  }
                //}
            }
            else
            {
                MessageBox.Show("there is no books late");
            }
            con.Close();
        }
    }
    
}
