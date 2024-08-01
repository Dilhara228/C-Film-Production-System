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
using System.Xml.Linq;

namespace QuietAtticFilm
{
    public partial class frmProduction : Form
    {
        public frmProduction()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Production(ProductionID, ProductionDate, ClientID,  LocationID, PropertyID, StaffID, PaymentID) " +
                "values('" + txtProductionID.Text + "',  '" + dateTimePicker1.Value.ToString() + "', '" + cmbClientID.Text + "' ,  " +
                "'" + txtLocationID.Text + "', '" + cmbPropertyID.Text + "', '" + cmbStaffID.Text + "', '" + txtPaymentID.Text + "', '" + txtNoofDays.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added");
            disp_data();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Production set ProductionDate='" + dateTimePicker1.Value.ToString() + "', ClientID='" +
                cmbClientID.Text + "', LocationID='" + txtLocationID.Text + "', " +
                "PropertyID='" + cmbPropertyID.Text + "', StaffID = '" + cmbStaffID.Text + "', PaymentID = '" + txtPaymentID.Text + "', NoofDays = '" + txtNoofDays.Text +
                "' where ProductionID='" + int.Parse(txtProductionID.Text) + "'";
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
            cmd.CommandText = "Delete Production where ProductionID='" + int.Parse(txtProductionID.Text) + "'";
            MessageBox.Show("Successfully Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Production where ProductionID ='" + int.Parse(txtProductionID.Text) + "'", con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Production";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        
    }
}

        
    


    



