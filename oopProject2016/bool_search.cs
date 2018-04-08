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
   public class bool_search : search
    {
       
        public DataTable search(string x)
       {
           SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
           con.Open();
           SqlDataAdapter dp = new SqlDataAdapter(x, con);
           DataTable db = new DataTable();
           dp.Fill(db);

           if (db.Rows.Count != 0)
           {
               MessageBox.Show("Found");
           }
           else
           {
               MessageBox.Show("Doesn't exist");
           }
           con.Close();
            DataTable tbl = new DataTable();
            return tbl;
        }
         
    }
}
