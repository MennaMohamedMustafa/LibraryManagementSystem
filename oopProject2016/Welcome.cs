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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            Sign_up f3 = new Sign_up();
            Welcome f1 = new Welcome();
            f3.Show();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
 