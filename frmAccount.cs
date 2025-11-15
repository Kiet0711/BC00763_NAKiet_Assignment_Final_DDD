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
    public partial class frmAccount : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;");
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUserRole != "Admin" && Session.CurrentUserRole != "Manager")
            {
                MessageBox.Show("Just Admin and Manager can use this function!",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
                frmStaffManagement frmStaffManagement = new frmStaffManagement();
                frmStaffManagement.Show();


            }
            LoadData();
            LoadStaff();
            LoadRoles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStaffManagement frmStaffManagement = new frmStaffManagement();
            frmStaffManagement.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                txtAccountID.Text = row.Cells["AccountID"].Value.ToString();
                txtUserName.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["PasswordHash"].Value.ToString();
                cbbRole.Text = row.Cells["Roles"].Value.ToString();
                cbbStaffID.SelectedValue = row.Cells["StaffID"].Value;
            }
        }
        private void LoadData()
        {
            try
            {
                string query = @"SELECT a.AccountID, a.Username, a.PasswordHash, a.Roles, a.StaffID, s.StaffName
                                 FROM Account a 
                                 JOIN Staff s ON a.StaffID = s.StaffID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAccount.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void LoadStaff()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT StaffID, StaffName FROM Staff", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbbStaffID.DataSource = dt;
                cbbStaffID.DisplayMember = "StaffName";
                cbbStaffID.ValueMember = "StaffID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadRoles()
        {
            cbbRole.Items.Clear();
            cbbRole.Items.Add("Admin");
            cbbRole.Items.Add("Manager");
            cbbRole.Items.Add("Sale");
            cbbRole.Items.Add("Stock");
            cbbRole.Items.Add("C.Service");
            cbbRole.Items.Add("Cashier");

        }
        private void ClearFields()
        {
            txtAccountID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            cbbRole.SelectedIndex = -1;
            cbbStaffID.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(cbbRole.Text) ||
               cbbStaffID.SelectedValue == null)
            {
                MessageBox.Show("Missing Information of one or more fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Account (Username, PasswordHash, Roles, StaffID) VALUES (@User, @Password, @Role, @StaffID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", cbbRole.Text);
                cmd.Parameters.AddWithValue("@StaffID", cbbStaffID.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New account created successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(txtAccountID.Text))
            {
                MessageBox.Show("Please select an account to update.");
                return;
            }

            string query = "UPDATE Account SET ";
            bool hasChange = false;

            if (!string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                query += "Username = @User, ";
                hasChange = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                query += "PasswordHash = @Password, ";
                hasChange = true;
            }
            if (!string.IsNullOrWhiteSpace(cbbRole.Text))
            {
                query += "Roles = @Role, ";
                hasChange = true;
            }
            if (cbbStaffID.SelectedValue != null)
            {
                query += "StaffID = @StaffID, ";
                hasChange = true;
            }

            if (!hasChange)
            {
                MessageBox.Show("No information provided to update.");
                return;
            }

            query = query.TrimEnd(',', ' ') + " WHERE AccountID = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtAccountID.Text);

                if (query.Contains("@User")) cmd.Parameters.AddWithValue("@User", txtUserName.Text);
                if (query.Contains("@Password")) cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                if (query.Contains("@Role")) cmd.Parameters.AddWithValue("@Role", cbbRole.Text);
                if (query.Contains("@StaffID")) cmd.Parameters.AddWithValue("@StaffID", cbbStaffID.SelectedValue);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account updated successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text))
            {
                MessageBox.Show("Please select an account to delete.");
                return;
            }

            try
            {
                string query = "DELETE FROM Account WHERE AccountID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtAccountID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account deleted successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message);
                conn.Close();
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            string query = @"SELECT a.AccountID, a.Username, a.PasswordHash, a.Roles, a.StaffID, s.StaffName
                     FROM Account a 
                     JOIN Staff s ON a.StaffID = s.StaffID
                     WHERE 
                         CAST(a.AccountID AS NVARCHAR) LIKE @search OR
                         a.Username LIKE @search OR
                         s.StaffName LIKE @search";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAccount.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
