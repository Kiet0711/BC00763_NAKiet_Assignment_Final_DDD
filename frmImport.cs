using System;
using System.Collections;
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
    public partial class frmImport : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        decimal totalPrice = 0;

        public frmImport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStorage frmStorage = new frmStorage();
            frmStorage.Show();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserRole != "Admin" && Session.CurrentUserRole != "Manager" && Session.CurrentUserRole != "Stock")
            {
                MessageBox.Show("Just Admin, Manager and Stock can use this function!",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
                frmStorage frmStorage = new frmStorage();
                frmStorage.Show();
            }
            GenerateBatchNumber();
            LoadImportPartners();
            LoadBrand();

            lvProduct.View = View.Details;
            lvProduct.Columns.Add("Product ID", 100);
            lvProduct.Columns.Add("Product Name", 150);
            lvProduct.Columns.Add("Amount", 80);
            lvProduct.Columns.Add("Brand", 120);
            lvProduct.Columns.Add("Price", 100);
        }
        private void GenerateBatchNumber()
        {
         
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 BatchNumber FROM ProductImport ORDER BY BatchNumber DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastBatch = result.ToString();
                    string numericPart = new string(lastBatch.Where(char.IsDigit).ToArray());

                    int number = 0;
                    if (int.TryParse(numericPart, out number))
                    {
                        number++;
                        lbBatchNumber.Text = number.ToString("D3");
                    }
                    else
                    {
                        lbBatchNumber.Text = "001";
                    }
                }
                else
                {
                    lbBatchNumber.Text = "001";
                }
            }
        }
        private void LoadBrand()
        {
            cbBrand.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Brand FROM ProductImport";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbBrand.Items.Add(reader["Brand"].ToString());
                }
                reader.Close();
            }
        }
        private void LoadImportPartners()
        {
            cbImportPartner.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT ImportPartner FROM ProductImport";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbImportPartner.Items.Add(reader["ImportPartner"].ToString());
                }
                reader.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            string keyword = txtProduct.Text.Trim();
            int quantity;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please, enter Product Name or Product ID!");
                return;
            }

            if (!int.TryParse(txtAmount.Text.Trim(), out quantity) || quantity <= 0)
            {
                MessageBox.Show("Amount Entered Ivalid!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int productID;
                string query;
                SqlCommand cmd;

                if (int.TryParse(keyword, out productID))
                {
                    query = @"SELECT ProductID, ProductName, Price, BatchNumber 
                          FROM Product 
                          WHERE ProductID = @ProductID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                }
                else
                {
                    query = @"SELECT ProductID, ProductName, Price, BatchNumber 
                          FROM Product 
                          WHERE ProductName LIKE @ProductName";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", "%" + keyword + "%");
                }


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string pID = reader["ProductID"].ToString();
                    string pName = reader["ProductName"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    string brand = cbBrand.Text.ToString();

                
                    ListViewItem item = new ListViewItem(pID);
                    item.SubItems.Add(pName);
                    item.SubItems.Add(quantity.ToString());
                    item.SubItems.Add(brand);
                    item.SubItems.Add(price.ToString("N0")); 
                    lvProduct.Items.Add(item);

                    UpdateTotal(); 
                }
                else
                {
                    MessageBox.Show("Product Not Found!");
                }

                reader.Close();

            }
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (ListViewItem item in lvProduct.Items)
            {
                decimal price = decimal.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Any);
                int quantity = int.Parse(item.SubItems[2].Text);
                total += price * quantity;
            }
            lbTotal.Text = total.ToString("N0") + " VND";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvProduct.SelectedItems)
                {
                    decimal price = decimal.Parse(item.SubItems[4].Text);
                    int quantity = int.Parse(item.SubItems[2].Text);
                    totalPrice -= price * quantity;
                    lvProduct.Items.Remove(item);
                }

                lbTotal.Text = totalPrice.ToString("N0") ;
            }
            else
            {
                MessageBox.Show("Please Select Product to Delete!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvProduct.Items.Count == 0)
            {
                MessageBox.Show("Didn't have any Product to save!");
                return;
            }

            string batchNumber = lbBatchNumber.Text;
            string importPartner = cbImportPartner.Text;
            DateTime importDate = dateImport.Value;
            string brand = lvProduct.Items[0].SubItems[3].Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (ListViewItem item in lvProduct.Items)
                {
                    int productID = int.Parse(item.SubItems[0].Text);
                    int receivedQty = int.Parse(item.SubItems[2].Text);
                    decimal purchaseCost = decimal.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.Any);


                    string query = @"INSERT INTO ProductImport 
                                     (BatchNumber, ImportDate, Brand, ImportPartner, ReceivedQuantity, PurchaseCost)
                                     VALUES (@BatchNumber, @ImportDate, @Brand, @ImportPartner, @ReceivedQuantity, @PurchaseCost)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BatchNumber", batchNumber);
                    cmd.Parameters.AddWithValue("@ImportDate", importDate);
                    cmd.Parameters.AddWithValue("@Brand", cbBrand.Text);
                    cmd.Parameters.AddWithValue("@ImportPartner", importPartner);
                    cmd.Parameters.AddWithValue("@ReceivedQuantity", receivedQty);
                    cmd.Parameters.AddWithValue("@PurchaseCost", purchaseCost);
                    cmd.ExecuteNonQuery();


                    string updateProduct = @"UPDATE Product 
                                            SET InventoryQuantity = InventoryQuantity + @ReceivedQuantity,
                                            BatchNumber = @BatchNumber
                                            WHERE ProductID = @ProductID";
                    SqlCommand updateCmd = new SqlCommand(updateProduct, conn);
                    updateCmd.Parameters.AddWithValue("@ReceivedQuantity", receivedQty);
                    updateCmd.Parameters.AddWithValue("@BatchNumber", batchNumber);
                    updateCmd.Parameters.AddWithValue("@ProductID", productID);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data Saved!");
                lvProduct.Items.Clear();
                totalPrice = 0;
                lbTotal.Text = "0 VND";
                GenerateBatchNumber();

                
            }
            this.Close();
            frmStorage frmStorage = new frmStorage();
            frmStorage.Show();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
