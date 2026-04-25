using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class RegisterScreenControl : UserControl
    {
        public RegisterScreenControl()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_NewUsername.Text) || string.IsNullOrWhiteSpace(txt_NewPassword.Text))
            {
                MessageBox.Show("Please complete the registering process", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txt_NewPassword.Text != txt_ConfirmPassword.Text)
            {
                MessageBox.Show("Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (cmb_Age.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a suitable age", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Registering done successfully!", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DashboardControl(txt_NewUsername.Text, 0));
            }
        }

        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new LoginScreenControl());
            }
        }
    }
}