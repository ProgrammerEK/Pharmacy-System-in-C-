using System;

namespace Pharmacy_System.Login_Files
{
    public partial class Splash_Form : MetroFramework.Forms.MetroForm
    {

        public Splash_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(1);
            if (metroProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Login_Form lg = new Login_Form();
                lg.ShowDialog();
            }
        }
    }
}
