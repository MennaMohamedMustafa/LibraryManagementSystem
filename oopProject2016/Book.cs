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
    public class Book
    {
        public string BookName;
        public string Author;
        public string Gener;
        public string publishDate;
        public int NumberOfCopies;
        public float Price;
       public Book()
        {
            this.Author = " ";
            this.BookName = " ";
            this.Gener = " ";
            this.NumberOfCopies =0;
            this.Price = 0;
            this.publishDate = " ";
        }
       public Book (string  BookName , string Author,string Gener,string publishDate ,int NumberOfCopies,float Price)
        {
            this.Author = Author;
            this.BookName = BookName;
            this.Gener = Gener;
            this.NumberOfCopies = NumberOfCopies;
            this.Price = Price;
            this.publishDate = publishDate;
        }
     public void   Book_search (string x, DataGridView djv)
        {
            string con = "Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(con);
            SqlCommand CmdDataBase = new SqlCommand(x, conDataBase);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = CmdDataBase;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            djv.DataSource = bsource;
            sda.Update(dbdataset);
        }
    }
}
