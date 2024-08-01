namespace QuietAtticFilm
{
    partial class frmProduction
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
            this.lblProductionID = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.txtProductionID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.cmbPropertyID = new System.Windows.Forms.ComboBox();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbClientID = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblNoofDays = new System.Windows.Forms.Label();
            this.txtNoofDays = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductionID
            // 
            this.lblProductionID.AutoSize = true;
            this.lblProductionID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblProductionID.Location = new System.Drawing.Point(97, 40);
            this.lblProductionID.Name = "lblProductionID";
            this.lblProductionID.Size = new System.Drawing.Size(129, 23);
            this.lblProductionID.TabIndex = 0;
            this.lblProductionID.Text = "Production ID";
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblProductionDate.Location = new System.Drawing.Point(97, 89);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(147, 23);
            this.lblProductionDate.TabIndex = 1;
            this.lblProductionDate.Text = "Production Date";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblClientID.Location = new System.Drawing.Point(97, 154);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(87, 23);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Client ID";
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblLocationID.Location = new System.Drawing.Point(97, 211);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(110, 23);
            this.lblLocationID.TabIndex = 3;
            this.lblLocationID.Text = "Location ID";
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblPropertyID.Location = new System.Drawing.Point(758, 43);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(107, 23);
            this.lblPropertyID.TabIndex = 4;
            this.lblPropertyID.Text = "Property ID";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblStaffID.Location = new System.Drawing.Point(758, 95);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(76, 23);
            this.lblStaffID.TabIndex = 5;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblPaymentID.Location = new System.Drawing.Point(758, 151);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(107, 23);
            this.lblPaymentID.TabIndex = 6;
            this.lblPaymentID.Text = "Payment ID";
            // 
            // txtProductionID
            // 
            this.txtProductionID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtProductionID.Location = new System.Drawing.Point(347, 37);
            this.txtProductionID.Name = "txtProductionID";
            this.txtProductionID.Size = new System.Drawing.Size(273, 32);
            this.txtProductionID.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnAdd.Location = new System.Drawing.Point(200, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnUpdate.Location = new System.Drawing.Point(492, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 44);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnDelete.Location = new System.Drawing.Point(773, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnView.Location = new System.Drawing.Point(1070, 333);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(92, 44);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cmbPropertyID
            // 
            this.cmbPropertyID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbPropertyID.FormattingEnabled = true;
            this.cmbPropertyID.Items.AddRange(new object[] {
            "11111",
            "11112",
            "11113"});
            this.cmbPropertyID.Location = new System.Drawing.Point(965, 43);
            this.cmbPropertyID.Name = "cmbPropertyID";
            this.cmbPropertyID.Size = new System.Drawing.Size(273, 31);
            this.cmbPropertyID.TabIndex = 26;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Items.AddRange(new object[] {
            "11",
            "12",
            "13"});
            this.cmbStaffID.Location = new System.Drawing.Point(965, 92);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(273, 31);
            this.cmbStaffID.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1293, 192);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtLocationID
            // 
            this.txtLocationID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtLocationID.Location = new System.Drawing.Point(347, 208);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(273, 32);
            this.txtLocationID.TabIndex = 35;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtPaymentID.Location = new System.Drawing.Point(965, 151);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(273, 32);
            this.txtPaymentID.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 29);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 8, 0, 0, 0, 0);
            // 
            // cmbClientID
            // 
            this.cmbClientID.AutoCompleteCustomSource.AddRange(new string[] {
            "Advertisement",
            "Information Film",
            "Training Film"});
            this.cmbClientID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbClientID.FormattingEnabled = true;
            this.cmbClientID.Items.AddRange(new object[] {
            "111",
            "112",
            "113"});
            this.cmbClientID.Location = new System.Drawing.Point(347, 148);
            this.cmbClientID.Name = "cmbClientID";
            this.cmbClientID.Size = new System.Drawing.Size(273, 31);
            this.cmbClientID.TabIndex = 45;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtLocation.Location = new System.Drawing.Point(347, 266);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(273, 32);
            this.txtLocation.TabIndex = 46;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblLocation.Location = new System.Drawing.Point(97, 269);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(89, 23);
            this.lblLocation.TabIndex = 47;
            this.lblLocation.Text = "Location ";
            // 
            // lblNoofDays
            // 
            this.lblNoofDays.AutoSize = true;
            this.lblNoofDays.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblNoofDays.Location = new System.Drawing.Point(758, 208);
            this.lblNoofDays.Name = "lblNoofDays";
            this.lblNoofDays.Size = new System.Drawing.Size(105, 23);
            this.lblNoofDays.TabIndex = 48;
            this.lblNoofDays.Text = "No of Days";
            // 
            // txtNoofDays
            // 
            this.txtNoofDays.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtNoofDays.Location = new System.Drawing.Point(965, 205);
            this.txtNoofDays.Name = "txtNoofDays";
            this.txtNoofDays.Size = new System.Drawing.Size(273, 32);
            this.txtNoofDays.TabIndex = 49;
            // 
            // frmProduction
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuietAtticFilm.Properties.Resources._20229691_2731700346872668_6331379230759381991_o1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 733);
            this.Controls.Add(this.txtNoofDays);
            this.Controls.Add(this.lblNoofDays);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbClientID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.cmbPropertyID);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductionID);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lblLocationID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.lblProductionID);
            this.Name = "frmProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductionID;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.TextBox txtProductionID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbPropertyID;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbClientID;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblNoofDays;
        private System.Windows.Forms.TextBox txtNoofDays;
    }
}