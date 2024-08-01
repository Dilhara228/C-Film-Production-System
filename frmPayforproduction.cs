using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuietAtticFilm
{
    public partial class frmPayforproduction : Form
    {
        private SqlConnection con;

        public frmPayforproduction()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");
            con.Open();
        }


        private void txtProductionID_TextChanged(object sender, EventArgs e)
        {
            string ProductionID = txtProductionID.Text;
            string query = "SELECT ProductionDate, ClientID, LocationID, PropertyID, StaffID, PaymentID, NoofDays FROM Production WHERE ProductionID = @ProductionID";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@ProductionID", ProductionID);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtProductionDate.Text = reader["ProductionDate"].ToString();
                txtClientID.Text = reader["ClientID"].ToString();
                txtLocationID.Text = reader["LocationID"].ToString();
                txtPropertyID.Text = reader["PropertyID"].ToString();
                txtStaffID.Text = reader["StaffID"].ToString();
                txtPaymentID.Text = reader["PaymentID"].ToString();
                txtNoofDays.Text = reader["NoofDays"].ToString();

            }
            else
            {
             
                txtProductionDate.Text = "";
                txtClientID.Text = "";
                txtLocationID.Text = "";
                txtPropertyID.Text = "";
                txtStaffID.Text = "";
                txtPaymentID.Text = "";
                txtNoofDays.Text = "";

            }

            reader.Close();
        }


        private void txtStaffTypeID_TextChanged(object sender, EventArgs e)
        {

            string StaffTypeID = txtStaffTypeID.Text;
            string query = "SELECT CameraCrew, Runner, Actor, VoiceActor, Producer, NoofDays  FROM StaffType WHERE StaffTypeID = @StaffTypeID";

            // Create a new SqlCommand object and wrap it in a using statement
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@StaffTypeID", StaffTypeID);

                // Open the connection if it's not already open
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Create a SqlDataReader object and wrap it in a using statement
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Populate relevant TextBoxes with the retrieved data
                        textBox6.Text = reader["CameraCrew"].ToString();
                        textBox7.Text = reader["Runner"].ToString();
                        textBox8.Text = reader["Actor"].ToString();
                        textBox9.Text = reader["VoiceActor"].ToString();
                        textBox10.Text = reader["Producer"].ToString();
                        txtNoofDays.Text = reader["NoofDays"].ToString();

                    }
                    else
                    {
                        // Clear TextBoxes if no matching record found
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                        txtNoofDays.Text = "";
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            con.Close();
        }


        private const decimal CameraCrewFeeperday= 100;
        private const decimal RunnerFeeperday = 25;
        private const decimal ActorFeeperday = 200;
        private const decimal VoiceActorFeeperday = 100;
        private const decimal ProducerFeeperday = 550;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox6.Text, out int numberOfCameraCrew) &&
                int.TryParse(textBox7.Text, out int numberOfRunner) &&
                int.TryParse(textBox8.Text, out int numberOfActor) &&
                int.TryParse(textBox9.Text, out int numberOfVoiceActor) &&
                int.TryParse(textBox10.Text, out int numberOfProducer) &&
                int.TryParse(txtNoofDays.Text, out int NoOfDays))
            {
               
                decimal totalCameraCrewCost = numberOfCameraCrew * CameraCrewFeeperday;
                decimal totalRunnerCost = numberOfRunner * RunnerFeeperday;
                decimal totalActorCost = numberOfActor * ActorFeeperday;
                decimal totalVoiceActorCost = numberOfVoiceActor * VoiceActorFeeperday;
                decimal totalProducerCost = numberOfProducer * ProducerFeeperday;


               
                textbox1.Text = totalCameraCrewCost.ToString("£0.00");
                textBox2.Text = totalRunnerCost.ToString("£0.00");
                textBox3.Text = totalActorCost.ToString("£0.00");
                textBox4.Text = totalVoiceActorCost.ToString("£0.00");
                textBox5.Text = totalProducerCost.ToString("£0.00");

                decimal totalPaymentsofStaffTypes = totalCameraCrewCost + totalRunnerCost + totalActorCost + totalVoiceActorCost + totalProducerCost;

               
                textBox11.Text = totalPaymentsofStaffTypes.ToString("£0.00");

               
                decimal TotalPaymentsPerDay = totalPaymentsofStaffTypes * NoOfDays;

               
                txtTotalPayment.Text = TotalPaymentsPerDay.ToString("£0.00");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for camera crew members, runners, and number of days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Payment(PaymentID, Date, ClientID, Value) " +
                "values('" + txtPaymentID.Text + "',  '" + dateTimePicker1.Value.ToString()+ "', '" + txtClientID.Text + "', '" + txtTotalPayment.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added Payment");
         

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Payment set Date='" + dateTimePicker1.Value.ToString() + "', ClientID='" + int.Parse(txtClientID.Text) + "', " +
                "Value = '" + txtTotalPayment.Text + "' where PaymentID='" + int.Parse(txtPaymentID.Text) + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated Payment");
 

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete Payment where PaymentID='" + int.Parse(txtPaymentID.Text) + "'";
            MessageBox.Show("Successfully Deleted Payment");
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
    }
}
          
        


    

