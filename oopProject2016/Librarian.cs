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
    class Librarian : person
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Librarian()
            : base()
        {

        }
        public Librarian(string Name, string PhoneNumber, string Email, string passWord, int ID)
            : base(Name, PhoneNumber, Email, passWord, ID)
        {

        }
        public void Add_Book(Book book)
        {
            con.Open();
            cmd.CommandText = "insert into Book(Author,BookName,Gener,NumberOfCopies,Price,PublishDate) values('" + book.Author + "' ,'" + book.BookName + "' ,' " + book.Gener + " ','" + book.NumberOfCopies + "',' " + book.Price + " ','" + book.publishDate + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Clone();
            MessageBox.Show("Added");
            con.Close();
        }
        public void Display(string Query, DataGridView djv)
        {
            string con = "Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(con);
            SqlCommand CmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = CmdDataBase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            djv.DataSource = bsource;
            sda.Update(dbdataset);
        }
        public void Return_Book(int ID, int ISBN)
        {
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter("select * from loaned_books where ID='" + ID + "' and ISBN='" + ISBN + "'", con);
            DataTable db = new DataTable();
            dp.Fill(db);
            if (db.Rows.Count != 0)
            {
                string Query;
                Query = "delete from loaned_books where ID='" + ID + "' and ISBN='" + ISBN + "'";
                cmd.CommandText = Query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Done .. ");
            }

        }
    }
}
