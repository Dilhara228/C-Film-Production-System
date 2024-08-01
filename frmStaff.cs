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
    public partial class frmStaff : Form
    {


        public frmStaff()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");


        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Staff(StaffID, Name, Address, Email, Contact, StaffTypeID) " +
                "values('" + txtStaffID.Text + "', '" + txtName.Text + "'," +
                "'" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "','" + txtStaffTypeID.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added");
            disp_data();
        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Staff set Name='" + txtName.Text + "', Address='" + txtAddress.Text + "', " +
                "Email='" + txtEmail.Text + "', Contact = '" + txtContact.Text + "' where StaffID='" + int.Parse(txtStaffID.Text) + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            disp_data();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete Staff where StaffID='" + int.Parse(txtStaffID.Text) + "'";
            MessageBox.Show("Successfully Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Staff where StaffID ='" + int.Parse(txtStaffID.Text) + "'", con);
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
            cmd.CommandText = "select * from Staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}











   



