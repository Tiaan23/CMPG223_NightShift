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
    public partial class Event_Details : Form
    {
        string idEvent, idArtist;
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";
       
        private void ShowData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                //Event details table
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Event_Details", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgvEVDet.DataSource = dt;

                //events table
                SqlDataAdapter sqldaE = new SqlDataAdapter("Select Event_ID,Event_Name from Event#", sqlconn);
                DataTable dtE = new DataTable();
                sqldaE.Fill(dtE);
                dgvEvent.DataSource = dtE;

                //artist table
                SqlDataAdapter sqlda1 = new SqlDataAdapter("Select Artist_ID,Artist_FName from Artist", sqlconn);
                DataTable dtA = new DataTable();
                sqlda1.Fill(dtA);
                dgvArtist.DataSource = dtA;
            }
        }
        public Event_Details()
        {
            InitializeComponent();
        }

        private void Event_Details_Load(object sender, EventArgs e)
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
            
            if (txtCap.Text == string.Empty || dtp1.Text == string.Empty)
            {
                MessageBox.Show("Please ensure all data fields have been selected or filled in");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("INSERT INTO Event_Details VALUES(@Event_ID,@Artist_ID,@Event_Date,@TotalClients)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Event_ID", int.Parse(idEvent));
                cmd.Parameters.AddWithValue("@Artist_ID", int.Parse(idArtist));
                cmd.Parameters.AddWithValue("@Event_Date", Convert.ToDateTime(dtp1.Text));
                cmd.Parameters.AddWithValue("@TotalClients", int.Parse(txtCap.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been captured");
                ShowData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("ID to Delete", "Please enter the Id you wish to delete", "1", 500, 300);


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Event_Details Where Event_ID =" + int.Parse(id);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            ShowData();
            con.Close();
            MessageBox.Show("Data has been deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            idEvent = Interaction.InputBox("Event ID", "Please enter the Event Id you wish to add", "1", 500, 300);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idArtist = Interaction.InputBox("Artist ID", "Please enter the Artist Id you wish to add", "1", 500, 300);
        }
    }
}
