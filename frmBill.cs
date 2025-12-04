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
using static BC00763_KietNA_Assignment_DDD.frmLogin;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class frmBill : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;");
        public frmBill()
        {
            InitializeComponent();
            LoadComboBoxes();
            LoadAllBills();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserRole != "Admin" && Session.CurrentUserRole != "Manager")
            {
                MessageBox.Show("Just Admin and Manager can use this function!",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
                FormMainMenu formMainMenu = new FormMainMenu();
                formMainMenu.Show();
            }
        }

        private void cbCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCreator.SelectedIndex >= 0)
                SearchBill("s.StaffName = @Value", cbCreator.Text);
            else
                LoadAllBills();
        }
        private void LoadComboBoxes()
        {
            LoadComboBoxData("SELECT BillID FROM Bill", cbBillID, "BillID");
            LoadComboBoxData("SELECT CustomerName FROM Customer", cbCustomer, "CustomerName");
            LoadComboBoxData("SELECT StaffName FROM Staff", cbCreator, "StaffName");
        }
        private void LoadComboBoxData(string query, ComboBox comboBox, string columnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = columnName;
            comboBox.ValueMember = columnName;
            comboBox.SelectedIndex = -1;
        }
        private void SearchBill(string condition, string value)
        {
            string query = @"
                SELECT 
                    b.BillID,
                    b.DateCreate,
                    c.CustomerName,
                    s.StaffName,
                    p.ProductName,
                    bd.AmountProduct,
                    (p.Price * bd.AmountProduct) AS PriceOfBill,
                    b.PaymentMethod
                FROM Bill b
                JOIN Customer c ON b.CustomerID = c.CustomerID
                JOIN Staff s ON b.StaffID = s.StaffID
                JOIN BillDetail bd ON b.BillID = bd.BillID
                JOIN Product p ON bd.ProductID = p.ProductID
                WHERE " + condition;

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Value", value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBill.DataSource = dt;
            }
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedIndex >= 0)
                SearchBill("c.CustomerName = @Value", cbCustomer.Text);
            else
                LoadAllBills();
        }

        private void cbBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillID.SelectedIndex >= 0)
                SearchBill("b.BillID = @Value", cbBillID.SelectedValue.ToString());
            else
                LoadAllBills();
        }

        private void ctpCreated_ValueChanged(object sender, EventArgs e)
        {
            SearchBill("CONVERT(date, b.DateCreate) = @Value", dtpCreated.Value.Date.ToString("yyyy-MM-dd"));
        }
        private void LoadAllBills()
        {
            try
            {
                string query = @"
            SELECT 
                b.BillID,
                b.DateCreate,
                c.CustomerName,
                s.StaffName,
                p.ProductName,
                bd.AmountProduct,
                (p.Price * bd.AmountProduct) AS PriceOfBill,
                b.PaymentMethod
            FROM Bill b
            JOIN Customer c ON b.CustomerID = c.CustomerID
            JOIN Staff s ON b.StaffID = s.StaffID
            JOIN BillDetail bd ON b.BillID = bd.BillID
            JOIN Product p ON bd.ProductID = p.ProductID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBill.DataSource = dt;

               
                dgvBill.Columns["BillID"].HeaderText = "Bill ID";
                dgvBill.Columns["DateCreate"].HeaderText = "Date Created";
                dgvBill.Columns["CustomerName"].HeaderText = "Customer";
                dgvBill.Columns["StaffName"].HeaderText = "Staff";
                dgvBill.Columns["ProductName"].HeaderText = "Product";
                dgvBill.Columns["AmountProduct"].HeaderText = "Amount";
                dgvBill.Columns["PriceOfBill"].HeaderText = "Total Price";
                dgvBill.Columns["PaymentMethod"].HeaderText = "Payment";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFinancialReport formFinancial = new frmFinancialReport();
            formFinancial.Show();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadAllBills();
        }
    }
}
