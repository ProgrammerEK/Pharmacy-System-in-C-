using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_System.Other_Files
{
    public partial class AddToShop_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        public AddToShop_Form()
        {
            InitializeComponent();
        }
        void fill()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Category,PName AS Name,PID AS Product_ID,Dosage AS Dosage_Form,Strength,Amount AS Quantity from tblShopStore", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        public void rank(int x)
        {
            lblRank.Text = x.ToString();
        }
        private void AddToShop_Form_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            lblRank.Hide();
            fill();
            cboCategory.SelectedIndex = 0;
            cboDosage.SelectedIndex = 0;
            cboStrength.SelectedIndex = 0;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblTotal", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    col.Add(rd["Category"].ToString());
                    cboCategory.AutoCompleteCustomSource = col;
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
                SqlCommand cmd = new SqlCommand("select DISTINCT Category from tblTotal", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboCategory.Items.Add(rd["Category"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        void clear()
        {
            txtQntyA.Clear();
            txtID.Clear();
            cboDosage.SelectedIndex = 0;
            cboStrength.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            txtAmount.Clear();
            txtName.Clear();
            textBox1.Clear();
        }
        private void cboCategory_Leave(object sender, EventArgs e)
        {
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cols.Add(rd["PName"].ToString());
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
        void upTable()
        {
            try
            {
                con.Open();
                SqlCommand md = new SqlCommand("update tblTotal set PTotal='" + textBox2.Text + "' where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + cboDosage.Text + "' and Strength='" + cboStrength.Text + "'", con);
                md.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully", "Pharmacy System");
                con.Close();
                fill();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int.TryParse(txtQntyA.Text, out result1);
            int result2 = 0;
            int.TryParse(txtAmount.Text, out result2);
            textBox2.Text = (result1 - result2).ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblShopStore where Category='" + cboCategory.Text + "'and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Strength='" + cboStrength.Text + "' and Dosage='" + cboDosage.Text + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
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
                        SqlCommand comd = new SqlCommand("insert into tblShopStore ([Category],[PName],[PID],[Dosage],[Strength],[Amount]) values ('" + cboCategory.Text + "','" + txtName.Text + "','" + txtID.Text + "','" + cboDosage.Text + "','" + cboStrength.Text + "','" + txtAmount.Text + "')", con);
                        comd.ExecuteNonQuery();
                        MessageBox.Show("Products Added To The Shop Store", "Pharmacy System");
                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    upTable();
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmmd = new SqlCommand("update tblShopStore set [Amount]='" + txtAmount.Text + "' Category='" + cboCategory.Text + "'and PName='" + txtName.Text + "' and PID='" + txtID.Text + "' and Strength='" + cboStrength.Text + "' and Dosage='" + cboDosage.Text + "'", con);
                        cmmd.ExecuteNonQuery();
                        MessageBox.Show("Products Updated To The Shop Store", "Pharmacy System");
                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    upTable();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (cboCategory.Text == "" | cboCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly Select A Valid Category", "Pharmacy System");
                cboCategory.Focus();
            }
            else if (txtName.Text == "")
            {
                txtAmount.Clear();
                textBox1.Clear();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand comd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "'", con);
                    SqlDataReader rd = comd.ExecuteReader();
                    int count = 0;
                    while (rd.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count >= 1)
                    {
                        AutoCompleteStringCollection COLS = new AutoCompleteStringCollection();
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("select PID from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' ", con);
                            SqlDataReader rod = cmd.ExecuteReader();
                            while (rod.Read())
                            {
                                COLS.Add(rod["PID"].ToString());
                                txtID.AutoCompleteCustomSource = COLS;
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
                        MessageBox.Show("The Product Name Is Not Valid", "Pharmacy System");
                        txtName.Focus();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty & txtName.Text != string.Empty & (cboCategory.Text != string.Empty | cboCategory.SelectedText == "<--Category-->"))
            {
                AutoCompleteStringCollection COLS = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select DISTINCT Dosage from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "'", con);
                    SqlDataReader rod = cmd.ExecuteReader();
                    while (rod.Read())
                    {
                        COLS.Add(rod["Dosage"].ToString());
                        cboDosage.AutoCompleteCustomSource = COLS;
                        cboDosage.Items.Add(rod["Dosage"].ToString());
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

        private void cboDosage_Leave(object sender, EventArgs e)
        {
            if ((cboDosage.Text != string.Empty | cboDosage.SelectedText != "<--Dosage-->") & txtID.Text != string.Empty & txtName.Text != string.Empty & (cboCategory.Text != string.Empty | cboCategory.SelectedText != "<--Category-->"))
            {
                AutoCompleteStringCollection COLS = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Strength from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + cboDosage.Text + "'", con);
                    SqlDataReader rod = cmd.ExecuteReader();
                    while (rod.Read())
                    {
                        COLS.Add(rod["Strength"].ToString());
                        cboStrength.AutoCompleteCustomSource = COLS;
                        cboStrength.Items.Add(rod["Strength"].ToString());
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

        private void cboStrength_Leave(object sender, EventArgs e)
        {
            if ((cboStrength.Text != string.Empty | cboStrength.SelectedText != "<--Dosage-->") & (cboDosage.Text != string.Empty | cboDosage.SelectedText != "<--Dosage-->") & txtID.Text != string.Empty & txtName.Text != string.Empty & (cboCategory.Text != string.Empty | cboCategory.SelectedText != "<--Category-->"))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select PTotal from tblTotal where Category='" + cboCategory.Text + "' and Name='" + txtName.Text + "' and PID='" + txtID.Text + "' and Dosage='" + cboDosage.Text + "' and Strength='" + cboStrength.Text + "'", con);
                    SqlDataReader rod = cmd.ExecuteReader();
                    while (rod.Read())
                    {

                        txtQntyA.Text = rod["PTotal"].ToString();
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

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                if (Convert.ToInt32(txtAmount.Text) > Convert.ToInt32(txtQntyA.Text))
                {
                    MessageBox.Show("The Amount Is More Than What Is Available", "Pharmacy System");
                    txtAmount.Focus();
                }
            }

        }

        private void cboCategory_Leave_1(object sender, EventArgs e)
        {
            if (cboCategory.Text != string.Empty | cboCategory.SelectedIndex >= 1)
            {
                AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblTotal where Category='" + cboCategory.Text + "'", con);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        cols.Add(read["Name"].ToString());
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
        }

        private void AddToShop_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lblRank.Text == "2")
            {
                this.Hide();
                Main_User_Files.Cushier_Form ch = new Main_User_Files.Cushier_Form();
                ch.ShowDialog();
            }
            else
            {
                this.Hide();
                Point_Of_Sale_Files.Selling_Form sf = new Point_Of_Sale_Files.Selling_Form();
                sf.ShowDialog();
            }

        }
    }
}
