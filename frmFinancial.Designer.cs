namespace BC00763_KietNA_Assignment_DDD
{
    partial class frmFinancial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chFinancial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSalesRevenue = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // chFinancial
            // 
            this.chFinancial.BackColor = System.Drawing.Color.Black;
            this.chFinancial.BorderlineColor = System.Drawing.Color.Goldenrod;
            chartArea1.Name = "ChartArea1";
            this.chFinancial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chFinancial.Legends.Add(legend1);
            this.chFinancial.Location = new System.Drawing.Point(12, 191);
            this.chFinancial.Name = "chFinancial";
            this.chFinancial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chFinancial.Series.Add(series1);
            this.chFinancial.Size = new System.Drawing.Size(557, 267);
            this.chFinancial.TabIndex = 3;
            this.chFinancial.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(332, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "To:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(72, 112);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(375, 111);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // btnSalesRevenue
            // 
            this.btnSalesRevenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalesRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesRevenue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSalesRevenue.Location = new System.Drawing.Point(600, 191);
            this.btnSalesRevenue.Name = "btnSalesRevenue";
            this.btnSalesRevenue.Size = new System.Drawing.Size(165, 33);
            this.btnSalesRevenue.TabIndex = 8;
            this.btnSalesRevenue.Text = "Sales Revenue Report";
            this.btnSalesRevenue.UseVisualStyleBackColor = false;
            this.btnSalesRevenue.Click += new System.EventHandler(this.btnSalesRevenue_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExpenses.Location = new System.Drawing.Point(600, 255);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(165, 33);
            this.btnExpenses.TabIndex = 9;
            this.btnExpenses.Text = "Expenses Report";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRevenue.Location = new System.Drawing.Point(600, 327);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(165, 33);
            this.btnRevenue.TabIndex = 10;
            this.btnRevenue.Text = "Revenue Report";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(600, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 54);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back To Bill Management";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Financial Report";
            // 
            // frmFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BC00763_KietNA_Assignment_DDD.Properties.Resources.Logo_Biker_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnSalesRevenue);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chFinancial);
            this.DoubleBuffered = true;
            this.Name = "frmFinancial";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.frmFinancial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chFinancial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chFinancial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSalesRevenue;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}