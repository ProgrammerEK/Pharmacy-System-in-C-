using DGVPrinterHelper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace Pharmacy_System.Point_Of_Sale_Files
{
    public partial class Selling_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        int selectedRow;
        DataTable table = new DataTable();

        public Selling_Form()
        {
            InitializeComponent();

        }
        void clear()
        {
            txtID.Clear();
            txtDosage.Clear();
            txtSTotal.Clear();
            txtStrength.Clear();
            cboCategory.Text = "<--Category-->";
            txtName.Clear();
            txtQntyP.Clear();
            txtQntyR.Clear();
            txtQntyS.Clear();
            txtPrice.Clear();
            txt.Clear();
            txtAlert.Clear();
            txtSTotal.Clear();
            DoT.Value = DateTime.Today;
            DoE.Value = DateTime.Today;
        }
        public void rank(int x)
        {
            lblRank.Text = x.ToString();
        }
        public void getNo()
        {
            int cellnum = 0;
            int rownum = 0;
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                cellnum = cellnum + 1;
                DataGridView1.Rows[rownum].Cells[0].Value = cellnum;
                rownum = rownum + 1;
            }
        }
        // Form loading
        private void Selling_Form_Load(object sender, System.EventArgs e)
        {
            pnInscription.Hide();
            rank(Convert.ToInt32(lblRank.Text));
            cboCategory.SelectedIndex = 0;
            txtAlert.Hide();
            txtSTotal.Hide();
            txt.Hide();
            DoT.Hide();
            lblRank.Hide();
            // table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Item ID", typeof(string));
            table.Columns.Add("Dosage", typeof(string));
            table.Columns.Add("Strength", typeof(string));
            table.Columns.Add("Selling Qnty", typeof(int));
            table.Columns.Add("Qnty Purchase", typeof(int));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Sub Total", typeof(int));
            table.Columns.Add("Items Remains", typeof(int));
            DataGridView1.DataSource = table;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from tblPurchases ", connection);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cboCategory.Items.Add(read["Category"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
            //autocompletion code
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from tblPurchases ", connection);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    col.Add(read["Category"].ToString());
                    cboCategory.AutoCompleteCustomSource = col;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        SqlCommand comd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "'", connection);
                        SqlDataReader read = comd.ExecuteReader();
                        while (read.Read())
                        {
                            col.Add(read["Dosage"].ToString());
                            txtDosage.AutoCompleteCustomSource = col;
                        }
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
            else
            {
                connection.Close();
            }
        }

        private void txtDosage_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT [Strength] FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "'", connection);
                        SqlDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            col.Add(read["Strength"].ToString());
                            txtStrength.AutoCompleteCustomSource = col;
                        }
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void txtStrength_Leave(object sender, EventArgs e)
        {
            if (txtDosage.Text != "" & txtStrength.Text != "" & txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {

                        connection.Open();
                        SqlCommand command = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                        SqlDataReader rd = command.ExecuteReader();
                        int count = 0;
                        while (rd.Read())
                        {
                            count++;
                        }
                        connection.Close();
                        if (count >= 1)
                        {
                            try
                            {
                                connection.Open();
                                SqlCommand cmd = new SqlCommand("SELECT [Amount] FROM[dbo].[tblShopStore] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                                SqlDataReader read = cmd.ExecuteReader();
                                int cnt = 0;
                                while (read.Read())
                                {
                                    cnt++;

                                }
                                connection.Close();
                                if (cnt >= 1)
                                {
                                    try
                                    {
                                        connection.Open();
                                        SqlCommand comd = new SqlCommand("SELECT [Amount] FROM[dbo].[tblShopStore] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                                        SqlDataReader reader = comd.ExecuteReader();
                                        while (reader.Read())
                                        {
                                            txtQntyR.Text = reader["Amount"].ToString();

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
                                        SqlCommand cmod = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                                        SqlDataReader rad = cmod.ExecuteReader();
                                        while (rad.Read())
                                        {
                                            DoE.Text = rad["DoE"].ToString();
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
                                        SqlCommand comdo = new SqlCommand("SELECT * FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                                        SqlDataReader red = comdo.ExecuteReader();
                                        while (red.Read())
                                        {
                                            txtAlert.Text = red["AlertQnty"].ToString();
                                            txtQntyS.Text = red["SellingQnty"].ToString();
                                            txtPrice.Text = red["Price"].ToString();
                                        }
                                        connection.Close();
                                    }
                                    catch (Exception ex)
                                    {

                                        MessageBox.Show(ex.Message);
                                        connection.Close();
                                    }
                                }
                                else
                                {
                                    DialogResult dia = MessageBox.Show("The Products Is Not Available In The Shelves,Do You Wish To Add It?", "Pharmacy System", MessageBoxButtons.YesNo);
                                    if (dia == DialogResult.Yes)
                                    {
                                        this.Hide();
                                        Other_Files.AddToShop_Form ad = new Other_Files.AddToShop_Form();
                                        ad.ShowDialog();

                                    }
                                    else if (dia == DialogResult.No)
                                    {
                                        clear();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The Product Is Not Yet Purchased", "Pharmacy System");
                            cboCategory.Focus();

                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void cboCategory_Leave(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                pnInscription.Hide();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT [PID] FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "'", connection);
                        SqlDataReader read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            col.Add(read["PID"].ToString());
                            txtID.AutoCompleteCustomSource = col;
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtQntyR.Text);
            int p = Convert.ToInt32(txtQntyP.Text);
            txt.Text = (a - p).ToString();
            string cat = cboCategory.Text;
            string PName = txtName.Text;
            string PID = txtID.Text;
            string Dosage = txtDosage.Text;
            string Strength = txtStrength.Text;
            int sQnty = Convert.ToInt32(txtQntyS.Text);
            int Qnty = Convert.ToInt32(txtQntyP.Text);
            int Price = Convert.ToInt32(txtPrice.Text);
            int total = Convert.ToInt32(txtSTotal.Text);
            int Remains = Convert.ToInt32(txt.Text);
            table.Rows.Add(cat, PName, PID, Dosage, Strength, sQnty, Qnty, Price, total, Remains);
            DataGridView1.DataSource = table;
            getNo();
            int sum = 0;
            for (int i = 0; i < DataGridView1.Rows.Count; ++i)
            {

                txtTotal.Text = (sum += Convert.ToInt32(DataGridView1.Rows[i].Cells[8].Value)).ToString();
            }
            clear();
        }

        private void txtQntyP_Leave(object sender, EventArgs e)
        {
            if (txtQntyP.Text != "")
            {
                if (txtQntyP.Text != "0" | txtQntyP.Text == "")
                {

                    int s = Convert.ToInt32(txtQntyS.Text);
                    int p = Convert.ToInt32(txtQntyP.Text);
                    int pr = Convert.ToInt32(txtPrice.Text);
                    txtSTotal.Text = ((p / s) * pr).ToString();

                }
                else
                {
                    txtSTotal.Clear();
                }
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DataGridView1.Rows[selectedRow];
            row.Cells[0].Value = cboCategory.Text;
            row.Cells[1].Value = txtName.Text;
            row.Cells[2].Value = txtID.Text;
            row.Cells[3].Value = txtDosage.Text;
            row.Cells[4].Value = txtStrength.Text;
            row.Cells[5].Value = txtQntyS.Text;
            row.Cells[6].Value = txtQntyP.Text;
            row.Cells[7].Value = txtPrice.Text;
            row.Cells[8].Value = txtSTotal.Text;
            getNo();
            int sum = 0;
            for (int i = 0; i < DataGridView1.Rows.Count; ++i)
            {

                txtTotal.Text = (sum += Convert.ToInt32(DataGridView1.Rows[i].Cells[8].Value)).ToString();
            }
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedRow = DataGridView1.CurrentCell.RowIndex;
            DataGridView1.Rows.RemoveAt(selectedRow);
            getNo();
            int sum = 0;
            for (int i = 0; i < DataGridView1.Rows.Count; ++i)
            {

                txtTotal.Text = (sum += Convert.ToInt32(DataGridView1.Rows[i].Cells[8].Value)).ToString();
            }
            clear();
        }

        private void cboCategory_Leave_1(object sender, EventArgs e)
        {
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        cols.Add(read["PName"].ToString());
                        txtName.AutoCompleteCustomSource = cols;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                int a = Convert.ToInt32(txt.Text);
                int p = Convert.ToInt32(txtQntyP.Text);
                txtQntyR.Text = (a + p).ToString();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            {
                //DGVPrinter printer = new DGVPrinter();
                //printer.Title = "Pharmacy System Receipt";
                //Font font = new Font("Courier New", 15);
                //PaperSize psize = new PaperSize("Custom", 100, 200);
                //printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
                //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                //printer.PageNumbers = false;
                //printer.PageNumberInHeader = false;
                //printer.PorportionalColumns = true;
                //printer.HeaderCellAlignment = StringAlignment.Near;
                //printer.Footer = "Thank You For Shopping With Us";
                //printer.FooterSpacing = 15;
                //printer.PrintDataGridView(DataGridView1);
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into tblSales values('" + DataGridView1.Rows[selectedRow].Cells[0].Value.ToString() + "','" + DataGridView1.Rows[selectedRow].Cells[1].Value.ToString() + "','" + DataGridView1.Rows[selectedRow].Cells[2].Value.ToString() + "','" + DataGridView1.Rows[selectedRow].Cells[3].Value.ToString() + "','" + DataGridView1.Rows[selectedRow].Cells[4].Value.ToString() + "','" + DataGridView1.Rows[selectedRow].Cells[6].Value.ToString() + "','" + DoT.Text + "')", connection);
                    cmd.ExecuteNonQuery();
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
                    SqlCommand cmd = new SqlCommand("update tblShopStore set Amount='" + DataGridView1.Rows[selectedRow].Cells[9].Value.ToString() + "'where Category='" + DataGridView1.Rows[selectedRow].Cells[0].Value.ToString() + "' and PName='" + DataGridView1.Rows[selectedRow].Cells[1].Value.ToString() + "' and PID='" + DataGridView1.Rows[selectedRow].Cells[2].Value.ToString() + "' and Dosage='" + DataGridView1.Rows[selectedRow].Cells[3].Value.ToString() + "' and Strength='" + DataGridView1.Rows[selectedRow].Cells[4].Value.ToString() + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Products Sold Successfully", "Phramacy System");
                    clear();
                    DataGridView1.DataSource = null;
                    DataGridView1.Rows.Clear();
                    txtTotal.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void Selling_Form_FormClosing(object sender, FormClosingEventArgs e)
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
                    Main_User_Files.Cushier_Form ad = new Main_User_Files.Cushier_Form();
                    ad.ShowDialog();
                }
            }
            else if (dia == DialogResult.No)
            {
                cboCategory.Focus();
            }
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = DataGridView1.Rows[selectedRow];
            cboCategory.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtID.Text = row.Cells[3].Value.ToString();
            txtDosage.Text = row.Cells[4].Value.ToString();
            txtStrength.Text = row.Cells[5].Value.ToString();
            txtQntyS.Text = row.Cells[6].Value.ToString();
            txtQntyP.Text = row.Cells[7].Value.ToString();
            txtPrice.Text = row.Cells[8].Value.ToString();
            txtSTotal.Text = row.Cells[9].Value.ToString();
            txt.Text = row.Cells[10].Value.ToString();
            if (txt.Text != "")
            {
                int a = Convert.ToInt32(txt.Text);
                int p = Convert.ToInt32(txtQntyP.Text);
                txtQntyR.Text = (a + p).ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataGridView1.Hide();
            pnInscription.Show();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select Category,PName AS Product_Name,Inscription from tblProducts";
                command.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(command);
                table = new DataTable();
                da.Fill(table);
                dpt.DataSource = table;
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
            DataView dv = new DataView(table);
            dv.RowFilter = string.Format("Inscription LIKE '%{0}%'", txtFirst.Text);
            dpt.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnInscription.Hide();
            DataGridView1.Show();
        }
    }
}

