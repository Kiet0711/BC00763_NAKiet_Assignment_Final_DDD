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

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class frmCustomer : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
        LoadCustomerData();
        LoadTypeOfCustomer();
        }
        private void LoadCustomerData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    c.CustomerID, 
                    c.CustomerName, 
                    t.TypeName, 
                    c.NumberOfPrchases,
                    ISNULL(v.TotalSpent, 0) AS TotalPurchase
                    FROM Customer c
                    JOIN TypeOfCustomer t ON c.TypeID = t.TypeID
                    LEFT JOIN v_TotalCustomerSpending v 
                    ON c.CustomerID = v.CustomerID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCustomer.DataSource = dt;
                dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
        
        }
        private void LoadTypeOfCustomer()
        {
            string query = "SELECT TypeID, TypeName FROM TypeOfCustomer";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbType.DataSource = dt;
                cbType.DisplayMember = "TypeName"; 
                cbType.ValueMember = "TypeID";     
                cbType.SelectedIndex = -1;         
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                cbType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNumberPurchase.Text))
            {
                MessageBox.Show("Please fill in all required information!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Customer (CustomerID, CustomerName, TypeID, NumberOfPrchases)
                                 VALUES (@CustomerID, @CustomerName, @TypeID, @NumberOfPurchases)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@TypeID", (int)cbType.SelectedValue);
                cmd.Parameters.AddWithValue("@NumberOfPurchases", int.Parse(txtNumberPurchase.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New customer added successfully!");
                LoadCustomerData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Customer ID is required for updating!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Customer 
                                 SET CustomerName = @CustomerName, 
                                     TypeID = @TypeID,
                                     NumberOfPrchases = @NumberOfPurchases
                                 WHERE CustomerID = @CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@TypeID", (int)cbType.SelectedValue);
                cmd.Parameters.AddWithValue("@NumberOfPurchases", int.Parse(txtNumberPurchase.Text));

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                    MessageBox.Show("Customer information updated successfully!");
                else
                    MessageBox.Show("Customer not found!");

                LoadCustomerData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete!");
                return;
            }

            int customerID = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer deleted successfully!");
                    LoadCustomerData();
                }
            }
        }
    }
}
