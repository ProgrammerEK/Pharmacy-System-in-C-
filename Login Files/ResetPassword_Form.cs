using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_System.Login_Files
{
    public partial class ResetPassword_Form : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Doc\Documents\Pharmacydb.mdf;Integrated Security = True; Connect Timeout = 30");
        public ResetPassword_Form()
        {
            InitializeComponent();
        }

        private void ResetPassword_Form_Load(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblUsers ", con);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        col.Add(read["UserName"].ToString());
                        txtUserName.AutoCompleteCustomSource = col;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "User Name Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_User_Files.Admin_Form ad = new Main_User_Files.Admin_Form();
            ad.Show();
        }
    }
}
