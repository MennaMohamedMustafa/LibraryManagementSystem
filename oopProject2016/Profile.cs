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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book_search bs = new Book_search();
            bs.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_search us = new User_search();
            us.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrow_form b = new Borrow_form();
            b.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buy_form B = new Buy_form();
            B.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
