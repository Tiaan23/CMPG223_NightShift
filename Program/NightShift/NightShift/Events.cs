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
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace NightShift
{
    public partial class Events : Form
    {
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";
       
        private void ShowData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Event#", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgvEvent.DataSource = dt;
            }
        }
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackOffice BackOffice = new BackOffice();
            BackOffice.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == string.Empty || (cbDescription.SelectedIndex == -1))
            {
                MessageBox.Show("Please ensure all data fields have been selected or filled in");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);


                string desc = cbDescription.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("INSERT INTO Event# VALUES(@Event_Name,@Event_Description)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Event_Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Event_Description", desc);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been captured");
                ShowData();

                txtName.Text = "";
                cbDescription.SelectedIndex = -1;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("ID to Delete", "Please enter the Id you wish to delete", "1", 500, 300);


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Event# Where Event_ID =" + int.Parse(id);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            ShowData();
            con.Close();
            MessageBox.Show("Data has been deleted");
        }
    }
}
