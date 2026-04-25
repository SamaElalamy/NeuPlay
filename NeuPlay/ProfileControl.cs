using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // بيانات افتراضية، تقدر تربطها بقاعدة البيانات لاحقاً
            txt_Name.Text = "Sama";
            txt_Age.Text = "19";
            txt_Password.Text = "Sama123456"; // هيظهر كنجوم وغير قابل للتعديل
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
            
                parentForm.LoadScreen(new DashboardControl());
            }
        }
    }
}