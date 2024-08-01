using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietAtticFilm
{
    public partial class frmMain : Form
    {
        private string Administrator;

        public frmMain(string Administrator)
        {
            InitializeComponent();
            this.Administrator = Administrator;
            UpdateMenuVisibility();
        }

        private void UpdateMenuVisibility()
        {
            // Hide all menu options by default
            mnuSystem.Visible = false;
            mnuProduction.Visible = false;
            mnuClient.Visible = false;
            mnuStaff.Visible = false;
            mnuStaffType.Visible = false;
            mnuPayment.Visible = false;
            mnuAdministrator.Visible = false;

            // Show menu options based on user's Administrator
            switch (Administrator)
            {
                case "Admin":
                    mnuSystem.Visible = true;
                    mnuProduction.Visible = true;
                    mnuClient.Visible = true;
                    mnuStaff.Visible = true;
                    mnuStaffType.Visible = true;
                    mnuPayment.Visible = true;
                    mnuAdministrator.Visible = true;
                    break;
                case "ProductionCreator":
                    mnuSystem.Visible = true;
                    mnuProduction.Visible = true;
                    mnuClient.Visible = true;
                    break;
                case "RevenueManager":
                    mnuSystem.Visible = true;
                    mnuProduction.Visible = true;
                    mnuPayment.Visible = true;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Show();
            _ = new frmLogin();
            _ = new frmClient();
            _ = new frmStaff();
        }
       

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.ShowDialog();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void mnuClient_Click(object sender, EventArgs e)
        {
            frmClient Client = new frmClient();
            Client.ShowDialog();
        }


        private void mnuProductionType_Click_1(object sender, EventArgs e)
        {
            frmProductionType ProductionType = new frmProductionType();
            ProductionType.ShowDialog();
        }

        private void mnuStaff_Click_1(object sender, EventArgs e)
        {
            frmStaff Staff = new frmStaff();
            Staff.ShowDialog();
        }

        private void mnuPayforproduction_Click(object sender, EventArgs e)
        {
            frmPayforproduction Payforproduction = new frmPayforproduction();
            Payforproduction.ShowDialog();
        }

        
        private void mnuProduction_Click(object sender, EventArgs e)
        {
            frmProduction Production = new frmProduction();
            Production.ShowDialog();
        }

        private void mnuProperty_Click_1(object sender, EventArgs e)
        {
            frmProperty Property = new frmProperty();
            Property.ShowDialog();
        }
        
        
        private void mnuPayforProduction_Click_1(object sender, EventArgs e)
        {
            frmPayforproduction PayforProduction = new frmPayforproduction();
            PayforProduction.ShowDialog();
        }

        private void mnuAdministrator_Click_1(object sender, EventArgs e)
        {
            frmAdministrator Administrator = new frmAdministrator();
            Administrator.ShowDialog();
        }

        private void mnuStaffType_Click_1(object sender, EventArgs e)
        {
            frmStaffType StaffType = new frmStaffType();
            StaffType.ShowDialog();
        }

        private void mnuPayment_Click(object sender, EventArgs e)
        {
            frmPayment Payment = new frmPayment();
            Payment.ShowDialog();
        }

        private void mnuPaymentHistory_Click(object sender, EventArgs e)
        {
            frmPaymentHistory PaymentHistory = new frmPaymentHistory();
            PaymentHistory.ShowDialog();
        }

        private void mnuPropertyType_Click_1(object sender, EventArgs e)
        {
            frmPropertyType PropertyType = new frmPropertyType();
            PropertyType.ShowDialog();
        }
    }
}
