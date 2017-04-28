using System;
using System.Windows.Forms;

namespace Pharmacy_System.Main_User_Files
{
    public partial class Cushier_Form : MetroFramework.Forms.MetroForm
    {


        public Cushier_Form()
        {
            InitializeComponent();
        }

        private void Cushier_Form_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
            lblRank.Hide();
        }
        public void rank(int x)
        {
            lblRank.Text = x.ToString();
        }

        private void closeFormToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do You Really Wany To Log Out?", "Pharmacy System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                if (lblRank.Text == "1")
                {
                    this.Hide();
                    Admin_Form ad = new Admin_Form();
                    ad.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Login_Form lf = new Login_Form();
                    lf.ShowDialog();
                }
            }
            else if (dia == DialogResult.No)
            {
                btnAddP.Focus();
            }
        }

        private void Cushier_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void saleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnSale.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            btnAddP.PerformClick();
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnViewP.PerformClick();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            btnViewS.PerformClick();
        }

        private void btnViewS_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Report_Files.Report_Form vs = new Report_Files.Report_Form();
            vs.rank(0);
            vs.ShowDialog();
        }

        private void btnSale_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Point_Of_Sale_Files.Selling_Form sf = new Point_Of_Sale_Files.Selling_Form();
            sf.rank(0);
            sf.ShowDialog();

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnViewP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Other_Files.ShopStore_Form sg = new Other_Files.ShopStore_Form();
            sg.ShowDialog();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Other_Files.AddToShop_Form ad = new Other_Files.AddToShop_Form();
            ad.rank(2);
            ad.ShowDialog();
        }
    }
}
