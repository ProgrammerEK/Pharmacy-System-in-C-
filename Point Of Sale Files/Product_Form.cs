using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Pharmacy_System.Point_Of_Sale_Files
{
    public partial class Product_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        int selectedRow;
        public Product_Form()
        {
            InitializeComponent();
        }
        void clear()
        {

            cboCategory.Items.Clear();
            cboCategory.Text = "<--Select Option-->";
            txtNewPro.Clear();
            txtID.Clear();
            txtAlert.Clear();
            txtSellingQnty.Clear();
            txtPrice.Clear();
            txtDisc.Clear();
            rtxt.Clear();
            txtDosage.Clear();
            txtStrength.Clear();
        }
        void GetData()
        {
            try
            {
                connection.Open();
                SqlCommand commd = new SqlCommand("select * from tblProducts", connection);
                SqlDataAdapter da = new SqlDataAdapter(commd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                connection.Open();
                SqlCommand commando = new SqlCommand();
                commando.CommandText = "select * from tblCategories";
                commando.Connection = connection;
                SqlDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    cboCategory.Items.Add(reader["Category"].ToString());
                    col.Add(reader["Category"].ToString());
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
        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (cboCategory.Text == "" | cboCategory.Text == "<--Category-->")
            {
                MessageBox.Show("Kindly Select The Product's Category", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's ID", "Pharmacy System");
                txtID.Focus();
            }
            else if (txtAlert.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Alert Quantity", "Pharmacy System");
                txtAlert.Focus();
            }
            else if (txtSellingQnty.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Selling Quantity", "Pharmacy System");
                txtSellingQnty.Focus();
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Price", "Pharmacy System");
                txtPrice.Focus();
            }
            else if (txtDosage.Text == "")
            {
                MessageBox.Show("Kindly Type In The Drug's Dosage", "Pharmacy System");
                txtDosage.Focus();
            }
            else if (txtStrength.Text == "")
            {
                MessageBox.Show("Kindly Type In The Producct's Concentration/Strength", "Pharmacy System");
                txtStrength.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select Category from tblCategories where Category='" + cboCategory.Text + "'", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count == 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("select Category,PName from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "'and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                            SqlDataReader read = comd.ExecuteReader();
                            int Esabu = 0;
                            while (read.Read())
                            {
                                Esabu++;
                            }
                            connection.Close();
                            if (Esabu < 1)
                            {
                                connection.Open();
                                SqlCommand camd = new SqlCommand("insert into tblProducts ([Category],[PName],[PID] ,[AlertQnty],[SellingQnty],[Price],[Discount],[Inscription],[Strength],[Dosage]) values ('" + cboCategory.Text + "','" + txtNewPro.Text + "','" + txtID.Text + "','" + txtAlert.Text + "','" + txtSellingQnty.Text + "','" + txtPrice.Text + "','" + txtDisc.Text + "','" + rtxt.Text + "','" + txtStrength.Text + "','" + txtDosage.Text + "')", connection);
                                camd.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("New Producy Added Successfully", "Pharmacy System");
                                clear();
                                GetData();
                                getNo();
                            }
                            else
                            {
                                MessageBox.Show("Product Already Saved In The System", "Pharmacy System");

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
                        MessageBox.Show("The Category Typed Is Not In The Database,Kindly Check It First", "Pharmacy System");
                        cboCategory.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex = 0;
            GetData();
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
        private void cboCategory_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                connection.Open();
                SqlCommand commando = new SqlCommand();
                commando.CommandText = "select * from tblProducts where Category='" + cboCategory.Text + "'";
                commando.Connection = connection;
                SqlDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    cols.Add(reader["PName"].ToString());
                    txtNewPro.AutoCompleteCustomSource = cols;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void txtNewPro_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select PID from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "'", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    col.Add(rd["PID"].ToString());
                    txtID.AutoCompleteCustomSource = col;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's ID", "Pharmacy System");
                txtID.Focus();
            }
            else if (cboCategory.Text == "" | cboCategory.Text == "<--Category-->")
            {
                MessageBox.Show("Kindly Select The Product's Category", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtAlert.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Alert Quantity", "Pharmacy System");
                txtAlert.Focus();
            }
            else if (txtSellingQnty.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Selling Quantity", "Pharmacy System");
                txtSellingQnty.Focus();
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Price", "Pharmacy System");
                txtPrice.Focus();
            }
            else if (txtDosage.Text == "")
            {
                MessageBox.Show("Kindly Type In The Drug's Dosage", "Pharmacy System");
                txtDosage.Focus();
            }
            else if (txtStrength.Text == "")
            {
                MessageBox.Show("Kindly Type In The Producct's Concentration/Strength", "Pharmacy System");
                txtStrength.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblCategories where Category='" + cboCategory.Text + "'", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count >= 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "'and PID='" + txtID.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                            SqlDataReader read = comd.ExecuteReader();
                            int Esabu = 0;
                            while (read.Read())
                            {
                                Esabu++;
                            }
                            connection.Close();
                            if (Esabu == 1)
                            {
                                connection.Open();
                                SqlCommand camd = new SqlCommand("UPDATE[dbo].[tblProducts] SET[AlertQnty] = '" + txtAlert.Text + "',[SellingQnty] = '" + txtSellingQnty.Text + "',[Price] = '" + txtPrice.Text + "',[Discount] = '" + txtDisc.Text + "',[Inscription] = '" + rtxt.Text + "' where Category = '" + cboCategory.Text + "' and PName = '" + txtNewPro.Text + "' and[PID] = '" + txtID.Text + "' and[Dosage] = '" + txtDosage.Text + "' and[Strength] = '" + txtStrength.Text + "'", connection);
                                camd.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Producy Updated Successfully", "Pharmacy System");
                                clear();
                                GetData();
                                getNo();
                            }
                            else
                            {
                                MessageBox.Show("Product Is Not In The System", "Pharmacy System");
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
                        MessageBox.Show("The Product Category Is Not Available", "Pharmacy System");
                        cboCategory.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's ID", "Pharmacy System");
                txtID.Focus();
            }
            else if (cboCategory.Text == "" | cboCategory.Text == "<--Category-->")
            {
                MessageBox.Show("Kindly Select The Product's Category", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtAlert.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Alert Quantity", "Pharmacy System");
                txtAlert.Focus();
            }
            else if (txtSellingQnty.Text == "")
            {
                MessageBox.Show("Kindly Type In The Products's Selling Quantity", "Pharmacy System");
                txtSellingQnty.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand comd = new SqlCommand("select * from tblProducts where [PID]='" + txtID.Text + "' and PName='" + txtNewPro.Text + "' and Category='" + cboCategory.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                    SqlDataReader rd = comd.ExecuteReader();
                    int cn = 0;
                    while (rd.Read())
                    {
                        cn++;
                    }
                    connection.Close();
                    if (cn == 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand();
                            command.CommandText = "delete from [dbo].[tblProducts]  where [PID]='" + txtID.Text + "' and PName='" + txtNewPro.Text + "' and Category='" + cboCategory.Text + "' and Dosage='" + txtDosage.Text + "' and Strength='" + txtStrength.Text + "'";
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("The Product Succesfully Deleted", "Pharmacy System");
                            clear();
                            GetData();
                            getNo();
                        }
                        catch (Exception exs)
                        {

                            MessageBox.Show(exs.Message);
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Product's Name Not Saved In The Database", "Pharmacy System");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtNewPro.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    connection.Open();
                    SqlCommand comd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "' and PID='" + txtID.Text + "'", connection);
                    SqlDataReader read = comd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["Dosage"].ToString());
                        txtDosage.AutoCompleteCustomSource = col;
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
                connection.Close();
            }
        }

        private void txtStrength_Leave(object sender, EventArgs e)
        {
            if (txtNewPro.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0) & txtID.Text != "" & txtStrength.Text != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "' and PID='" + txtID.Text + "' and Strength='" + txtStrength.Text + "'";
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count == 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("SELECT * FROM[dbo].[tblProducts] where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "' and PID='" + txtID.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                            SqlDataReader read = comd.ExecuteReader();
                            while (read.Read())
                            {
                                txtAlert.Text = read["AlertQnty"].ToString();
                                txtSellingQnty.Text = read["SellingQnty"].ToString();
                                txtPrice.Text = read["Price"].ToString();
                                txtDisc.Text = read["Discount"].ToString();
                                rtxt.Text = read["Inscription"].ToString();
                            }
                            connection.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                            connection.Close();
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

        private void txtDosage_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtNewPro.Text != "" & (cboCategory.Text != "" | cboCategory.SelectedIndex != 0))
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    connection.Open();
                    SqlCommand comd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PName='" + txtNewPro.Text + "' and PID='" + txtID.Text + "'", connection);
                    SqlDataReader read = comd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["Strength"].ToString());
                        txtStrength.AutoCompleteCustomSource = col;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0 | cboCategory.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly Enter The Or Select Category You Want To Update From", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtNewPro.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly Enter The New Product's Name You Want To Update", "Pharmacy System");
                txtNewPro.Focus();
            }
            else if (txtID.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Kindly Enter The Products ID Of The Products You Want To Update", "Pharmacy System");
                txtID.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PID='" + txtID.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count == 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("update tblProducts set PName='" + txtNewPro.Text + "' where Category='" + cboCategory.Text + "' and PID='" + txtID.Text + "'", connection);
                            comd.ExecuteNonQuery();
                            connection.Close();
                            MetroFramework.MetroMessageBox.Show(this, "Product's Name Updated Successfully", "Pharmacy System");
                            clear();
                            GetData();
                            getNo();
                        }
                        catch (Exception ex)
                        {

                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Pharmacy System");
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Pharmacy System");
                    connection.Close();
                }
            }
        }

        private void dosageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0 | cboCategory.Text == "")
            {
                MessageBox.Show(this, "Kindly Enter The Or Select Category You Want To Update From", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtNewPro.Text == "")
            {
                MessageBox.Show(this, "Kindly Enter The New Product's Name You Want To Update", "Pharmacy System");
                txtNewPro.Focus();
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show(this, "Kindly Enter The Products ID Of The Products You Want To Update", "Pharmacy System");
                txtID.Focus();
            }
            else if (txtDosage.Text == "")
            {
                MessageBox.Show(this, "Kindly Enter The Products Dosage Of The Products You Want To Update", "Pharmacy System");
                txtDosage.Focus();
            }
            else if (txtStrength.Text == "")
            {
                MessageBox.Show(this, "Kindly Enter The Products Strength/Concentration Of The Products You Want To Update", "Pharmacy System");
                txtStrength.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblProducts where Category='" + cboCategory.Text + "' and PID='" + txtID.Text + "' and PName='" + txtNewPro.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count == 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("update tblProducts set Dosage='" + txtDosage.Text + "' where Category='" + cboCategory.Text + "' and PID='" + txtID.Text + "' and PName='" + txtNewPro.Text + "' and Strength='" + txtStrength.Text + "'", connection);
                            comd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show(this, "Product's Name Updated Successfully", "Pharmacy System");
                            clear();
                            GetData();
                            getNo();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Pharmacy System");
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Pharmacy System");
                    connection.Close();
                }
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Form ct = new Category_Form();
            ct.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inShopShelvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Other_Files.ShopStore_Form sh = new Other_Files.ShopStore_Form();
            sh.Show();
        }

        private void inStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Form ct = new Category_Form();
            ct.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form lg = new Main_User_Files.Admin_Form();
            lg.ShowDialog();
        }

        private void Product_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form lg = new Main_User_Files.Admin_Form();
            lg.ShowDialog();
        }

        private void lblSup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Supplier_Form sp = new Supplier_Form();
            sp.ShowDialog();
        }

        private void txtSupplier_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            cboCategory.Text = row.Cells[1].Value.ToString();
            txtNewPro.Text = row.Cells[2].Value.ToString();
            txtID.Text = row.Cells[3].Value.ToString();
            txtDosage.Text = row.Cells[4].Value.ToString();
            txtStrength.Text = row.Cells[5].Value.ToString();
            txtAlert.Text = row.Cells[6].Value.ToString();
            txtSellingQnty.Text = row.Cells[7].Value.ToString();
            txtPrice.Text = row.Cells[8].Value.ToString();
            txtDisc.Text = row.Cells[9].Value.ToString();
            rtxt.Text = row.Cells[10].Value.ToString();

        }
    }
}
