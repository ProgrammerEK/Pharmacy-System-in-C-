using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_System.Main_User_Files
{
    public partial class Admin_Form : MetroFramework.Forms.MetroForm
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void resePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Files.ResetPassword_Form ad = new Login_Files.ResetPassword_Form();
            ad.Show();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            lblRank.Hide();
            rank(Convert.ToInt32(lblRank.Text));
            if (lblRank.Text == "2")
            {
                btnStaff.Enabled = false;
                newStaffToolStripMenuItem1.Enabled = false;
                newUserToolStripMenuItem.Enabled = false;
                btnRecords.Enabled = false;
            }
        }
        public void rank(int x)
        {
            lblRank.Text = x.ToString();
        }
        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form ad = new Login_Form();
            ad.Show();
        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Point_Of_Sale_Files.Category_Form ct = new Point_Of_Sale_Files.Category_Form();
            ct.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.PerformClick();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Files.Registration_Form rf = new Login_Files.Registration_Form();
            rf.ShowDialog();
        }

        private void newStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnStaff.PerformClick();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStaff.PerformClick();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Point_Of_Sale_Files.Product_Form pr = new Point_Of_Sale_Files.Product_Form();
            pr.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnProducts.PerformClick();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Files.Report_Form vf = new Report_Files.Report_Form();
            vf.rank(1);
            vf.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnProducts.PerformClick();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Files.Report_Form vs = new Report_Files.Report_Form();
            vs.rank(1);
            vs.ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSales.PerformClick();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Files.Registration_Form vs = new Login_Files.Registration_Form();
            vs.ShowDialog();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnView.PerformClick();
        }

        private void saleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Point_Of_Sale_Files.Selling_Form cf = new Point_Of_Sale_Files.Selling_Form();
            cf.rank(1);
            cf.ShowDialog();

        }

        private void productStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Files.DateForm df = new Report_Files.DateForm();
            df.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productStateToolStripMenuItem.PerformClick();
        }
    }
}
