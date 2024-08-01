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

namespace QuietAtticFilm
{
    public partial class frmPayment : Form
    {

        private SqlConnection con;

        public frmPayment()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");
            con.Open();

        }

        // Event handler for PayNowClicked event from frmpaymenthistory
        private void frmPaymenthistory_PayNowClicked(int PaymentID)
        {
            DisplayPaymentDetails(PaymentID);
        }

        // Method to display payment details in the form
        private void DisplayPaymentDetails(int PaymentID)
        {
            string query = "SELECT * FROM Payment WHERE PaymentID = @PaymentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PaymentID", PaymentID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Populate the payment details in the form controls
                    txtPaymentID.Text = reader["PaymentID"].ToString();
                    // Populate other controls similarly...
                }
                else
                {
                    MessageBox.Show("Payment details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            // Code to process payment...
        }

        private void txtPaymentID_TextChanged(object sender, EventArgs e)
        {
            string PaymentID = txtPaymentID.Text;
            string query = "SELECT Date, ClientID, Value FROM Payment WHERE PaymentID = @PaymentID";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@PaymentID", PaymentID);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtDate.Text = reader["Date"].ToString();
                txtClientID.Text = reader["ClientID"].ToString();
                txtValue.Text = reader["Value"].ToString();

            }
            else
            {

                txtDate.Text = "";
                txtClientID.Text = "";
                txtValue.Text = "";


            }

            reader.Close();
        }


        private string connectionString = "Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True";

       




        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DisplayAllPayments();

        }

        private void DisplayAllPayments()
        {
            // SQL query to select all payments
            string query = "SELECT PaymentID, ClientID, Date, Value FROM Payment";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }


        }

        private void btnPayNow_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Payment has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}




