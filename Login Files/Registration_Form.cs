using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_System.Login_Files
{
    public partial class Registration_Form : MetroFramework.Forms.MetroForm
    {
        string gender;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        public Registration_Form()
        {
            InitializeComponent();
        }
        // Searching image code
        //private void btnPicture_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dig = new OpenFileDialog();
        //    dig.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
        //    dig.Title = "Select Product Image";
        //    if (dig.ShowDialog() == DialogResult.OK)
        //    {
        //        string location = dig.FileName.ToString();
        //        pictureBox1.ImageLocation = location;
        //    }
        //}

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            DoT.Hide();
            cboJob.SelectedIndex = 0;
            cboQuestion.SelectedIndex = 0;
            AutoCompleteStringCollection cols = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblUsers ", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cols.Add(read["First_Name"].ToString());
                    cols.Add(read["Last_Name"].ToString());
                    txtFirst.AutoCompleteCustomSource = cols;
                    txtLast.AutoCompleteCustomSource = cols;
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        public void clear()
        {
            rbMale.Checked = false;
            rbFemale.Checked = false;
            doe.Value = DateTime.Today;
            dob.Value = DateTime.Today;
            cboQuestion.SelectedIndex = 0;
            cboJob.SelectedIndex = 0;
            txtPassword.Clear();
            txtPassword1.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtAnswer.Clear();
            txtAddress.Clear();
            txtContact.Clear();

        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            if (txtLast.Text != "" & txtFirst.Text != "")
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblUsers where First_Name='" + txtFirst.Text + "' and Last_Name='" + txtLast.Text + "'", con);
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count < 1)
                    {
                        clear();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        cboQuestion.Show();
                        txtPassword.Show();
                        txtPassword1.Show();
                        txtAnswer.Show();
                        txtUserName.Show();
                        lblAnsw.Show();
                        lblPass.Show();
                        lblPass1.Show();
                        lblQuiz.Show();
                        lblUser.Show();
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            SqlCommand comd = new SqlCommand("select * from tblUsers where First_Name='" + txtFirst.Text + "' and Last_Name='" + txtLast.Text + "' ", con);
                            SqlDataReader reader = comd.ExecuteReader();
                            while (reader.Read())
                            {
                                txtUserName.Text = reader["UserName"].ToString();
                                txtContact.Text = reader["Contact"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                gender = reader["Gender"].ToString();
                                dob.Text = reader["DoB"].ToString();
                                doe.Text = reader["DoE"].ToString();
                                cboJob.SelectedItem = reader["JobTitle"].ToString();
                            }
                            cboQuestion.Hide();
                            txtPassword.Hide();
                            txtPassword1.Hide();
                            txtAnswer.Hide();
                            txtUserName.Hide();
                            txtUserName.Hide();
                            lblUser.Hide();
                            lblQuiz.Hide();
                            lblPass1.Hide();
                            lblPass.Hide();
                            lblAnsw.Hide();
                            con.Close();
                            if (gender == "Male")
                            {
                                rbMale.Checked = true;
                            }
                            else
                            {
                                rbFemale.Checked = true;
                            }
                            btnUpdate.Enabled = true;
                            btnDelete.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "TextBox Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

            }

            else
            {
                clear();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }




        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPassword_Form rp = new ResetPassword_Form();
            rp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.ShowDialog();
        }

        private void Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnExit.PerformClick();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnView.PerformClick();
        }

        private void updateRcrdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void resetPswrdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReset.PerformClick();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete.PerformClick();
        }

        private void exitFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime td = DoT.Value;
            DateTime ed = doe.Value;
            DateTime pe = dob.Value;
            TimeSpan miaka = pe - td;
            TimeSpan kazi = ed - td;
            double age = miaka.TotalDays;
            double job = kazi.TotalDays;
            if (txtFirst.Text == "")
            {
                MessageBox.Show("Kindly Enter User's First Name");
                txtFirst.Focus();
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Last Name");
                txtLast.Focus();
            }
            else if (rbFemale.Checked == false & rbMale.Checked == false)
            {
                MessageBox.Show("Kindly Select User's Gender");
                rbMale.Focus();
            }
            else if (age >= 1)
            {
                MessageBox.Show("Kindly Select User's Date of Birth");
                dob.Focus();
            }
            else if (job < 1)
            {
                MessageBox.Show("Kindly Select User's Date of Employement");
                doe.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Email");
                txtEmail.Focus();
            }
            else if (!(txtEmail.Text.Contains("gmail.com") | txtEmail.Text.Contains("yahoo.com")))
            {
                MessageBox.Show("Kindly Enter A Valid Email Addresss e.g email@gmail.com or email@yahoo.com", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Address");
                txtAddress.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Contact");
                txtContact.Focus();
            }
            else if (cboJob.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly Select User's Job Category");
                cboJob.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Kindly Enter User's User Name");
                txtUserName.Focus();
            }
            else if (txtPassword.Text != txtPassword1.Text)
            {
                MessageBox.Show("Your Passwords Don't Match");
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from tblUsers where First_Name='" + txtFirst.Text + "' and Last_Name='" + txtLast.Text + "' and UserName='" + txtUserName.Text + "'";
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count < 1)
                    {

                        try

                        {
                            con.Open();
                            SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[tblUsers]
           ([First_Name],[Last_Name],[JobTitle],[UserName],[Password],[Gender],
[Address],[Contact],[RecoveryQ],[RecoveryA],[Email],[DoB],[DoE]) VALUES
('" + txtFirst.Text + "','" + txtLast.Text + "', '" + cboJob.Text + "', '" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + gender + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + cboQuestion.Text + "','" + txtAnswer.Text + "','" + txtEmail.Text + "','" + dob.Text + "','" + doe.Text + "')", con);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data Saved Successful");
                            con.Close();
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Data Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The User Already Exists In The System");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attempt Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    this.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "")
            {
                MessageBox.Show("Kindly Enter User's First Name");
                txtFirst.Focus();
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Last Name");
                txtLast.Focus();
            }
            else if (rbFemale.Checked == false & rbMale.Checked == false)
            {
                MessageBox.Show("Kindly Select User's Gender");
                rbMale.Focus();
            }
            else if (dob.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Kindly Select User's Date of Birth");
                dob.Focus();
            }
            else if (doe.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Kindly Select User's Date of Employement");
                doe.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Email");
                txtEmail.Focus();
            }
            else if (!(txtEmail.Text.Contains("gmail.com") | txtEmail.Text.Contains("yahoo.com")))
            {
                MessageBox.Show("Kindly Enter A Valid Email Addresss e.g email@gmail.com or email@yahoo.com", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Address");
                txtAddress.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Contact");
                txtContact.Focus();
            }
            else if (cboJob.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly Select User's Job Category");
                cboJob.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Kindly Enter User's User Name");
                txtUserName.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from tblUsers where First_Name='" + txtFirst.Text + "' and Last_Name='" + txtLast.Text + "' and UserName='" + txtUserName.Text + "'";
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {

                        try

                        {
                            con.Open();
                            SqlCommand command = new SqlCommand(@"delete from [dbo].[tblUsers]  where UserName='" + txtUserName.Text + "'", con);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data Deleted Successful", "Pharmacy System");
                            con.Close();
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Pharmacy System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The User Doesn't Exists In The System", "Pharmacy System");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attempt Data Deleting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == "")
            {
                MessageBox.Show("Kindly Enter User's First Name");
                txtFirst.Focus();
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Last Name");
                txtLast.Focus();
            }
            else if (rbFemale.Checked == false & rbMale.Checked == false)
            {
                MessageBox.Show("Kindly Select User's Gender");
                rbMale.Focus();
            }
            else if (dob.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Kindly Select User's Date of Birth");
                dob.Focus();
            }
            else if (doe.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Kindly Select User's Date of Employement");
                doe.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Email");
                txtEmail.Focus();
            }
            else if (!(txtEmail.Text.Contains("gmail.com") | txtEmail.Text.Contains("yahoo.com")))
            {
                MessageBox.Show("Kindly Enter A Valid Email Addresss e.g email@gmail.com or email@yahoo.com", "Pharmacy System");
                txtEmail.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Address");
                txtAddress.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Kindly Enter User's Contact");
                txtContact.Focus();
            }
            else if (cboJob.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly Select User's Job Category");
                cboJob.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Kindly Enter User's User Name");
                txtUserName.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from tblUsers where First_Name='" + txtFirst.Text + "' and Last_Name='" + txtLast.Text + "' and UserName='" + txtUserName.Text + "'";
                    SqlDataReader read = cmd.ExecuteReader();
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    con.Close();
                    if (count == 1)
                    {

                        try

                        {
                            con.Open();
                            SqlCommand command = new SqlCommand(@"update [dbo].[tblUsers] set [First_Name]='" + txtFirst.Text + "',[Last_Name]='" + txtLast.Text + "',[JobTitle]='" + cboJob.Text + "',[Address]= '" + txtAddress.Text + "',[Contact]='" + txtContact.Text + "',[Email]='" + txtEmail.Text + "' where UserName='" + txtUserName.Text + "'", con);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data Updated Successful", "Pharmacy System");
                            con.Close();
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Pharmacy System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The User Doesn't Exists In The System", "Pharmacy System");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attempt Data Updating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    this.Close();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUsers_Form vf = new ViewUsers_Form();
            vf.Show();
        }
    }
}
