using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class HeroRestViewerControl : UserControl
    {
        int currentIndex = 0;
        int totalImages = 0; // عدد الصور في كل قسم

        // الدالة دي بتستقبل إحنا فتحنا أي قسم
        public HeroRestViewerControl(string category)
        {
            InitializeComponent();

            // تحديد عدد الصور لكل قسم (تقدروا تغيروا الأرقام دي بعدين)
            if (category == "Tips") totalImages = 3;
            else if (category == "Stories") totalImages = 5;
            else if (category == "Parental") totalImages = 2;

            ShowCurrentImage();
        }

        // دالة العرض (دي اللي هيتحط فيها الصور بعدين)
        private void ShowCurrentImage()
        {
            // مثال للي هتعمله بعدين عشان تعرض الصورة:
            // if (currentIndex == 0) pic_Content.Image = Properties.Resources.Story1;


            btnPre.Enabled = (currentIndex > 0);
            btnNext.Enabled = (currentIndex < totalImages - 1);
        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (currentIndex < totalImages - 1)
            {
                currentIndex++;
                ShowCurrentImage();
            }
        }


        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowCurrentImage();
            }
        }

        // returning to hero's core
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new HeroRestControl());
            }
        }

        private void pic_Content_Click(object sender, EventArgs e)
        {

        }
    }
}