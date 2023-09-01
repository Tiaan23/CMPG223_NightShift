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
    public partial class Event_Details : Form
    {
        public Event_Details()
        {
            InitializeComponent();
        }

        private void Event_Details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackOffice BackOffice = new BackOffice();
            BackOffice.Show();
            this.Hide();
        }
    }
}
