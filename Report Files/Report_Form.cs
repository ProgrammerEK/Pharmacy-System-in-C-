using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Pharmacy_System.Report_Files
{
    public partial class Report_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable dt;
        public Report_Form()
        {
            InitializeComponent();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do You Really Wany To Log Out?", "Pharmacy System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                if (lblRank.Text == "1")
                {
                    this.Hide();
                    Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
                    ad.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Main_User_Files.Cushier_Form lf = new Main_User_Files.Cushier_Form();
                    lf.ShowDialog();
                }
            }
            else if (dia == DialogResult.No)
            {
                dpt.Focus();
            }

        }

        private void Report_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allDate = dpt.Text + " " + lblTime.Text;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Pharmacy System Report";
            printer.SubTitle = string.Format(allDate);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintSettings.PaperSizes.Equals("A4");
            printer.Footer = "Pharmacy System Report";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getData("select Category,PName AS Products_Name,PID AS Product_ID,Strength AS Strenght_OR_Concentration,Dosage AS Dosage_Form,Amount AS Remaining_Quantity from tblShopStore");
            getNo();
        }
        public void getData(string query)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getData("select Category,Name AS Products_Name,PID AS Product_ID,Strength AS Strenght_OR_Concentration,Dosage AS Dosage_Form,PTotal AS Remaining_Available from tblTotal");
            getNo();
        }

        private void wholeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getData("select Category,PName AS Products_Name,PID AS Product_ID,Strength AS Strenght_OR_Concentration,Dosage AS Dosage_Form,AlertQnty AS Alert_Quantity,SellingQnty AS Selling_Quantity,Price,Inscription from tblProducts");
            getNo();
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getData("select Category,PName AS Products_Name,PID AS Product_ID,Strenght AS Strenght_OR_Concentration,Dosage AS Dosage_Form,Quantity AS Quantity_Purchased,DoT as Date from tblSales where DoT='" + DoT2.Text + "'");
            getNo();
        }

        private void specificDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            mpDates.Show();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            getData("select Category,PName AS Products_Name,PID AS Product_ID,Strenght AS Strenght_OR_Concentration,Dosage AS Dosage_Form,Quantity AS Quantity_Purchased,DoT as Date from tblSales where DoT='" + DoT2.Text + "'");
            getNo();
            mpDates.Hide();
            dataGridView1.Show();
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            mpDates.Hide();
            timer1.Start();
            lblRank.Hide();
            if (lblRank.Text == "0")
            {
                addProductToolStripMenuItem.Enabled = false;
                wholeProductsToolStripMenuItem.Enabled = false;
                specificDateToolStripMenuItem.Enabled = false;
                betweenDatesToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
            }

        }
        public void rank(int x)
        {
            lblRank.Text = x.ToString();
        }
        //Funtion to get the collumn number of each row
        public void getNo()
        {
            int cellnum = 0;
            int rownum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                dataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }
        private void btnGet2_Click(object sender, EventArgs e)
        {
            getData("select Category,PName AS Products_Name,PID AS Product_ID,Strenght AS Strenght_OR_Concentration,Dosage AS Dosage_Form,Quantity AS Quantity_Purchased,DoT as Date from tblSales where DoT between'" + DoF.Text + "' and '" + DoT.Text + "'");
            getNo();
            mpDates.Hide();
            dataGridView1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void betweenDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specificDateToolStripMenuItem.PerformClick();
        }
    }
}
