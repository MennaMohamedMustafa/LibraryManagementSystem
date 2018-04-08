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
    public class Buy : Request
    {
        string Typee = "buy";
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        Buy()
            : base()
        {

        }
       public Buy(int ID, int ISBN, string Request_Date)
            : base(ID, ISBN, Request_Date)
        {
        }

      public  void request()
        {
            con.Open();
            cmd.CommandText = "insert into Request_Table (ID,ISBN,Start_Date,Type) values('" + ID + "' ,'" + ISBN + "' ,'" + Request_Date + "','" + Typee + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Clone();
            MessageBox.Show("Saved");
        }

    }
}
