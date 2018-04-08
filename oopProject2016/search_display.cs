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
    public class search_display : search
    {
         public DataTable search(string x )
        {

           SqlConnection con = new SqlConnection(" Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            if (x == "")
            {
                SqlCommand CmdDataBase = new SqlCommand("select * from Reader", con);
                CmdDataBase.CommandType = CommandType.Text;
                SqlDataReader reader = CmdDataBase.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Columns.Add("ID");
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Email");
                tbl.Columns.Add("Password");
                tbl.Columns.Add("Phone_number");
                DataRow row;
                while (reader.Read())
                {
                    row = tbl.NewRow();
                    row["ID"] = reader["ID"];
                    row["Name"] = reader["Name"];
                    row["Email"] = reader["Email"];
                    row["Password"] = reader["Password"];
                    row["Phone_number"] = reader["Phone_number"];
                    tbl.Rows.Add(row);
                }
                reader.Close();
                con.Close();
                return tbl;
            }
            else
            {
                SqlCommand CmdDataBase = new SqlCommand("select * from Reader where Name=@name ", con);
                CmdDataBase.Parameters.Add(new SqlParameter("@name", x));
                CmdDataBase.CommandType = CommandType.Text;
                SqlDataReader reader = CmdDataBase.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Columns.Add("ID");
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Email");
                tbl.Columns.Add("Password");
                tbl.Columns.Add("Phone_number");
                DataRow row;
                while (reader.Read())
                {
                    row = tbl.NewRow();
                    row["ID"] = reader["ID"];
                    row["Name"] = reader["Name"];
                    row["Email"] = reader["Email"];
                    row["Password"] = reader["Password"];
                    row["Phone_number"] = reader["Phone_number"];
                    tbl.Rows.Add(row);
                }
                reader.Close();
                con.Close();
                return tbl;
            }
        }
    }
}
