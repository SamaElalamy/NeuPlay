using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class ProfileControl : UserControl
    {

        private Users loggedInUser;

        
        public ProfileControl(Users currentUser)
        {
            InitializeComponent();
            loggedInUser = currentUser; 
            LoadUserData();
            Theme.ApplyTheme(this);
        }

        private void LoadUserData()
        {
            
            if (loggedInUser != null)
            {
                
                txt_Name.Text = loggedInUser.Name;
                txt_Age.Text = loggedInUser.Age.ToString();

                
                txt_Password.Text = new string('*', loggedInUser.Password.Length);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DashboardControl(loggedInUser));
            }
        }
    }
}