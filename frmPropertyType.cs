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
    public partial class frmPropertyType : Form
    {
        public frmPropertyType()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PropertyType(PropertyTypeID, Vehicle, Furniture, Building) " +
                "values('" + txtPropertyTypeID.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "')";
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
            cmd.CommandText = "Update PropertyType set Vehicle='" + comboBox1.Text + "', Furniture='" + comboBox2.Text + "', Building='" + comboBox3.Text + 
                "'where " + "PropertyTypeID='" + int.Parse(txtPropertyTypeID.Text) + "'";
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
            cmd.CommandText = "Delete PropertyType where PropertyTypeID='" + int.Parse(txtPropertyTypeID.Text) + "'";
            MessageBox.Show("Successfully Deleted");
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from PropertyType where PropertyTypeID ='" + int.Parse(txtPropertyTypeID.Text) + "'", con);
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
            cmd.CommandText = "select * from PropertyType";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void frmPropertyType_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
