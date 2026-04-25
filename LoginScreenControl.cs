using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class LoginScreenControl : UserControl
    {
        public LoginScreenControl()
        {
            InitializeComponent();
<<<<<<< HEAD

            Theme.ApplyTheme(this);
=======
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
        }

        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("من فضلك أدخل اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DashboardControl());
            }
        }

        
        private void btn_GoToRegister_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new RegisterScreenControl());
            }
        }
    }
}