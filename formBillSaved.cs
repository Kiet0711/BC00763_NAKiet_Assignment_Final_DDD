using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class formBillSaved : Form
    {
        private string BillID;
        private string BillDate;
        private string BillCreator;
        private string CustomerName;
        private string CustomerID;
        private string TypeOfCustomer;
        List<ListViewItem> receivedItems;

        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public formBillSaved(string billID, string billDate, string billCreator, string customerName, string customerID, string typeOfCustomer, List<ListViewItem> items)
        {
            InitializeComponent();
            this.BillID = billID;
            this.BillDate = billDate;
            this.BillCreator = billCreator;
            this.CustomerName = customerName;
            this.CustomerID = customerID;
            this.TypeOfCustomer = typeOfCustomer;
            receivedItems = items;

            lbBillID.Text = BillID;
            lbCreator.Text = BillCreator;
            lbDateCreation.Text = BillDate;
            lbCustomerName.Text = CustomerName;
            lbCustomerType.Text = TypeOfCustomer;
            foreach (ListViewItem item in receivedItems)
            {
                listTotalProduct.Items.Add((ListViewItem)item.Clone());
            }
            decimal total = 0;
            foreach (ListViewItem item in listTotalProduct.Items)
            {
                try
                {
                    string value = item.SubItems[2].Text;
                    if (decimal.TryParse(value, out decimal number))
                    {
                        total += number;
                    }

                }
                catch
                {
                    continue;

                }
            }
            lbTotalPaid.Text = total.ToString("N2");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCreateBill frmCreateBill = new frmCreateBill();
            frmCreateBill.Show();
        }

        private void formBillSaved_Load(object sender, EventArgs e)
        {
            cboPaymentMethod.Items.Add("Cash");
            cboPaymentMethod.Items.Add("Bank Transfer");
            cboPaymentMethod.Items.Add("Card");
            cboPaymentMethod.Items.Add("E-Wallet");
            cboPaymentMethod.Items.Add("Oder...");

            listTotalProduct.View = View.Details;
            listTotalProduct.Columns.Add("Products", 125);
            listTotalProduct.Columns.Add("Amount", 125);
            listTotalProduct.Columns.Add("Price", 125);
        }

        private void btnPrintBill_Click(object sender, EventArgs e)

        {
            try
            {
                string billID = lbBillID.Text;
                string paymentMethod = cboPaymentMethod.SelectedItem.ToString();
                string updateQuery = "UPDATE Bill SET PaymentMethod = @PaymentMethod WHERE BillID = @billID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@billID", billID);
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment method updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the Bill ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Lỗi");
            }
            this.Close();
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.Show();

            
        }

        private void lbCustomerType_Click(object sender, EventArgs e)
        {

        }
    }
}
