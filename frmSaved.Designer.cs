namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmSaved
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
            this.lbBillID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lbTotalPaid = new System.Windows.Forms.Label();
            this.listTotalProduct = new System.Windows.Forms.ListView();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCreator = new System.Windows.Forms.Label();
            this.lbDateCreation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBillID.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbBillID.Location = new System.Drawing.Point(279, -30);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(44, 16);
            this.lbBillID.TabIndex = 37;
            this.lbBillID.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(202, -35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Bill ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(74, -57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bill Saved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(279, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "label9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(202, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Bill ID:";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnPrintBill.Location = new System.Drawing.Point(558, 549);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(130, 29);
            this.btnPrintBill.TabIndex = 54;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(206, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 29);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Delete and Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboPaymentMethod.ForeColor = System.Drawing.Color.Goldenrod;
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(370, 497);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(173, 24);
            this.cboPaymentMethod.TabIndex = 52;
            // 
            // lbTotalPaid
            // 
            this.lbTotalPaid.AutoSize = true;
            this.lbTotalPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalPaid.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTotalPaid.Location = new System.Drawing.Point(602, 463);
            this.lbTotalPaid.Name = "lbTotalPaid";
            this.lbTotalPaid.Size = new System.Drawing.Size(44, 16);
            this.lbTotalPaid.TabIndex = 51;
            this.lbTotalPaid.Text = "label9";
            // 
            // listTotalProduct
            // 
            this.listTotalProduct.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listTotalProduct.HideSelection = false;
            this.listTotalProduct.Location = new System.Drawing.Point(206, 246);
            this.listTotalProduct.Name = "listTotalProduct";
            this.listTotalProduct.Size = new System.Drawing.Size(497, 195);
            this.listTotalProduct.TabIndex = 50;
            this.listTotalProduct.UseCompatibleStateImageBehavior = false;
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCustomerType.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbCustomerType.Location = new System.Drawing.Point(683, 174);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(44, 16);
            this.lbCustomerType.TabIndex = 49;
            this.lbCustomerType.Text = "label9";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCustomerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbCustomerName.Location = new System.Drawing.Point(361, 174);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(44, 16);
            this.lbCustomerName.TabIndex = 48;
            this.lbCustomerName.Text = "label9";
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCreator.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbCreator.Location = new System.Drawing.Point(292, 127);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(44, 16);
            this.lbCreator.TabIndex = 47;
            this.lbCreator.Text = "label9";
            // 
            // lbDateCreation
            // 
            this.lbDateCreation.AutoSize = true;
            this.lbDateCreation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDateCreation.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbDateCreation.Location = new System.Drawing.Point(379, 78);
            this.lbDateCreation.Name = "lbDateCreation";
            this.lbDateCreation.Size = new System.Drawing.Size(44, 16);
            this.lbDateCreation.TabIndex = 46;
            this.lbDateCreation.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(494, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Total Paid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(202, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Payment Method:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(202, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Products Bought:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(503, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Type Of Customer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(202, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Customer Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(202, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Creator:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(202, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Date Creation Bill:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(74, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Bill Saved";
            // 
            // frmSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboPaymentMethod);
            this.Controls.Add(this.lbTotalPaid);
            this.Controls.Add(this.listTotalProduct);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCreator);
            this.Controls.Add(this.lbDateCreation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbBillID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmSaved";
            this.Text = "Bill Saved";
            this.Load += new System.EventHandler(this.frmSaved_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBillID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lbTotalPaid;
        private System.Windows.Forms.ListView listTotalProduct;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label lbDateCreation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}