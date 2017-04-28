using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Supplier_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        public Supplier_Form()
        {

            InitializeComponent();
        }
        void clear()
        {
            txtName.Clear();
            txtCell.Clear();
            txtCell2.Clear();
            rtxLocation.Clear();
            txtEmail.Clear();
        }
        public void getData()
        {
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from tblSupplier", connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cols.Add(rd["SName"].ToString());
                    txtName.AutoCompleteCustomSource = cols;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("The Supplier's Name Missing", "Pharmacy System");
                txtName.Focus();
            }
            else if (txtCell.Text == "" & txtCell2.Text == "")
            {
                MessageBox.Show("Supplier's Contact Information Missing", "Pharmacy System");
                txtCell.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Supplier's Email Address Missing", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (rtxLocation.Text == "")
            {
                MessageBox.Show("Supplier's Physical Address Missing", "Pharmacy System");
                rtxLocation.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblSupplier where SName='" + txtName.Text + "' and Email='" + txtEmail.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count >= 1)
                    {
                        MessageBox.Show("Supplier with same information is already saved", "Pharmacy System");
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("insert into tblSupplier values ('" + txtName.Text + "','" + txtCell.Text + "','" + txtCell2.Text + "','" + txtEmail.Text + "','" + rtxLocation.Text + "')", connection);
                            comd.ExecuteNonQuery();
                            MessageBox.Show("Supplier Information Saved", "Pharmacy System");
                            clear();
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

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand comd = new SqlCommand("Select * from tblSupplier where SName='" + txtName.Text + "'", connection);
                    SqlDataReader rod = comd.ExecuteReader();
                    int count = 0;
                    while (rod.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count >= 1)
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand cmod = new SqlCommand("Select * from tblSupplier", connection);
                            SqlDataReader rdo = cmod.ExecuteReader();
                            while (rdo.Read())
                            {
                                txtCell.Text = rdo["Cell"].ToString();
                                txtCell2.Text = rdo["Cell1"].ToString();
                                txtEmail.Text = rdo["Email"].ToString();
                                rtxLocation.Text = rdo["Location"].ToString();
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

        private void Supplier_Form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("The Supplier's Name Missing", "Pharmacy System");
                txtName.Focus();
            }
            else if (txtCell.Text == "" & txtCell2.Text == "")
            {
                MessageBox.Show("Supplier's Contact Information Missing", "Pharmacy System");
                txtCell.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Supplier's Email Address Missing", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (rtxLocation.Text == "")
            {
                MessageBox.Show("Supplier's Physical Address Missing", "Pharmacy System");
                rtxLocation.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblSupplier where SName='" + txtName.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count < 1)
                    {
                        MessageBox.Show("Supplier with the information is not found in the database", "Pharmacy System");
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("update tblSupplier set Cell='" + txtCell.Text + "',Cell1='" + txtCell2.Text + "',Email='" + txtEmail.Text + "',Location='" + rtxLocation.Text + "' where SName='" + txtName.Text + "'", connection);
                            comd.ExecuteNonQuery();
                            MessageBox.Show("Supplier Information Updated", "Pharmacy System");
                            clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("The Supplier's Name Missing", "Pharmacy System");
                txtName.Focus();
            }
            else if (txtCell.Text == "" & txtCell2.Text == "")
            {
                MessageBox.Show("Supplier's Contact Information Missing", "Pharmacy System");
                txtCell.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Supplier's Email Address Missing", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (rtxLocation.Text == "")
            {
                MessageBox.Show("Supplier's Physical Address Missing", "Pharmacy System");
                rtxLocation.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblSupplier where SName='" + txtName.Text + "'", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count < 1)
                    {
                        MessageBox.Show("Supplier with the information is not found in the database", "Pharmacy System");
                    }
                    else
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand comd = new SqlCommand("delete from tblSupplier  where SName='" + txtName.Text + "'", connection);
                            comd.ExecuteNonQuery();
                            MessageBox.Show("Supplier Information Deleted", "Pharmacy System");
                            clear();
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

        private void Supplier_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Point_Of_Sale_Files.Purchase_Form pt = new Point_Of_Sale_Files.Purchase_Form();
            pt.supplier(1);
        }
    }
}
