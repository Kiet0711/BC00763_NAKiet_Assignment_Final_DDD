using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class frmFinancialReport : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public frmFinancialReport()
        {
            InitializeComponent();
            chFinancial.Series["Series1"].XValueType = ChartValueType.Date;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT DateReport, Profit
            FROM vw_Revenue_Overview
            WHERE DateReport BETWEEN @from AND @to
            ORDER BY DateReport";

            DataTable dt = GetData(query, dtpFrom.Value, dtpTo.Value);
            LoadChart(dt, "DateReport", "Profit");
        }

        private void frmFinancialReport_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;
        }
        private void LoadChart(DataTable dt, string xField, string yField)
        {
            chFinancial.Series["Series1"].Points.Clear();
            chFinancial.Series["Series1"].XValueType = ChartValueType.Date;

            foreach (DataRow row in dt.Rows)
            {
                chFinancial.Series["Series1"].Points.AddXY(
                    Convert.ToDateTime(row[xField]),
                    Convert.ToDecimal(row[yField])
                );
            }
        }
        private DataTable GetData(string query, DateTime from, DateTime to)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@from", from);
                da.SelectCommand.Parameters.AddWithValue("@to", to);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        private void btnSaleRevenue_Click(object sender, EventArgs e)
        {
            string query = @"
             SELECT DateCreate, TotalIncome
             FROM vw_Revenue_Income
             WHERE DateCreate BETWEEN @from AND @to
             ORDER BY DateCreate";

            DataTable dt = GetData(query, dtpFrom.Value, dtpTo.Value);
            LoadChart(dt, "DateCreate", "TotalIncome");
        }

        private void btnExpresses_Click(object sender, EventArgs e)
        {
            string query = @"
             SELECT ImportDate, TotalExpense + TotalSalary AS TotalExpense
             FROM vw_Revenue_Expense
             WHERE ImportDate BETWEEN @from AND @to
             ORDER BY ImportDate";

            DataTable dt = GetData(query, dtpFrom.Value, dtpTo.Value);
            LoadChart(dt, "ImportDate", "TotalExpense");
        }

    }
}
