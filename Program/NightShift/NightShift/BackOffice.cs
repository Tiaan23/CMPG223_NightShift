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
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        private void BackOffice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products Products = new Products();
            Products.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Events Events = new Events();
            Events.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Artists Artists = new Artists();
            Artists.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Event_Details Event_Details = new Event_Details();
            Event_Details.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports Reports = new Reports();
            Reports.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }
    }
}
