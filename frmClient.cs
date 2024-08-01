using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuietAtticFilm
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if txtClientName contains any digits
                if (txtClientName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Client Name should only contain letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Client(ClientID, ClientName, Address, Email, Contact) " +
                                  "VALUES(@ClientID, @ClientName, @Address, @Email, @Contact)";
                cmd.Parameters.AddWithValue("@ClientID", txtClientID.Text);
                cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);  // Use Text instead of int.Parse for consistency and safety
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");
                disp_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }




            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Client(ClientID, ClientName, Address, Email, Contact) " +
                "values('" + txtClientID.Text + "', '" + txtClientName.Text + "'," +
                "'" + txtAddress.Text + "','" + txtEmail.Text + "','" + int.Parse(txtContact.Text) + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added");
            disp_data();*/

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Client set ClientName='" + txtClientName.Text + "', Address='" + txtAddress.Text + "', " +
                "Email='" + txtEmail.Text + "', Contact = '" + txtContact.Text + "' where ClientID='" + int.Parse(txtClientID.Text) + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            disp_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete Client where ClientID='" + int.Parse(txtClientID.Text) + "'";
            MessageBox.Show("Successfully Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Client where ClientID ='" + int.Parse(txtClientID.Text) + "'", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            disp_data();

        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    
    }
}



