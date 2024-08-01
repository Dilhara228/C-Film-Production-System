namespace QuietAtticFilm
{
    partial class frmStaffType
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
            this.lblStaffTypeID = new System.Windows.Forms.Label();
            this.lblCameraCrew = new System.Windows.Forms.Label();
            this.lblNoofDays = new System.Windows.Forms.Label();
            this.txtStaffTypeID = new System.Windows.Forms.TextBox();
            this.txtNoofDays = new System.Windows.Forms.TextBox();
            this.cmbCameraCrew = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRunner = new System.Windows.Forms.Label();
            this.cmbRunner = new System.Windows.Forms.ComboBox();
            this.lblActor = new System.Windows.Forms.Label();
            this.cmbActor = new System.Windows.Forms.ComboBox();
            this.cmbVoiceActor = new System.Windows.Forms.ComboBox();
            this.lblVoiceActor = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.cmbProducer = new System.Windows.Forms.ComboBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffTypeID
            // 
            this.lblStaffTypeID.AutoSize = true;
            this.lblStaffTypeID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblStaffTypeID.Location = new System.Drawing.Point(92, 39);
            this.lblStaffTypeID.Name = "lblStaffTypeID";
            this.lblStaffTypeID.Size = new System.Drawing.Size(120, 23);
            this.lblStaffTypeID.TabIndex = 0;
            this.lblStaffTypeID.Text = "Staff Type ID";
            // 
            // lblCameraCrew
            // 
            this.lblCameraCrew.AutoSize = true;
            this.lblCameraCrew.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblCameraCrew.Location = new System.Drawing.Point(242, 144);
            this.lblCameraCrew.Name = "lblCameraCrew";
            this.lblCameraCrew.Size = new System.Drawing.Size(124, 23);
            this.lblCameraCrew.TabIndex = 1;
            this.lblCameraCrew.Text = "Camera Crew";
            // 
            // lblNoofDays
            // 
            this.lblNoofDays.AutoSize = true;
            this.lblNoofDays.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblNoofDays.Location = new System.Drawing.Point(92, 398);
            this.lblNoofDays.Name = "lblNoofDays";
            this.lblNoofDays.Size = new System.Drawing.Size(105, 23);
            this.lblNoofDays.TabIndex = 2;
            this.lblNoofDays.Text = "No of Days";
            // 
            // txtStaffTypeID
            // 
            this.txtStaffTypeID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtStaffTypeID.Location = new System.Drawing.Point(463, 36);
            this.txtStaffTypeID.Name = "txtStaffTypeID";
            this.txtStaffTypeID.Size = new System.Drawing.Size(282, 32);
            this.txtStaffTypeID.TabIndex = 3;
            // 
            // txtNoofDays
            // 
            this.txtNoofDays.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtNoofDays.Location = new System.Drawing.Point(463, 398);
            this.txtNoofDays.Name = "txtNoofDays";
            this.txtNoofDays.Size = new System.Drawing.Size(282, 32);
            this.txtNoofDays.TabIndex = 4;
            // 
            // cmbCameraCrew
            // 
            this.cmbCameraCrew.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbCameraCrew.FormattingEnabled = true;
            this.cmbCameraCrew.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCameraCrew.Location = new System.Drawing.Point(463, 141);
            this.cmbCameraCrew.Name = "cmbCameraCrew";
            this.cmbCameraCrew.Size = new System.Drawing.Size(282, 31);
            this.cmbCameraCrew.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnAdd.Location = new System.Drawing.Point(81, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnUpdate.Location = new System.Drawing.Point(272, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnDelete.Location = new System.Drawing.Point(463, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnView.Location = new System.Drawing.Point(661, 470);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 37);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 139);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblRunner
            // 
            this.lblRunner.AutoSize = true;
            this.lblRunner.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblRunner.Location = new System.Drawing.Point(242, 197);
            this.lblRunner.Name = "lblRunner";
            this.lblRunner.Size = new System.Drawing.Size(71, 23);
            this.lblRunner.TabIndex = 11;
            this.lblRunner.Text = "Runner";
            // 
            // cmbRunner
            // 
            this.cmbRunner.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbRunner.FormattingEnabled = true;
            this.cmbRunner.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRunner.Location = new System.Drawing.Point(463, 194);
            this.cmbRunner.Name = "cmbRunner";
            this.cmbRunner.Size = new System.Drawing.Size(282, 31);
            this.cmbRunner.TabIndex = 12;
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblActor.Location = new System.Drawing.Point(242, 247);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(57, 23);
            this.lblActor.TabIndex = 13;
            this.lblActor.Text = "Actor";
            // 
            // cmbActor
            // 
            this.cmbActor.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbActor.FormattingEnabled = true;
            this.cmbActor.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbActor.Location = new System.Drawing.Point(463, 244);
            this.cmbActor.Name = "cmbActor";
            this.cmbActor.Size = new System.Drawing.Size(282, 31);
            this.cmbActor.TabIndex = 14;
            // 
            // cmbVoiceActor
            // 
            this.cmbVoiceActor.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbVoiceActor.FormattingEnabled = true;
            this.cmbVoiceActor.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbVoiceActor.Location = new System.Drawing.Point(463, 291);
            this.cmbVoiceActor.Name = "cmbVoiceActor";
            this.cmbVoiceActor.Size = new System.Drawing.Size(282, 31);
            this.cmbVoiceActor.TabIndex = 15;
            // 
            // lblVoiceActor
            // 
            this.lblVoiceActor.AutoSize = true;
            this.lblVoiceActor.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblVoiceActor.Location = new System.Drawing.Point(242, 294);
            this.lblVoiceActor.Name = "lblVoiceActor";
            this.lblVoiceActor.Size = new System.Drawing.Size(108, 23);
            this.lblVoiceActor.TabIndex = 16;
            this.lblVoiceActor.Text = "Voice Actor";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblProducer.Location = new System.Drawing.Point(242, 340);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(86, 23);
            this.lblProducer.TabIndex = 17;
            this.lblProducer.Text = "Producer";
            this.lblProducer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProducer
            // 
            this.cmbProducer.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cmbProducer.FormattingEnabled = true;
            this.cmbProducer.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbProducer.Location = new System.Drawing.Point(463, 337);
            this.cmbProducer.Name = "cmbProducer";
            this.cmbProducer.Size = new System.Drawing.Size(282, 31);
            this.cmbProducer.TabIndex = 18;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblTypeName.Location = new System.Drawing.Point(92, 108);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(103, 23);
            this.lblTypeName.TabIndex = 19;
            this.lblTypeName.Text = "Type Name";
            // 
            // frmStaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(870, 713);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.cmbProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblVoiceActor);
            this.Controls.Add(this.cmbVoiceActor);
            this.Controls.Add(this.cmbActor);
            this.Controls.Add(this.lblActor);
            this.Controls.Add(this.cmbRunner);
            this.Controls.Add(this.lblRunner);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCameraCrew);
            this.Controls.Add(this.txtNoofDays);
            this.Controls.Add(this.txtStaffTypeID);
            this.Controls.Add(this.lblNoofDays);
            this.Controls.Add(this.lblCameraCrew);
            this.Controls.Add(this.lblStaffTypeID);
            this.Name = "frmStaffType";
            this.Text = "Staff Type";
            this.Load += new System.EventHandler(this.frmStaffType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffTypeID;
        private System.Windows.Forms.Label lblCameraCrew;
        private System.Windows.Forms.Label lblNoofDays;
        private System.Windows.Forms.TextBox txtStaffTypeID;
        private System.Windows.Forms.TextBox txtNoofDays;
        private System.Windows.Forms.ComboBox cmbCameraCrew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRunner;
        private System.Windows.Forms.ComboBox cmbRunner;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.ComboBox cmbActor;
        private System.Windows.Forms.ComboBox cmbVoiceActor;
        private System.Windows.Forms.Label lblVoiceActor;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.ComboBox cmbProducer;
        private System.Windows.Forms.Label lblTypeName;
    }
}