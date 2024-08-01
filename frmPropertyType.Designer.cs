namespace QuietAtticFilm
{
    partial class frmPropertyType
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
            this.lblPropertyTypeID = new System.Windows.Forms.Label();
            this.lblPropertyTypeName = new System.Windows.Forms.Label();
            this.txtPropertyTypeID = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblFurniture = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblExamples = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropertyTypeID
            // 
            this.lblPropertyTypeID.AutoSize = true;
            this.lblPropertyTypeID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblPropertyTypeID.Location = new System.Drawing.Point(114, 52);
            this.lblPropertyTypeID.Name = "lblPropertyTypeID";
            this.lblPropertyTypeID.Size = new System.Drawing.Size(151, 23);
            this.lblPropertyTypeID.TabIndex = 0;
            this.lblPropertyTypeID.Text = "Property Type ID";
            // 
            // lblPropertyTypeName
            // 
            this.lblPropertyTypeName.AutoSize = true;
            this.lblPropertyTypeName.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblPropertyTypeName.Location = new System.Drawing.Point(114, 124);
            this.lblPropertyTypeName.Name = "lblPropertyTypeName";
            this.lblPropertyTypeName.Size = new System.Drawing.Size(179, 23);
            this.lblPropertyTypeName.TabIndex = 1;
            this.lblPropertyTypeName.Text = "Property Type Name";
            // 
            // txtPropertyTypeID
            // 
            this.txtPropertyTypeID.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtPropertyTypeID.Location = new System.Drawing.Point(413, 49);
            this.txtPropertyTypeID.Name = "txtPropertyTypeID";
            this.txtPropertyTypeID.Size = new System.Drawing.Size(257, 32);
            this.txtPropertyTypeID.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnView.Location = new System.Drawing.Point(720, 381);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 41);
            this.btnView.TabIndex = 18;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnDelete.Location = new System.Drawing.Point(500, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnUpdate.Location = new System.Drawing.Point(267, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 41);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnAdd.Location = new System.Drawing.Point(43, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 189);
            this.dataGridView1.TabIndex = 19;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblVehicle.Location = new System.Drawing.Point(158, 183);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(72, 23);
            this.lblVehicle.TabIndex = 20;
            this.lblVehicle.Text = "Vehicle";
            // 
            // lblFurniture
            // 
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblFurniture.Location = new System.Drawing.Point(158, 231);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(89, 23);
            this.lblFurniture.TabIndex = 21;
            this.lblFurniture.Text = "Furniture";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblBuilding.Location = new System.Drawing.Point(158, 277);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(83, 23);
            this.lblBuilding.TabIndex = 22;
            this.lblBuilding.Text = "Building";
            // 
            // lblExamples
            // 
            this.lblExamples.AutoSize = true;
            this.lblExamples.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblExamples.Location = new System.Drawing.Point(496, 124);
            this.lblExamples.Name = "lblExamples";
            this.lblExamples.Size = new System.Drawing.Size(91, 23);
            this.lblExamples.TabIndex = 23;
            this.lblExamples.Text = "Examples";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Car ",
            "Tractor",
            "Boat",
            "Lorry"});
            this.comboBox1.Location = new System.Drawing.Point(409, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 29);
            this.comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Chair",
            "Table"});
            this.comboBox2.Location = new System.Drawing.Point(409, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 29);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Suburban House",
            "Inner City House"});
            this.comboBox3.Location = new System.Drawing.Point(409, 276);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(261, 29);
            this.comboBox3.TabIndex = 26;
            // 
            // frmPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 686);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblExamples);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblFurniture);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPropertyTypeID);
            this.Controls.Add(this.lblPropertyTypeName);
            this.Controls.Add(this.lblPropertyTypeID);
            this.Name = "frmPropertyType";
            this.Text = "Property Type";
            this.Load += new System.EventHandler(this.frmPropertyType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPropertyTypeID;
        private System.Windows.Forms.Label lblPropertyTypeName;
        private System.Windows.Forms.TextBox txtPropertyTypeID;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblFurniture;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblExamples;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}