using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class LoginScreenControl : UserControl
    {
        public LoginScreenControl()
        {
            InitializeComponent();

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please,Enter the username and password", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DashboardControl(Username.Text, 0));
            }
        }

        private void registringbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new RegisterScreenControl());
            }
        }
    }
}