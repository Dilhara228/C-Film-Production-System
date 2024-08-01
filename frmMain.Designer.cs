namespace QuietAtticFilm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductionType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaffType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPropertyType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayforProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaymentHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministrator = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuProduction,
            this.mnuProductionType,
            this.mnuClient,
            this.mnuStaff,
            this.mnuStaffType,
            this.mnuProperty,
            this.mnuPropertyType,
            this.mnuPayforProduction,
            this.mnuPayment,
            this.mnuPaymentHistory,
            this.mnuAdministrator});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuPaymentHistory";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(57, 20);
            this.mnuSystem.Text = "System";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Enabled = false;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(112, 22);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(112, 22);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuProduction
            // 
            this.mnuProduction.Name = "mnuProduction";
            this.mnuProduction.Size = new System.Drawing.Size(78, 20);
            this.mnuProduction.Text = "Production";
            this.mnuProduction.Click += new System.EventHandler(this.mnuProduction_Click);
            // 
            // mnuProductionType
            // 
            this.mnuProductionType.Name = "mnuProductionType";
            this.mnuProductionType.Size = new System.Drawing.Size(105, 20);
            this.mnuProductionType.Text = "Production Type";
            this.mnuProductionType.Click += new System.EventHandler(this.mnuProductionType_Click_1);
            // 
            // mnuClient
            // 
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(50, 20);
            this.mnuClient.Text = "Client";
            this.mnuClient.Click += new System.EventHandler(this.mnuClient_Click);
            // 
            // mnuStaff
            // 
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.Size = new System.Drawing.Size(43, 20);
            this.mnuStaff.Text = "Staff";
            this.mnuStaff.Click += new System.EventHandler(this.mnuStaff_Click_1);
            // 
            // mnuStaffType
            // 
            this.mnuStaffType.Name = "mnuStaffType";
            this.mnuStaffType.Size = new System.Drawing.Size(70, 20);
            this.mnuStaffType.Text = "Staff Type";
            this.mnuStaffType.Click += new System.EventHandler(this.mnuStaffType_Click_1);
            // 
            // mnuProperty
            // 
            this.mnuProperty.Name = "mnuProperty";
            this.mnuProperty.Size = new System.Drawing.Size(64, 20);
            this.mnuProperty.Text = "Property";
            this.mnuProperty.Click += new System.EventHandler(this.mnuProperty_Click_1);
            // 
            // mnuPropertyType
            // 
            this.mnuPropertyType.Name = "mnuPropertyType";
            this.mnuPropertyType.Size = new System.Drawing.Size(91, 20);
            this.mnuPropertyType.Text = "Property Type";
            this.mnuPropertyType.Click += new System.EventHandler(this.mnuPropertyType_Click_1);
            // 
            // mnuPayforProduction
            // 
            this.mnuPayforProduction.Name = "mnuPayforProduction";
            this.mnuPayforProduction.Size = new System.Drawing.Size(118, 20);
            this.mnuPayforProduction.Text = "Pay for production";
            this.mnuPayforProduction.Click += new System.EventHandler(this.mnuPayforProduction_Click_1);
            // 
            // mnuPayment
            // 
            this.mnuPayment.Name = "mnuPayment";
            this.mnuPayment.Size = new System.Drawing.Size(66, 20);
            this.mnuPayment.Text = "Payment";
            this.mnuPayment.Click += new System.EventHandler(this.mnuPayment_Click);
            // 
            // mnuPaymentHistory
            // 
            this.mnuPaymentHistory.Name = "mnuPaymentHistory";
            this.mnuPaymentHistory.Size = new System.Drawing.Size(107, 20);
            this.mnuPaymentHistory.Text = "Payment History";
            this.mnuPaymentHistory.Click += new System.EventHandler(this.mnuPaymentHistory_Click);
            // 
            // mnuAdministrator
            // 
            this.mnuAdministrator.Name = "mnuAdministrator";
            this.mnuAdministrator.Size = new System.Drawing.Size(92, 20);
            this.mnuAdministrator.Text = "Administrator";
            this.mnuAdministrator.Click += new System.EventHandler(this.mnuAdministrator_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::QuietAtticFilm.Properties.Resources.larana_inc_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(411, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 311);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1213, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuProduction;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem mnuStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuStaffType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuPropertyType;
        private System.Windows.Forms.ToolStripMenuItem mnuPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuPayforProduction;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrator;
        private System.Windows.Forms.ToolStripMenuItem mnuProductionType;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentHistory;
    }
}

