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
using Microsoft.VisualBasic;

namespace NightShift
{
    public partial class Clients : Form
    {
        string id2;
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";
       
        private void ShowData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Client", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgvClient.DataSource = dt;

                SqlDataAdapter sqlda2 = new SqlDataAdapter("Select Event_ID, Event_Name from Event#", sqlconn);
                DataTable dt2 = new DataTable();
                sqlda2.Fill(dt2);
                dgvEvent.DataSource = dt2;
            }
        }
        
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            ShowData();
        }



    



        private void button1_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtSur.Text == string.Empty || (cbAccess.SelectedIndex == -1))
            {
                MessageBox.Show("Please ensure all data fields have been selected or filled in");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);


                string desc = cbAccess.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("INSERT INTO Client VALUES(@Client_Name,@ClientSurname,@Client_Access,@Event_ID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Client_Name", txtName.Text);
                cmd.Parameters.AddWithValue("@ClientSurname", txtSur.Text);
                cmd.Parameters.AddWithValue("@Client_Access", desc);
                cmd.Parameters.AddWithValue("@Event_ID", id2);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been captured");
                ShowData();

                txtName.Text = "";
                txtSur.Text = "";
                cbAccess.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id2 = Interaction.InputBox("Event ID", "Please enter the Id you wish to add", "1", 500, 300);
           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("ID to Delete", "Please enter the Id you wish to delete", "1", 500, 300);


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Client Where Client_ID =" + int.Parse(id);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            ShowData();
            con.Close();
            MessageBox.Show("Data has been deleted");
        }
    }
}
