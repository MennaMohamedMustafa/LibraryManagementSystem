using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopProject2016
{
    public partial class Buy_form : Form
    {
        public Buy_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buy b = new Buy(int.Parse(buy_id_txt.Text), int.Parse(isbn_buy_txt.Text), buy_date_txt.Text);
            b.request();
        }

        private void Buy_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
