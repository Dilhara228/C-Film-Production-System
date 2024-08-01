namespace QuietAtticFilm
{
    partial class frmProductionType
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
            this.lblProductionTypeID = new System.Windows.Forms.Label();
            this.lblProductionTypeName = new System.Windows.Forms.Label();
            this.txtProductionTypeID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbProductionTypeName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductionTypeID
            // 
            this.lblProductionTypeID.AutoSize = true;
            this.lblProductionTypeID.Font = new System.Drawing.Font("Times New Roman", 15.875F);
            this.lblProductionTypeID.Location = new System.Drawing.Point(60, 47);
            this.lblProductionTypeID.Name = "lblProductionTypeID";
            this.lblProductionTypeID.Size = new System.Drawing.Size(185, 25);
            this.lblProductionTypeID.TabIndex = 0;
            this.lblProductionTypeID.Text = "Production Type ID";
            // 
            // lblProductionTypeName
            // 
            this.lblProductionTypeName.AutoSize = true;
            this.lblProductionTypeName.Font = new System.Drawing.Font("Times New Roman", 15.875F);
            this.lblProductionTypeName.Location = new System.Drawing.Point(60, 120);
            this.lblProductionTypeName.Name = "lblProductionTypeName";
            this.lblProductionTypeName.Size = new System.Drawing.Size(215, 25);
            this.lblProductionTypeName.TabIndex = 1;
            this.lblProductionTypeName.Text = "Production Type Name";
            // 
            // txtProductionTypeID
            // 
            this.txtProductionTypeID.Font = new System.Drawing.Font("Times New Roman", 15.875F);
            this.txtProductionTypeID.Location = new System.Drawing.Point(362, 44);
            this.txtProductionTypeID.Name = "txtProductionTypeID";
            this.txtProductionTypeID.Size = new System.Drawing.Size(295, 32);
            this.txtProductionTypeID.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnAdd.Location = new System.Drawing.Point(51, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnUpdate.Location = new System.Drawing.Point(223, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 44);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnDelete.Location = new System.Drawing.Point(407, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 44);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnView.Location = new System.Drawing.Point(599, 204);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 44);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 192);
            this.dataGridView1.TabIndex = 8;
            // 
            // cmbProductionTypeName
            // 
            this.cmbProductionTypeName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductionTypeName.FormattingEnabled = true;
            this.cmbProductionTypeName.Items.AddRange(new object[] {
            "Advertisement",
            "Information Film",
            "Training Film"});
            this.cmbProductionTypeName.Location = new System.Drawing.Point(362, 119);
            this.cmbProductionTypeName.Name = "cmbProductionTypeName";
            this.cmbProductionTypeName.Size = new System.Drawing.Size(295, 29);
            this.cmbProductionTypeName.TabIndex = 9;
            // 
            // frmProductionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 492);
            this.Controls.Add(this.cmbProductionTypeName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductionTypeID);
            this.Controls.Add(this.lblProductionTypeName);
            this.Controls.Add(this.lblProductionTypeID);
            this.Name = "frmProductionType";
            this.Text = "Production Type";
            this.Load += new System.EventHandler(this.frmProductionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductionTypeID;
        private System.Windows.Forms.Label lblProductionTypeName;
        private System.Windows.Forms.TextBox txtProductionTypeID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbProductionTypeName;
    }
}