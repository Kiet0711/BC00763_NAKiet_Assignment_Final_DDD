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
    public partial class frmAdd : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public frmAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtProductID.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();                        
                        string getCategoryIDQuery = "SELECT CategoryID FROM Category WHERE Category = @CategoryName";
                        int categoryID = 0;

                    using (SqlCommand cmdCategory = new SqlCommand(getCategoryIDQuery, connection))
                    {
                        cmdCategory.Parameters.AddWithValue("@CategoryName", txtCategory.Text.Trim());
                        object result = cmdCategory.ExecuteScalar();
                        if (result != null)
                        {
                            categoryID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Category Not Found! ");
                            return;
                        }
                    }
                    string query = "INSERT INTO Product (ProductID, ProductName, Price, CategoryID) VALUES (@ProductID, @ProductName, @Price, @CategoryID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                        command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStorage frmStorage = new frmStorage();
            frmStorage.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string getCategoryIDQuery = "SELECT CategoryID FROM Category WHERE Category = @CategoryName";
                    SqlCommand cmdCategory = new SqlCommand(getCategoryIDQuery, connection);
                    cmdCategory.Parameters.AddWithValue("@CategoryName", txtCategory.Text.Trim());
                    object resultCategory = cmdCategory.ExecuteScalar();
                    int categoryID = Convert.ToInt32(resultCategory);
                    string query = "UPDATE Product SET CategoryID = @Category, ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                        command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        command.Parameters.AddWithValue("@Category", categoryID);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            foreach (Form frm in Application.OpenForms)
                            {
                                if (frm is frmStorage storageForm)
                                {
                                    storageForm.RefreshData();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
