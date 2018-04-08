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
    public partial class Return_Book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DIMUS;Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Return_Book()
        {
            InitializeComponent();
        }

        private void return_book_btn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(id_txt.Text);
            int ISBN = int.Parse(isbn_txt.Text);
            Librarian librarian = new Librarian();
            librarian.Return_Book(ID, ISBN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }
    }
}
