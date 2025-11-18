using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class frmCreateBill : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public frmCreateBill()
        {
            InitializeComponent();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormBill_Load(object sender, EventArgs e)

        {
            lbTypeOfCustomer.Text = "Stranger";
            loadDataComboBox();

            listProduct.View = View.Details;
            listProduct.Columns.Add("Products", 125);
            listProduct.Columns.Add("Amount", 125);
            listProduct.Columns.Add("Price", 125);

            string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
            string query = "SELECT TOP 1 BillID FROM Bill ORDER BY BillID DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int billID = Convert.ToInt32(result) + 1;
                    lbBillID.Text = billID.ToString();
                }
                else
                {
                    lbBillID.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            int BillID = lbBillID.Text.Trim() == "" ? 0 : int.Parse(lbBillID.Text.Trim());
            string BillCreator = cbBillCreator.Text;
            DateTime BillDate = dateCreationBill.Value;
            int CustomerID = txtPhoneNumber.Text.Trim() == "" ? 0 : int.Parse(txtPhoneNumber.Text.Trim());
            string CustomerName = txtCustomerName.Text.Trim();
            string TypeName = lbTypeOfCustomer.Text;

            if ( string.IsNullOrEmpty(CustomerName))
            {
                MessageBox.Show("Please enter Customer Information", "Validation Error", MessageBoxButtons.OK);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string checkCustomerQuery = "SELECT COUNT(*) FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand checkCmd = new SqlCommand(checkCustomerQuery, conn, tran);
                    checkCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        string insertCustomerQuery = "INSERT INTO Customer (CustomerID, CustomerName, TypeID)"
                            + "VALUES (@CustomerID, @CustomerName,(SELECT TOP 1 TypeName FROM TypeOfCustomer WHERE TypeID= @TypeID))";
                        SqlCommand insertCmd = new SqlCommand(insertCustomerQuery, conn, tran);
                        insertCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                        insertCmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                        insertCmd.Parameters.AddWithValue("@CustomerType", "Stranger");
                        insertCmd.ExecuteNonQuery();
                    }
                    else
                    {


                        string updateCustomerQuery = @"UPDATE Customer SET NumberOfPrchases = ISNULL(NumberOfPrchases, 0) + 1 WHERE CustomerID = @CustomerID";

                        SqlCommand updateCmd = new SqlCommand(updateCustomerQuery, conn, tran);
                            updateCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                            updateCmd.ExecuteNonQuery();
                        
                    }
                    string insertBillQuery = @" INSERT INTO Bill (BillID, DateCreate, CustomerID, StaffID, InvoiceStatus) VALUES (@BillID, @BillDate, @CustomerID,(SELECT TOP 1 StaffID FROM Staff WHERE StaffName = @StaffName),'paid')";
                    SqlCommand BillCmd = new SqlCommand(insertBillQuery, conn, tran);
                    BillCmd.Parameters.AddWithValue("@BillID", BillID);
                    BillCmd.Parameters.AddWithValue("@BillDate", BillDate);
                    BillCmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    BillCmd.Parameters.AddWithValue("@StaffName", BillCreator);
                    BillCmd.ExecuteNonQuery();

                    int detailIndex = 1; 

                    foreach(ListViewItem item in listProduct.Items)
                    {
                        
                            string productName = item.SubItems[0].Text;
                            int amount = int.Parse(item.SubItems[1].Text);

                          
                            string getProductIDQuery = "SELECT ProductID FROM Product WHERE ProductName = @ProductName";
                            SqlCommand getProductCmd = new SqlCommand(getProductIDQuery, conn, tran);
                            getProductCmd.Parameters.AddWithValue("@ProductName", productName);
                            object result = getProductCmd.ExecuteScalar();

                            if (result == null)
                            {
                                throw new Exception($"Product '{productName}' not found in database.");
                            }

                            int productID = Convert.ToInt32(result);

                  
                        

                            string insertBillDetailQuery = @"INSERT INTO BillDetail ( BillID, ProductID, AmountProduct)  VALUES ( @BillID, @ProductID, @Amount)";

                            SqlCommand billDetailCmd = new SqlCommand(insertBillDetailQuery, conn, tran);
                            
                            billDetailCmd.Parameters.AddWithValue("@BillID", BillID);
                            billDetailCmd.Parameters.AddWithValue("@ProductID", productID);
                            billDetailCmd.Parameters.AddWithValue("@Amount", amount);
                            billDetailCmd.ExecuteNonQuery();

                            detailIndex++;
                    }
                    tran.Commit();

                    List<ListViewItem> ItemsToSend = new List<ListViewItem>();

                    foreach (ListViewItem item in listProduct.Items)
                    {
                        
                        ItemsToSend.Add((ListViewItem)item.Clone());
                    }

                    string TypeOfCustomer = lbTypeOfCustomer.Text;
                    frmSaved formBillSaved = new frmSaved(
                             BillID.ToString(),
                             BillDate.ToString("dd-MM-YYYY"),
                             BillCreator,
                             CustomerName,
                             CustomerID.ToString(),
                             TypeOfCustomer,
                             items: ItemsToSend
                      );
                    this.Close();
                    formBillSaved.Show();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error saving bill: " + ex.Message, "Error", MessageBoxButtons.OK);
                    return;

                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string Products = txtProduct.Text.Trim();
            int Amount = txtAmount.Text.Trim() == "" ? 0 : int.Parse(txtAmount.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProductName, Price FROM Product WHERE ProductName = @Products OR ProductID = @Products";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Products", Products);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        String productName = reader["ProductName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        decimal totalPrice = price * Amount;

                        ListViewItem item = new ListViewItem(productName);
                        item.SubItems.Add(Amount.ToString());
                        item.SubItems.Add(totalPrice.ToString("F2"));
                        listProduct.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK);
                    }
                    reader.Close();
                }


            }

            if (Products == "")
            {
                MessageBox.Show("Please enter Products", "Vcalidation Error", MessageBoxButtons.OK);
                return;
            }
            if (Amount <= 0)
            {
                MessageBox.Show("Please enter Amount greater than 0", "Vcalidation Error", MessageBoxButtons.OK);
                return;
            }



        }
        private void loadDataComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StaffName FROM Staff";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbBillCreator.DataSource = dt;
                cbBillCreator.DisplayMember = "StaffName";

            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string CustomerID = txtPhoneNumber.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
             string query = @"SELECT t.TypeName, c.CustomerName FROM Customer c INNER JOIN TypeOfCustomer t ON c.TypeID = t.TypeID  
                            WHERE c.CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string customerName = reader["CustomerName"].ToString();
                        string customerType = reader["TypeName"].ToString();
                        txtCustomerName.Text = customerName;
                        lbTypeOfCustomer.Text = customerType;
                    }
                    else
                    {
                        lbTypeOfCustomer.Text = "Stranger";
                    }
                    reader.Close();
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            
                            
                        

                    
               
            
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listProduct.SelectedItems.Count > 0)
            {
                listProduct.Items.Remove(listProduct.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}