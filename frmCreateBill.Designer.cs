namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmCreateBill
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbBillID = new System.Windows.Forms.Label();
            this.dateCreationBill = new System.Windows.Forms.DateTimePicker();
            this.cbBillCreator = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.listProduct = new System.Windows.Forms.ListView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTypeOfCustomer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(54, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Creation Bill:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(54, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bill Creator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(54, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(296, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(54, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(378, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone Number:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBillID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillID.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbBillID.Location = new System.Drawing.Point(136, 82);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(15, 22);
            this.lbBillID.TabIndex = 8;
            this.lbBillID.Text = ".";
            // 
            // dateCreationBill
            // 
            this.dateCreationBill.CalendarForeColor = System.Drawing.Color.Goldenrod;
            this.dateCreationBill.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.dateCreationBill.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.dateCreationBill.CalendarTitleForeColor = System.Drawing.Color.Goldenrod;
            this.dateCreationBill.CalendarTrailingForeColor = System.Drawing.Color.Goldenrod;
            this.dateCreationBill.Location = new System.Drawing.Point(230, 128);
            this.dateCreationBill.Name = "dateCreationBill";
            this.dateCreationBill.Size = new System.Drawing.Size(200, 22);
            this.dateCreationBill.TabIndex = 9;
            // 
            // cbBillCreator
            // 
            this.cbBillCreator.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbBillCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBillCreator.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbBillCreator.FormattingEnabled = true;
            this.cbBillCreator.Location = new System.Drawing.Point(177, 179);
            this.cbBillCreator.Name = "cbBillCreator";
            this.cbBillCreator.Size = new System.Drawing.Size(219, 24);
            this.cbBillCreator.TabIndex = 10;
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtProduct.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtProduct.Location = new System.Drawing.Point(144, 231);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(146, 22);
            this.txtProduct.TabIndex = 11;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAmount.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtAmount.Location = new System.Drawing.Point(385, 231);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(146, 22);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // listProduct
            // 
            this.listProduct.FullRowSelect = true;
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(58, 275);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(481, 111);
            this.listProduct.TabIndex = 13;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.SelectedIndexChanged += new System.EventHandler(this.listProduct_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddProduct.Location = new System.Drawing.Point(585, 275);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(122, 30);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(679, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Type Of Customer:";
            // 
            // lbTypeOfCustomer
            // 
            this.lbTypeOfCustomer.AutoSize = true;
            this.lbTypeOfCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTypeOfCustomer.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTypeOfCustomer.Location = new System.Drawing.Point(860, 410);
            this.lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            this.lbTypeOfCustomer.Size = new System.Drawing.Size(10, 16);
            this.lbTypeOfCustomer.TabIndex = 16;
            this.lbTypeOfCustomer.Text = ".";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.Location = new System.Drawing.Point(58, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete bill and Exit";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSaveBill.Location = new System.Drawing.Point(585, 484);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(96, 29);
            this.btnSaveBill.TabIndex = 18;
            this.btnSaveBill.Text = "Save Bill";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtCustomerName.Location = new System.Drawing.Point(218, 404);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(146, 22);
            this.txtCustomerName.TabIndex = 19;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtPhoneNumber.Location = new System.Drawing.Point(525, 404);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 22);
            this.txtPhoneNumber.TabIndex = 20;
            this.txtPhoneNumber.AcceptsTabChanged += new System.EventHandler(this.txtPhoneNumber_AcceptsTabChanged);
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.MouseEnter += new System.EventHandler(this.txtPhoneNumber_MouseEnter);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteProduct.Location = new System.Drawing.Point(585, 356);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(122, 30);
            this.btnDeleteProduct.TabIndex = 21;
            this.btnDeleteProduct.Text = "Delete ";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "New Bill";
            // 
            // frmCreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbTypeOfCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.cbBillCreator);
            this.Controls.Add(this.dateCreationBill);
            this.Controls.Add(this.lbBillID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frmCreateBill";
            this.Text = "Create Bill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbBillID;
        private System.Windows.Forms.DateTimePicker dateCreationBill;
        private System.Windows.Forms.ComboBox cbBillCreator;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTypeOfCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label label1;
    }
}