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
    public partial class frmStaffManagement : Form
    {
        string connectionString = "Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";
        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                txtStaffID.Text = row.Cells["StaffID"].Value?.ToString();
                txtStaffName.Text = row.Cells["StaffName"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                cboSex.Text = row.Cells["Sex"].Value?.ToString();
                cboJobRole.Text = row.Cells["JobTitle"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["BirthDay"].Value?.ToString(), out DateTime dob))
                {
                    dateOfBirth.Value = dob;
                }
            }
        }
        private void LoadStaffData()
        {
            string query = @"SELECT 
                        s.StaffID,
                        s.StaffName,
                        s.WorkingHour,
                        r.JobTitle,
                        s.Sex,
                        s.BirthDay,  
                        s.PhoneNumber
                     FROM Staff s
                     JOIN SalaryRate r ON s.RateID = r.RateID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStaff.DataSource = dt;
            }
        }

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            LoadJobRoles();
            LoadSex();
            if (Session.CurrentUserRole != "Admin" && Session.CurrentUserRole != "Manager")
            {
                MessageBox.Show("Just Admin and Manager can use this function!",
                                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();

            }
        }
        private void LoadJobRoles()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT RateID, JobTitle FROM SalaryRate";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboJobRole.DataSource = dt;
                cboJobRole.DisplayMember = "JobTitle";
                cboJobRole.ValueMember = "RateID";
            }
        }
        private void LoadSex()
        {
            cboSex.Items.Clear();
            cboSex.Items.Add("Male").ToString();
            cboSex.Items.Add("Female").ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string jobRole = cboJobRole.Text.Trim();
                    string getRateQuery = "SELECT RateID FROM SalaryRate WHERE JobTitle = @JobTitle";

                    SqlCommand getRateCmd = new SqlCommand(getRateQuery, con);
                    getRateCmd.Parameters.AddWithValue("@JobTitle", jobRole);
                    object rateIdObj = getRateCmd.ExecuteScalar();
                    int RateID = Convert.ToInt32(rateIdObj);

                    string query = @"INSERT INTO Staff (StaffID, StaffName, Sex, Birthday, PhoneNumber, RateID)
                     VALUES (@StaffID, @StaffName, @Sex, @Birthday, @PhoneNumber, @RateID)";


                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                    cmd.Parameters.AddWithValue("@StaffName", txtStaffName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sex", cboSex.Text);
                    cmd.Parameters.AddWithValue("@Birthday", dateOfBirth.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@RateID", RateID);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Add new staff Success!");
                    LoadStaffData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding new staff: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                string jobRole = cboJobRole.Text.Trim();
                string getRateQuery = "SELECT RateID FROM SalaryRate WHERE JobTitle = @JobTitle";

                SqlCommand getRateCmd = new SqlCommand(getRateQuery, con);
                getRateCmd.Parameters.AddWithValue("@JobTitle", jobRole);
                object rateIdObj = getRateCmd.ExecuteScalar();

               
                int rateId = Convert.ToInt32(rateIdObj);
                string updateQuery = @"UPDATE Staff
                               SET StaffName = @StaffName,
                                   Sex = @Sex,
                                   Birthday = @Birthday,
                                   PhoneNumber = @PhoneNumber,
                                   RateID = @RateID
                               WHERE StaffID = @StaffID";

                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                updateCmd.Parameters.AddWithValue("@StaffName", txtStaffName.Text.Trim());
                updateCmd.Parameters.AddWithValue("@Sex", cboSex.Text);
                updateCmd.Parameters.AddWithValue("@Birthday", dateOfBirth.Value);
                updateCmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                updateCmd.Parameters.AddWithValue("@RateID", rateId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Update staff Information success!");
                LoadStaffData();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                MessageBox.Show("Please Select or enter staff ID to delete",
                                "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure to delete staff, who have ID" + txtStaffID.Text + " ?",
                "Accept delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            string query = "DELETE FROM Staff WHERE StaffID = @StaffID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StaffID", txtStaffID.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Delete staff success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Not Found Staff Need to delete", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LoadStaffData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when delete staff: \n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            string query = @"SELECT 
                        s.StaffID,
                        s.StaffName,
                        s.WorkingHour,
                        s.Sex,
                        s.BirthDay,
                        s.PhoneNumber,
                        r.JobTitle
                     FROM Staff s
                     JOIN SalaryRate r ON s.RateID = r.RateID
                     WHERE s.StaffID LIKE @keyword
                        OR s.StaffName LIKE @keyword";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStaff.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when searching Staff: \n" + ex.Message,
                                "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAccount frmAccount = new frmAccount();
            frmAccount.ShowDialog();
        }
    }
}
