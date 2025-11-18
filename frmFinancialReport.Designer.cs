namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmFinancialReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chFinancial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaleRevenue = new System.Windows.Forms.Button();
            this.btnExpresses = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(651, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Financial Report";
            // 
            // chFinancial
            // 
            this.chFinancial.BackColor = System.Drawing.Color.DimGray;
            this.chFinancial.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea3.Name = "ChartArea1";
            this.chFinancial.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chFinancial.Legends.Add(legend3);
            this.chFinancial.Location = new System.Drawing.Point(12, 138);
            this.chFinancial.Name = "chFinancial";
            this.chFinancial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chFinancial.Series.Add(series3);
            this.chFinancial.Size = new System.Drawing.Size(604, 280);
            this.chFinancial.TabIndex = 3;
            this.chFinancial.Text = "chart1";
            // 
            // btnSaleRevenue
            // 
            this.btnSaleRevenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaleRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleRevenue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSaleRevenue.Location = new System.Drawing.Point(636, 138);
            this.btnSaleRevenue.Name = "btnSaleRevenue";
            this.btnSaleRevenue.Size = new System.Drawing.Size(151, 45);
            this.btnSaleRevenue.TabIndex = 4;
            this.btnSaleRevenue.Text = "Sale Revenue Report";
            this.btnSaleRevenue.UseVisualStyleBackColor = false;
            this.btnSaleRevenue.Click += new System.EventHandler(this.btnSaleRevenue_Click);
            // 
            // btnExpresses
            // 
            this.btnExpresses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpresses.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExpresses.Location = new System.Drawing.Point(636, 226);
            this.btnExpresses.Name = "btnExpresses";
            this.btnExpresses.Size = new System.Drawing.Size(151, 31);
            this.btnExpresses.TabIndex = 5;
            this.btnExpresses.Text = "Expreses Report";
            this.btnExpresses.UseVisualStyleBackColor = false;
            this.btnExpresses.Click += new System.EventHandler(this.btnExpresses_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRevenue.Location = new System.Drawing.Point(637, 310);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(151, 31);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Revenue Report";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(636, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back To Bill Management";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(79, 62);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 8;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(353, 62);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(309, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "To:";
            // 
            // frmFinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnExpresses);
            this.Controls.Add(this.btnSaleRevenue);
            this.Controls.Add(this.chFinancial);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmFinancialReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFinancialReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chFinancial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFinancial;
        private System.Windows.Forms.Button btnSaleRevenue;
        private System.Windows.Forms.Button btnExpresses;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}