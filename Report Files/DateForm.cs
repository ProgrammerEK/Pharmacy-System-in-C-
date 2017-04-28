using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_System.Report_Files
{
    public partial class DateForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable table;
        public DateForm()
        {
            InitializeComponent();
        }

        private void DateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void exitFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitFormToolStripMenuItem.PerformClick();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nearDepletionDrugsToolStripMenuItem.PerformClick();
        }

        private void updateRcrdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nearExpiryProductsToolStripMenuItem.PerformClick();
        }

        private void nearExpiryProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Category,PID AS Product_ID,PName AS Product_Name,Strength AS Strength_Concentration,Dosage AS Dosage_Form,DoE AS Expiry_Date from tblPurchases", connection);
                table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
                getNo();
                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Other_Files.Db_Class _ClsPrint = new Other_Files.Db_Class();
            _ClsPrint.ClsPrint(dataGridView1, "");
            _ClsPrint.PrintForm();
        }

        private void nearDepletionDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Category,PID AS Product_ID,Name AS Product_Name,Strength AS Strength_Concentration,Dosage AS Dosage_Form,PTotal AS Items_Available from tblTotal", connection);
                table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
                getNo();
                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
