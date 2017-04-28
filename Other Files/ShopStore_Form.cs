using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
namespace Pharmacy_System.Other_Files
{
    public partial class ShopStore_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable tb;

        public ShopStore_Form()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Other_Files.Db_Class _ClsPrint = new Other_Files.Db_Class();
            _ClsPrint.ClsPrint(dataGridView1, "");
            _ClsPrint.PrintForm();
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
        private void ShopStore_Form_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select Category,PName AS Product_Name, PID AS Product_ID, Strength AS Strength_Conc,Dosage AS Dosage_Form,Amount AS Quantity from tblShopStore ", connection);
                tb = new DataTable();
                ad.Fill(tb);
                dataGridView1.DataSource = tb;
                connection.Close();
                getNo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tb);
            dv.RowFilter = string.Format("Product_Name LIKE '%{0}%'", txtFirst.Text);
            dataGridView1.DataSource = dv;
            getNo();
        }

        private void ShopStore_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main_User_Files.Cushier_Form fg = new Main_User_Files.Cushier_Form();
            fg.ShowDialog();
        }
    }
}
