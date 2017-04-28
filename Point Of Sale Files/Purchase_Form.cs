using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Pharmacy_System.Point_Of_Sale_Files
{
    public partial class Purchase_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");

        public Purchase_Form()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtTotal.Clear();
            txtTotal1.Clear();
            txtTotal2.Clear();
            txtUp1.Clear();
            txtUp2.Clear();
            txtID.Clear();
            txtDosage.Clear();
            txtStrength.Clear();
            txtSupplier.Clear();
            txtCash.Clear();
            cboCategory.Text = "<--Category-->";
            cboPurType.SelectedIndex = 0;
            metroCheckBox1.Checked = false;
            txtName.Clear();
            DoP.Value = DateTime.Today;
            DoE.Value = DateTime.Today;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Purchase_Form_Load(object sender, EventArgs e)
        {
            lbl.Hide();
           // cboCategory.SelectedIndex = 0;
           // cboPurType.SelectedIndex = 0;
            lblTime.Text = DateTime.Now.ToShortTimeString();
            txtTotal1.Hide();
            txtTotal2.Hide();
            txtUp2.Hide();
            txtUp1.Hide();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            FillDataGride();
            getNo();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblCategories ", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cboCategory.Items.Add(read["Category"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblProducts ", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    col.Add(read["Category"].ToString());
                    cboCategory.AutoCompleteCustomSource = col;
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand comman = new SqlCommand();
                comman.CommandText = "select * from tblSupplier";
                comman.Connection = con;
                SqlDataReader rder = comman.ExecuteReader();
                while (rder.Read())
                {
                    cols.Add(rder["SName"].ToString());
                    txtSupplier.AutoCompleteCustomSource = cols;
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void cboCategory_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "'", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cols.Add(read["PName"].ToString());
                    txtName.AutoCompleteCustomSource = cols;
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [PID] FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "'", con);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["PID"].ToString());
                        txtID.AutoCompleteCustomSource = col;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void Purchase_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
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
        void FillDataGride()
        {
            getNo();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select [Category],[PName],[PID],[Strength],[Dosage] ,[Manufacturer],[Cost],[PurchaseType],[PTotal],[DoE],[DoT] from tblPurchases where DoT='" + DoT.Text + "'", con);
                DataTable dt = new DataTable();
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            DateTime td = DoT.Value;
            DateTime ep = DoE.Value;
            TimeSpan ts = ep - td;
            double days = ts.TotalDays;

            if (txtName.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Name", MessageBoxIcon.Error.ToString());
                txtName.Focus();
            }
            else if (cboCategory.Text == "<--Category-->" | cboCategory.Text == "")
            {
                MessageBox.Show("Kindly Select The Products' Category", MessageBoxIcon.Error.ToString());
                cboCategory.Focus();
            }
            else if (txtSupplier.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Manufacturer", MessageBoxIcon.Error.ToString());
                txtSupplier.Focus();
            }
            else if (txtCash.Text == "")
            {
                MessageBox.Show("Kindly Enter The Product purchase Amount", MessageBoxIcon.Error.ToString());
                txtCash.Focus();
            }
            else if (days < 354)
            {
                MessageBox.Show("The Expiry Date Is Today, Change It Or The Products Has Expired", "Pharmacy System");
                DoE.Focus();
            }
            else
            {
                int result1 = 0;
                int.TryParse(txtTotal.Text, out result1);
                int result2 = 0;
                int.TryParse(txtTotal1.Text, out result2);
                txtTotal2.Text = (result1 + result2).ToString();
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "' and DoT='" + DoT.Text + "'", con);
                    SqlDataReader rd = command.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count < 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[tblPurchases] ([Category],[PName],[PID],[Strength],[Dosage] ,[Manufacturer],[Cost],[PurchaseType],[PTotal],[DoE],[DoT]) VALUES ('" + cboCategory.Text + "','" + txtName.Text + "','" + txtID.Text + "','" + txtStrength.Text + "','" + txtDosage.Text + "','" + txtSupplier.Text + "','" + txtCash.Text + "','" + cboPurType.Text + "','" + txtTotal.Text + "','" + DoE.Text + "','" + DoT.Text + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Product Is Already Saved", "Pharmacy System");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

                try
                {
                    con.Open();
                    SqlCommand comd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                    SqlDataReader rd = comd.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand md = new SqlCommand("update tblTotal set PTotal='" + txtTotal2.Text + "' where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                            md.ExecuteNonQuery();
                            MessageBox.Show("Product Updated Successfully", "Pharmacy System");
                            con.Close();
                            FillDataGride();
                            getNo();
                            clear();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into tblTotal (Category,Name,PID,Strength,Dosage,PTotal) values ('" + cboCategory.Text + "','" + txtName.Text + "','" + txtID.Text + "','" + txtStrength.Text + "','" + txtDosage.Text + "','" + txtTotal.Text + "')", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product Added Successfully", "Pharmacy System");
                            con.Close();
                            FillDataGride();
                            getNo();
                            clear();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            //int result1 = 0;
            //int.TryParse(txtTotal.Text, out result1);
            //int result2 = 0;
            //int.TryParse(txtTotal1.Text, out result2);
            //txtTotal2.Text = (result1 + result2).ToString();
        }

        private void txtDosage_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [Strength] FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "'", con);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["Strength"].ToString());
                        txtStrength.AutoCompleteCustomSource = col;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void txtStrength_Leave(object sender, EventArgs e)
        {
            if (txtDosage.Text != "" & txtStrength.Text != "" & txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select * from tblPurchases where DoT='" + DoT.Text + "' and Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                    SqlDataReader rd = command.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [PTotal] FROM[dbo].[tblTotal] where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                            SqlDataReader read = cmd.ExecuteReader();
                            while (read.Read())
                            {
                                txtTotal1.Text = read["PTotal"].ToString();

                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "' and DoT='" + DoT.Text + "'", con);
                            SqlDataReader read = cmd.ExecuteReader();
                            while (read.Read())
                            {
                                txtSupplier.Text = read["Manufacturer"].ToString();
                                txtCash.Text = read["Cost"].ToString();
                                cboPurType.Text = read["PurchaseType"].ToString();
                                DoE.Text = read["DoE"].ToString();
                                txtTotal.Text = read["PTotal"].ToString();
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        // clear();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            if (txtTotal.Text != "0")
            {
                int result1 = 0;
                int.TryParse(txtTotal.Text, out result1);
                int result2 = 0;
                int.TryParse(txtTotal1.Text, out result2);
                txtUp1.Text = (result2 - result1).ToString();
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand comd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "'", con);
                    SqlDataReader read = comd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["Dosage"].ToString());
                        txtDosage.AutoCompleteCustomSource = col;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else
            {
                con.Close();
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int.TryParse(txtTotal.Text, out result1);
            int result2 = 0;
            int.TryParse(txtTotal1.Text, out result2);
            txtTotal2.Text = (result1 + result2).ToString();
            DateTime td = DoT.Value;
            DateTime ep = DoE.Value;
            TimeSpan ts = ep - td;
            double days = ts.TotalDays;

            if (txtName.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Name", MessageBoxIcon.Error.ToString());
                txtName.Focus();
            }
            else if (cboCategory.Text == "<--Category-->" | cboCategory.Text == "")
            {
                MessageBox.Show("Kindly Select The Products' Category", MessageBoxIcon.Error.ToString());
                cboCategory.Focus();
            }
            else if (txtSupplier.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Manufacturer", MessageBoxIcon.Error.ToString());
                txtSupplier.Focus();
            }
            else if (txtCash.Text == "")
            {
                MessageBox.Show("Kindly Enter The Product purchase Amount", MessageBoxIcon.Error.ToString());
                txtCash.Focus();
            }
            else if (days < 354)
            {
                MessageBox.Show("The Expiry Date Is Today, Change It Or The Products Has Expired", "Pharmacy System");
                DoE.Focus();
            }
            else if (metroCheckBox1.Checked == false)
            {
                MessageBox.Show("Kindly Check The Update Quantity Box", "Pharmacy System");
                metroCheckBox1.Show();
                metroCheckBox1.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "' and DoT='" + DoT.Text + "'", con);
                    SqlDataReader rd = command.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("Update [dbo].[tblPurchases] set [Manufacturer]='" + txtSupplier.Text + "',[Cost]='" + txtCash.Text + "',[PurchaseType]='" + cboPurType.Text + "',[PTotal]='" + txtTotal.Text + "',[DoE]='" + DoE.Text + "' where [DoT]='" + DoT.Text + "' and Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Strength='" + txtStrength.Text + "' and Dosage='" + txtDosage.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Product Is Not Found In The Database", "Pharmacy System");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

                try
                {
                    con.Open();
                    SqlCommand comd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                    SqlDataReader rd = comd.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand md = new SqlCommand("update tblTotal set PTotal='" + txtUp2.Text + "' where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                            md.ExecuteNonQuery();
                            MessageBox.Show("Product Updated Successfully", "Pharmacy System");
                            con.Close();
                            FillDataGride();
                            getNo();
                            clear();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("There Was An Error While Updating The Product Try Saving It First", "Pharmacy System");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DateTime td = DoT.Value;
            DateTime ep = DoE.Value;
            TimeSpan ts = ep - td;
            double days = ts.TotalDays;

            if (txtName.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Name", MessageBoxIcon.Error.ToString());
                txtName.Focus();
            }
            else if (cboCategory.Text == "<--Category-->" | cboCategory.Text == "")
            {
                MessageBox.Show("Kindly Select The Products' Category", MessageBoxIcon.Error.ToString());
                cboCategory.Focus();
            }
            else if (txtSupplier.Text == "")
            {
                MessageBox.Show("Kindly Enter The Products' Manufacturer", MessageBoxIcon.Error.ToString());
                txtSupplier.Focus();
            }
            else if (txtCash.Text == "")
            {
                MessageBox.Show("Kindly Enter The Product purchase Amount", MessageBoxIcon.Error.ToString());
                txtCash.Focus();
            }
            else if (days < 354)
            {
                MessageBox.Show("The Expiry Date Is Today, Change It Or The Products Has Expired", "Pharmacy System");
                DoE.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "' and DoT='" + DoT.Text + "'", con);
                    SqlDataReader rd = command.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("delete from [dbo].[tblPurchases]  where [DoT]='" + DoT.Text + "' and Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Strength='" + txtStrength.Text + "' and Dosage='" + txtDosage.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Product Is Not Found In The Database", "Pharmacy System");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

                try
                {
                    con.Open();
                    SqlCommand comd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                    SqlDataReader rd = comd.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        if (int.Parse(txtUp1.Text) <= int.Parse(txtTotal1.Text))
                        {
                            try
                            {
                                con.Open();
                                SqlCommand md = new SqlCommand("delete from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                                md.ExecuteNonQuery();
                                MessageBox.Show("Product Deleted Successfully", "Pharmacy System");
                                con.Close();
                                FillDataGride();
                                getNo();
                                clear();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        }
                        else
                        {
                            try
                            {
                                con.Open();
                                SqlCommand md = new SqlCommand("update tblTotal set PTotal='" + txtUp1.Text + "' where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                                md.ExecuteNonQuery();
                                MessageBox.Show("Product Deleted Successfully", "Pharmacy System");
                                con.Close();
                                FillDataGride();
                                getNo();
                                clear();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                                con.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("There Was An Error While Deleting The Product,Possible Because It Is Not Saved", "Pharmacy System");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                int result1 = 0;
                int.TryParse(txtTotal.Text, out result1);
                int result2 = 0;
                int.TryParse(txtUp1.Text, out result2);
                txtUp2.Text = (result2 + result1).ToString();
            }
        }
        public void supplier(int x)
        {
            lbl.Text = x.ToString();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    cboCategory.Text = row.Cells["Category"].Value.ToString();
            //    txtName.Text = row.Cells["PName"].Value.ToString();
            //    txtID.Text = row.Cells["PID"].Value.ToString();
            //    txtStrength.Text = row.Cells["Strength"].Value.ToString();
            //    txtDosage.Text = row.Cells["Dosage"].Value.ToString();
            //}
        }


        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Form cf = new Category_Form();
            cf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate1.PerformClick();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void txtStrength_TextChanged(object sender, EventArgs e)
        {
            if (txtDosage.Text != "" & txtStrength.Text != "" & txtID.Text != "" & txtName.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("select * from tblPurchases where DoT='" + DoT.Text + "' and Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                    SqlDataReader rd = command.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT [PTotal] FROM[dbo].[tblTotal] where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", con);
                            SqlDataReader read = cmd.ExecuteReader();
                            while (read.Read())
                            {
                                txtTotal1.Text = read["PTotal"].ToString();

                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("select * from tblPurchases where Category='" + cboCategory.Text + "' and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "' and DoT='" + DoT.Text + "'", con);
                            SqlDataReader read = cmd.ExecuteReader();
                            while (read.Read())
                            {
                                txtSupplier.Text = read["Manufacturer"].ToString();
                                txtCash.Text = read["Cost"].ToString();
                                cboPurType.Text = read["PurchaseType"].ToString();
                                DoE.Text = read["DoE"].ToString();
                                txtTotal.Text = read["PTotal"].ToString();
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            con.Close();
                        }
                    }
                    else
                    {
                        clear();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            if (txtTotal.Text != "0")
            {
                int result1 = 0;
                int.TryParse(txtTotal.Text, out result1);
                int result2 = 0;
                int.TryParse(txtTotal1.Text, out result2);
                txtUp1.Text = (result2 - result1).ToString();
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void DoT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_Leave(object sender, EventArgs e)
        {
            if (txtSupplier.Text == "")
            {
                MessageBox.Show("Supplier Name Missing", "Pharmacy System");
                txtSupplier.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select SName from tblSupplier where SName='" + txtSupplier.Text + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count >= 1)
                    {
                        supplier(1);
                    }
                    else
                    {
                        supplier(0);
                        DialogResult dia = MessageBox.Show("The Supplier with the supplied name is not in the database, do you wish to save?", "Pharmacy System", MessageBoxButtons.YesNo);
                        if (dia == DialogResult.Yes)
                        {
                            Supplier_Form sp = new Supplier_Form();
                            sp.ShowDialog();
                        }
                        else if (dia == DialogResult.No)
                        {
                            MessageBox.Show("Kindly Correct The Name Before Proceding", "Pharmacy System");

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
