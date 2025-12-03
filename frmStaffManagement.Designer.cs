namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmStaffManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboJobRole = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Staff Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(329, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Staff Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(65, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(329, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Birth Day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(672, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(329, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone Number:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtStaffID.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtStaffID.Location = new System.Drawing.Point(149, 79);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(174, 22);
            this.txtStaffID.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtStaffName.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtStaffName.Location = new System.Drawing.Point(439, 79);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(202, 22);
            this.txtStaffName.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtPhoneNumber.Location = new System.Drawing.Point(467, 188);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 22);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtSearch.Location = new System.Drawing.Point(748, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSex.ForeColor = System.Drawing.Color.Goldenrod;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Location = new System.Drawing.Point(116, 134);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(207, 24);
            this.cboSex.TabIndex = 14;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(429, 135);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(212, 22);
            this.dateOfBirth.TabIndex = 15;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(69, 235);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(572, 250);
            this.dgvStaff.TabIndex = 16;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(667, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 45);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.Location = new System.Drawing.Point(667, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 33);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add New Staff";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Location = new System.Drawing.Point(667, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 44);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Staff Information";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAccount.Location = new System.Drawing.Point(667, 336);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(136, 58);
            this.btnAccount.TabIndex = 20;
            this.btnAccount.Text = "Create or Update Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(65, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Job Role: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cboJobRole
            // 
            this.cboJobRole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboJobRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboJobRole.ForeColor = System.Drawing.Color.Goldenrod;
            this.cboJobRole.FormattingEnabled = true;
            this.cboJobRole.Location = new System.Drawing.Point(163, 189);
            this.cboJobRole.Name = "cboJobRole";
            this.cboJobRole.Size = new System.Drawing.Size(160, 24);
            this.cboJobRole.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.Location = new System.Drawing.Point(667, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 46);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete Staff";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboJobRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmStaffManagement";
            this.Text = "frmStaffManagement";
            this.Load += new System.EventHandler(this.frmStaffManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboJobRole;
        private System.Windows.Forms.Button btnDelete;
    }
}