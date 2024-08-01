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
    public partial class frmPaymentHistory : Form
    {
        private string connectionString = "Data Source=DESKTOP-GG8FUC6\\MSSQLSERVER01;Initial Catalog=\"Quiet Attic Films Database\";Integrated Security=True";
        public delegate void PayNowEventHandler(int PaymentID);
        public event PayNowEventHandler PayNowClicked;
        public frmPaymentHistory()
        {
            InitializeComponent();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            // Get the payment ID from the selected row in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int PaymentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PaymentID"].Value);

                // Trigger the PayNowClicked event with the payment ID
                PayNowClicked?.Invoke(PaymentID);
            }
            else
            {
                MessageBox.Show("Please select a payment to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private void btnSearch_Click(object sender, EventArgs e)
        {
            int PaymentID;
            if (!int.TryParse(txtPaymentID.Text, out PaymentID))
            {
                MessageBox.Show("Please enter a valid payment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Search for the payment in the database
            SearchPayment(PaymentID);
        }

        private void SearchPayment(int PaymentID)
        {
            // SQL query to select payment information based on payment ID
            string query = "SELECT PaymentID, ClientID, Date, Value FROM Payment WHERE PaymentID = @PaymentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@PaymentID", PaymentID);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                // Check if any payment is found
                if (dt.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No payment found with the provided Payment ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            
        }
    }
}


