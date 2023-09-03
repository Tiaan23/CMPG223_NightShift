using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightShift
{
    public partial class Form1 : Form
    {
        private const string userid1 = "CMPG223";
        private const string password1 = "CMPG223";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;
            string user = textBox2.Text;

            if (pass == textBox1.Text && user == textBox2.Text)
            {
                HomePage HomePage = new HomePage();
                HomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password or user ID entered please try again");
            }


          
        }
    }
}
