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
using static System.Collections.Specialized.BitVector32;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class frmLogin : Form
    {
        string connectionString ="Data Source=KIE\\BC00763_KIETNA;Initial Catalog=DDD_Assignment;Integrated Security=True;";

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          string username = txtUserName.Text.Trim();
          string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password", "Validation Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                string query = "SELECT * FROM Account WHERE Username = @Username AND PasswordHash = @PasswordHash";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);
                 

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string role = reader["Roles"].ToString();
                            Session.CurrentUserRole = role;
                            MessageBox.Show($"Success Login\nRole: {role}", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);                                                      
                            FormMainMenu main = new FormMainMenu(); 
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("connection error " + ex.Message);
                    }
                }
            }
        }    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        public static class Session
        {
            public static string CurrentUserRole { get; set; }
            public static int CurrentStaffID { get; set; }
            public static string CurrentUsername { get; set; }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
