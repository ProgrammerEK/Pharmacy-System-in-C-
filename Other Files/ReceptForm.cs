using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_System.Other_Files
{
    public partial class ReceptForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable dt;

        public ReceptForm()
        {
            InitializeComponent();
        }

        private void ReceptForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select Category,PName,SellingQnty,Price from tblProducts";
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Db_Class _ClsPrint = new Db_Class();
            _ClsPrint.ClsPrint(dataGridView1, "");
            _ClsPrint.PrintForm();
        }
    }
}
