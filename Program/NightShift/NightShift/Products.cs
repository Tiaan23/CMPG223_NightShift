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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
namespace NightShift
{
    public partial class Products : Form
    {
        int index;
        int id;
        int UpdateID;
     
        string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NightShift;Data Source=LUMINARYWOLF357;";

        private void ShowData()
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * From Product", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dgvProduct.DataSource = dt;

                //Event
                SqlDataAdapter sqldaE = new SqlDataAdapter("Select Event_ID,Event_Name from Event#", sqlconn);
                DataTable dtE = new DataTable();
                sqldaE.Fill(dtE);
                dgvEvent.DataSource = dtE;

                sqlconn.Close();
            }
        }
        public Products()
        {
            InitializeComponent();
            

        }

        private void Products_Load(object sender, EventArgs e)
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
            string id2 = Interaction.InputBox("Event ID", "Please enter the Id you wish to add", "1", 500, 300);
            if (txtPn.Text == string.Empty || txtPrice.Text == string.Empty || (cbDescription.SelectedIndex == -1))
            {
                MessageBox.Show("Please ensure all data fields have been selected or filled in");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                

                string desc = cbDescription.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("INSERT INTO Product VALUES(@Product_Name,@Product_Description,@Product_Price,@Event_ID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Product_Name", txtPn.Text);
                cmd.Parameters.AddWithValue("@Product_Description", desc);
                cmd.Parameters.AddWithValue("@Product_Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@Event_ID", id2);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been captured");
                ShowData();

                txtPn.Text = "";
                txtPrice.Text = "";
                cbDescription.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
        }

        private void dgvEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("ID to Delete", "Please enter the Id you wish to delete", "1", 500, 300);
            
            
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Product Where Product_ID ="+int.Parse(id);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            ShowData();
            con.Close();
            MessageBox.Show("Data has been deleted");
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateID = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value);
            txtPn.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
    
}
