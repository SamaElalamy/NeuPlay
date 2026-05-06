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
                MessageBox.Show("Please enter the username and password", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataManager manager = new DataManager();
            Users currentUser = manager.LogIn(Username.Text, Password.Text);

            
            if (currentUser != null)
            {
                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null)
                {
                    
                    parentForm.LoadScreen(new DashboardControl(currentUser));
                }
            }
            else
            {
                
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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