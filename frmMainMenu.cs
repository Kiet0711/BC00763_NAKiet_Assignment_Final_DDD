using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC00763_KietNA_Assignment_DDD
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void BtnCreateBill_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCreateBill frmCreateBill = new frmCreateBill();
            frmCreateBill.ShowDialog();
            
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStorageManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStorage frmStorage = new frmStorage();
            frmStorage.ShowDialog();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStaffManagement frmStaffManagement = new frmStaffManagement();
            frmStaffManagement.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBill frmBill = new frmBill();
            frmBill.ShowDialog();
        }
    }
}
