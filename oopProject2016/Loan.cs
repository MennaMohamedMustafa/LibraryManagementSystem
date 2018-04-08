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
   public class Loan:Request
    {
       string Typee = "Borrow";
       string Due_date;
       SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
       SqlCommand cmd = new SqlCommand();
      public Loan():base()
       {
           Due_date = " ";  
       }
     public  Loan(int ID, int ISBN, string Request_Date,string Due_date) : base ( ID, ISBN, Request_Date)
       {
          this.Due_date=Due_date;
       }
       
     public  void request()
       {
           con.Open();
           cmd.CommandText = "insert into Request_Table (ID,ISBN,Start_Date,Due_Date,Type) values('" + ID + "' ,'" + ISBN + "' ,'" + Request_Date + "','" + Due_date + "','" + Typee + "')";
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           cmd.Clone();
           MessageBox.Show("Saved");
       }
   

    }
}
