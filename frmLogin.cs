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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuietAtticFilm
{
    public partial class frmLogin : Form
    {
        public static string Password;

        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-GG8FUC6\\SQLEXPRESS;Initial Catalog=Quiet_Attic_film;Integrated Security=True");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int UserID = int.Parse(txtUserID.Text);
            string Password = txtPassword.Text;

            try
            {
                con.Open();
                string query = "SELECT Administrator FROM tblLogin WHERE UserID = @UserID AND Password = @Password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@Password", Password);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string Administrator = result.ToString();
                    frmMain menuForm = new frmMain(Administrator);
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserID or Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}