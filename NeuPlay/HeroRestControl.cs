using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class HeroRestControl : UserControl
    {
        public HeroRestControl()
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
        }

        private void btn_Tips_Click(object sender, EventArgs e)
        {
            OpenViewer("Tips");
        }


        private void btn_Stories_Click(object sender, EventArgs e)
        {
            OpenViewer("Stories");
        }

        private void btn_Parental_Click(object sender, EventArgs e)
        {
            OpenViewer("Parental");
        }

        private void OpenViewer(string category)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                //parentForm.LoadScreen(new HeroRestViewerControl(category));
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                // نرجع لصفحة الخدمات (باعتبار إن الطفل عنده المشكلتين عشان نظهر كل الزراير كمثال)
                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }
    }
}