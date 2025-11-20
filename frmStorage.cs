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
    public partial class frmStorage : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";

        public frmStorage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu frmMainMenu = new FormMainMenu();
            frmMainMenu.Show();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStorage_Load(object sender, EventArgs e)
        {
            LoadProductData();
            LoadCategoryList();
        }
        private void LoadProductData()
        {
            string query = @"
             SELECT 
             p.ProductID,
             p.ProductName,
             p.InventoryQuantity As Amount,
             p.Price,
             c.Category,
             i.Brand,
             i.BatchNumber
             FROM Product p
             INNER JOIN Category c ON p.CategoryID = c.CategoryID
             LEFT JOIN ProductImport i ON p.BatchNumber = i.BatchNumber;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProduct.DataSource = dt;


                dgvProduct.Columns["ProductID"].HeaderText = "Product ID";
                dgvProduct.Columns["ProductName"].HeaderText = "Product Name";
                dgvProduct.Columns["Amount"].HeaderText = "Amount";
                dgvProduct.Columns["Price"].HeaderText = "Price";
                dgvProduct.Columns["Category"].HeaderText = "Category";
                dgvProduct.Columns["Brand"].HeaderText = "Brand";
                dgvProduct.Columns["BatchNumber"].HeaderText = "Batch Number";


                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProduct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                HighlightLowStock();
            }
        }
        private void HighlightLowStock()
        {

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["Amount"].Value != DBNull.Value)
                {
                    int amount = Convert.ToInt32(row.Cells["Amount"].Value);
                    if (amount < 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdd frmAdd = new frmAdd();
            frmAdd.Show();
            LoadProductData();
        }
        public void RefreshData()
        {
            LoadProductData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string productId = dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Product ID: {productId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Product WHERE ProductID = @ProductID";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProductData();
                            }
                            else
                            {
                                MessageBox.Show("No product found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    SqlCommand cmd;

                    int productID;
                    if (int.TryParse(searchText, out productID))
                    {
                        query = @"SELECT 
                              p.ProductID,
                              p.ProductName,
                              p.Price,
                              p.InventoryQuantity,
                              c.Category,
                              p.BatchNumber
                          FROM Product p
                          INNER JOIN Category c ON p.CategoryID = c.CategoryID
                          WHERE p.ProductID = @ProductID 
                             OR p.ProductName LIKE @SearchText";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }
                    else
                    {
                        query = @"SELECT 
                              p.ProductID,
                              p.ProductName,
                              p.Price,
                              p.InventoryQuantity,
                              c.Category,
                              p.BatchNumber
                          FROM Product p
                          INNER JOIN Category c ON p.CategoryID = c.CategoryID
                          WHERE p.ProductName LIKE @SearchText";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProduct.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when searching: " + ex.Message);
            }
        }

        private void btnImportGoods_Click(object sender, EventArgs e)
        {
            frmImport frmImport = new frmImport();
            frmImport.ShowDialog();
            LoadProductData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadCategoryList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, Category FROM Category";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

               
                DataRow allRow = dt.NewRow();
                allRow["CategoryID"] = 0;
                allRow["Category"] = "All Categories";
                dt.Rows.InsertAt(allRow, 0);

              
                cbCategory.DataSource = dt;
                cbCategory.DisplayMember = "Category";    
                cbCategory.ValueMember = "CategoryID";     
            }
        }
        private void LoadProductByCategory(int categoryId)
        {
            string query;

            if (categoryId == 0)
            {
               
                query = @"
            SELECT p.ProductID, p.ProductName, p.InventoryQuantity AS Amount, p.Price,
                   c.Category, i.Brand, i.BatchNumber
            FROM Product p
            INNER JOIN Category c ON p.CategoryID = c.CategoryID
            LEFT JOIN ProductImport i ON p.BatchNumber = i.BatchNumber";
            }
            else
            {
              
                query = @"
            SELECT p.ProductID, p.ProductName, p.InventoryQuantity AS Amount, p.Price,
                   c.Category, i.Brand, i.BatchNumber
            FROM Product p
            INNER JOIN Category c ON p.CategoryID = c.CategoryID
            LEFT JOIN ProductImport i ON p.BatchNumber = i.BatchNumber
            WHERE p.CategoryID = @CategoryID";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (categoryId != 0)
                    da.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProduct.DataSource = dt;

                HighlightLowStock();
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue == null)
                return;

           
            if (cbCategory.SelectedValue is DataRowView)
                return;

            int categoryId;
            if (int.TryParse(cbCategory.SelectedValue.ToString(), out categoryId))
            {
                LoadProductByCategory(categoryId);
            }
        }
    }
}

