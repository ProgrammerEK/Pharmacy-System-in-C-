using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_System.Login_Files
{
    public partial class ViewUsers_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable dt;
        public ViewUsers_Form()
        {
            InitializeComponent();
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
        private void ViewUsers_Form_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select First_Name,Last_Name,JobTitle,Gender,Address,Contact,Email from tblUsers";
                command.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                getNo();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("First_Name LIKE '%{0}%'", txtFirst.Text);
            dataGridView1.DataSource = dv;
            getNo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Other_Files.Db_Class _ClsPrint = new Other_Files.Db_Class();
            _ClsPrint.ClsPrint(dataGridView1, "");
            _ClsPrint.PrintForm();
        }

        private void ViewUsers_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Registration_Form rf = new Registration_Form();
            rf.ShowDialog();
        }
    }
}
