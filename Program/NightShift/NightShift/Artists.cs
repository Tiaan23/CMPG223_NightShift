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
    public partial class Artists : Form
    {
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";
        
        private void ShowData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Artist", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgvArtist.DataSource = dt;
            }
        }
        public Artists()
        {
            InitializeComponent();
        }

        private void Artists_Load(object sender, EventArgs e)
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
            if (txtName.Text == string.Empty || txtSurname.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please ensure all data fields have been selected or filled in");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);


               

                SqlCommand cmd = new SqlCommand("INSERT INTO Artist VALUES(@Artist_Name,@Artist_Surname,@Artist_Email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Artist_Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Artist_Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Artist_Email", txtEmail.Text);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been captured");
                ShowData();

                txtName.Text = "";
                txtEmail.Text = "";
                txtSurname.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string id = Interaction.InputBox("ID to Delete", "Please enter the Id you wish to delete", "1", 500, 300);


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Artist Where Artist_ID =" + int.Parse(id);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            ShowData();
            con.Close();
            MessageBox.Show("Data has been deleted");
        }
    }
}
