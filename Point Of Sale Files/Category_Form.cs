using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_System.Class_Files;

namespace Pharmacy_System.Point_Of_Sale_Files
{
    public partial class Category_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        DataTable dt;
        public Category_Form()
        {
            InitializeComponent();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex = 0;
            getData();
            getNo();

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
        void getData()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from tblCategories";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cboCategory.Items.Add(reader["Category"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
            try
            {
                connection.Open();
                SqlCommand comd = new SqlCommand("select Category from tblCategories", connection);
                SqlDataAdapter da = new SqlDataAdapter(comd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (txtNewCategory.Text == "")
            {
                MessageBox.Show("Kindly Type In The Category Name", "Pharmacy System");
                txtNewCategory.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into [dbo].[tblCategories] (Category) values('" + txtNewCategory.Text + "')";
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("New Category Saved Successfully", "Pharmacy System");
                    cboCategory.Items.Clear();
                    cboCategory.Text = "<--Categories-->";
                    txtNewCategory.Clear();
                    getData();
                    getNo();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void Category_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeFormToolStripMenuItem.PerformClick();
        }
    }
}
