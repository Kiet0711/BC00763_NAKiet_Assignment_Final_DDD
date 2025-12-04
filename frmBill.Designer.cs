namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmBill
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
            this.cbBillID = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbCreator = new System.Windows.Forms.ComboBox();
            this.dtpCreated = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnFinancial = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Bill ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search Customer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(368, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search Date Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(368, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search Creator:";
            // 
            // cbBillID
            // 
            this.cbBillID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbBillID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBillID.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbBillID.FormattingEnabled = true;
            this.cbBillID.Location = new System.Drawing.Point(149, 73);
            this.cbBillID.Name = "cbBillID";
            this.cbBillID.Size = new System.Drawing.Size(213, 24);
            this.cbBillID.TabIndex = 6;
            this.cbBillID.SelectedIndexChanged += new System.EventHandler(this.cbBillID_SelectedIndexChanged);
            // 
            // cbCustomer
            // 
            this.cbCustomer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomer.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(168, 111);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(194, 24);
            this.cbCustomer.TabIndex = 7;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // cbCreator
            // 
            this.cbCreator.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCreator.ForeColor = System.Drawing.Color.Goldenrod;
            this.cbCreator.FormattingEnabled = true;
            this.cbCreator.Location = new System.Drawing.Point(509, 112);
            this.cbCreator.Name = "cbCreator";
            this.cbCreator.Size = new System.Drawing.Size(244, 24);
            this.cbCreator.TabIndex = 8;
            this.cbCreator.SelectedIndexChanged += new System.EventHandler(this.cbCreator_SelectedIndexChanged);
            // 
            // dtpCreated
            // 
            this.dtpCreated.Location = new System.Drawing.Point(553, 75);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(200, 22);
            this.dtpCreated.TabIndex = 9;
            this.dtpCreated.ValueChanged += new System.EventHandler(this.ctpCreated_ValueChanged);
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(12, 180);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(555, 258);
            this.dgvBill.TabIndex = 10;
            // 
            // btnFinancial
            // 
            this.btnFinancial.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancial.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnFinancial.Location = new System.Drawing.Point(573, 180);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Size = new System.Drawing.Size(180, 37);
            this.btnFinancial.TabIndex = 11;
            this.btnFinancial.Text = "See Financial Report";
            this.btnFinancial.UseVisualStyleBackColor = false;
            this.btnFinancial.Click += new System.EventHandler(this.btnFinancial_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(573, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 37);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRefesh.Location = new System.Drawing.Point(573, 257);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(180, 37);
            this.btnRefesh.TabIndex = 13;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinancial);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.cbCreator);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbBillID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBillID;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbCreator;
        private System.Windows.Forms.DateTimePicker dtpCreated;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnFinancial;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefesh;
    }
}