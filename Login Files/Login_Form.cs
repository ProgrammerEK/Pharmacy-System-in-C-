using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Login_Form : MetroFramework.Forms.MetroForm
    {
        int attempts = 0;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        public Login_Form()
        {
            InitializeComponent();

        }
        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dia = MessageBox.Show("Do You Really Want To Close Shop?", "Pharmacy System", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dia == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            cboTitle.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboTitle.Text == "" | cboTitle.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly Select Your Job Title", "Pharmacy System");
                cboTitle.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Kindly Enter Your User Name", "Pharmacy System");
                txtUserName.Focus();
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Kindly Enter Your Password", "Pharmacy System");
                txtPass.Focus();
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand comd = new SqlCommand("select * from tblUsers where JobTitle='" + cboTitle.Text + "' and UserName='" + txtUserName.Text + "' and Password='" + txtPass.Text + "'", connection);
                    SqlDataReader reader = comd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                    }
                    connection.Close();
                    if (count == 1)
                    {
                        if (cboTitle.SelectedIndex == 1)
                        {
                            this.Hide();
                            Main_User_Files.Admin_Form AD = new Main_User_Files.Admin_Form();
                            AD.rank(1);
                            AD.Show();
                        }
                        else if (cboTitle.SelectedIndex == 2)
                        {
                            this.Hide();
                            Main_User_Files.Admin_Form AD = new Main_User_Files.Admin_Form();
                            AD.rank(2);
                            AD.Show();
                        }
                        else if (cboTitle.SelectedIndex == 3)
                        {
                            this.Hide();
                            Main_User_Files.Cushier_Form cf = new Main_User_Files.Cushier_Form();
                            cf.rank(0);
                            cf.ShowDialog();
                        }
                    }
                    else
                    {
                        attempts++;
                        if (attempts < 3)
                        {
                            MessageBox.Show("You You Have Entered Wrong Credentialsand Have Reached" + attempts + "The Application Will Close After 3 Attempts", "Pharmacy System");
                            cboTitle.Focus();
                        }
                        else if (attempts == 3)
                        {
                            MessageBox.Show("You Have Reached Your Maximum Login Attempts of 3, Additional Login Failure Will Result To Being Denied Access To The System", "Pharmacy System");
                            cboTitle.Focus();
                        }
                        else if (attempts == 4)
                        {
                            Application.Exit();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            cboTitle.SelectedIndex = 0;
            txtPass.Clear();
            txtUserName.Clear();
        }
    }
}
