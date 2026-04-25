using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class CollectLevelControl : UserControl
    {
        int targetCount = 3; // مطلوب يجمع 3 نجوم (تقدري تغيري الرقم براحتك)
        int collectedCount = 0; // العداد اللي بيحسب هو داس على كام نجمة

        public CollectLevelControl()
        {
            InitializeComponent();
            lbl_Title.Text = $"Collect {targetCount} stars"; 
        }

        
        private void CollectItem(PictureBox pic)
        {
            if (pic.Visible == true) 
            {
                pic.Visible = false; // يخفي النجمة كأنه خدها
                collectedCount++; 

                
                if (collectedCount == targetCount)
                {
                    

                     
                    Form1 parentForm = (Form1)this.FindForm();
                    if (parentForm != null) parentForm.LoadScreen(new StairsLevelControl());
                }
            }
        }

        
        private void pic_Star1_Click(object sender, EventArgs e) { CollectItem(pic_Star1); }
        private void pic_Star2_Click(object sender, EventArgs e) { CollectItem(pic_Star2); }
        private void pic_Star3_Click(object sender, EventArgs e) { CollectItem(pic_Star3); }
        private void pic_Star4_Click(object sender, EventArgs e) { CollectItem(pic_Star4); }
        private void pic_Star5_Click(object sender, EventArgs e) { CollectItem(pic_Star5); }

        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new NumbersLand());
            }
        }
    }
}