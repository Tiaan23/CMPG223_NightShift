using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightShift
{
    public partial class Reports : Form
    {
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackOffice BackOffice = new BackOffice();
            BackOffice.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Event_Details where Event_Date > GetDate()", con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dgvReport.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id2 = Interaction.InputBox("Event ID", "Please enter the Id you wish to add", "1", 500, 300);
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "Select * From Client where Event_ID =" + int.Parse(id2)+"Order By Client_Fname";
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dgvReport.DataSource = dt;

        }
    }
}
