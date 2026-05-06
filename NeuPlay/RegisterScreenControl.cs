using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NeuPlay
{
    public partial class RegisterScreenControl : UserControl
    {
        public RegisterScreenControl()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(NewUsername.Text) || string.IsNullOrWhiteSpace(NewPassword.Text))
            {
                MessageBox.Show("Please complete the registering process", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NewPassword.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmb_Age.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a suitable age", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataManager manager = new DataManager();

            
            int selectedAge = int.Parse(cmb_Age.SelectedItem.ToString());

            
            Users newUser = new Users(NewUsername.Text, NewPassword.Text, UserType.Parent, "No", selectedAge);

            
            if (manager.SignUp(newUser))
            {
                MessageBox.Show("Registering done successfully!", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null)
                {
                    
                    parentForm.LoadScreen(new TestChoice());
                }
            }
            
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                
                parentForm.LoadScreen(new LoginScreenControl());
            }
        }
    }
}