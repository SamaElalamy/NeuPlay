using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class CollectLevelControl : UserControl
    {
        int targetCount; //هيختار من 1 ل 10
        int collectedCount = 0; // العداد اللي بيحسب هو داس على كام نجمة
        Random random = new Random();

        List<int> list = new List<int>(); // عشان تكرار الارقام

        string[] itemThemes = { "apple" , "rabbit" , "star" , "ball", "planet" };
        string seletedTheme;

        public CollectLevelControl()
        {
            InitializeComponent();
            
            for(int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            SetupRandomLevel();
            Theme.ApplyTheme(this);

            //المقاس بتاع الصوره
            pic_Star1.SizeMode = pic_Star2.SizeMode = pic_Star3.SizeMode = pic_Star4.SizeMode = pic_Star5.SizeMode = pic_Star6.SizeMode = pic_Star7.SizeMode = pic_Star8.SizeMode = pic_Star9.SizeMode = pic_Star10.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void SetupRandomLevel()
        {
            if(list.Count > 0)
            {
                collectedCount = 0;

                int randomIndex = random.Next(0, list.Count);

                targetCount = list[randomIndex]; //هيختار قم عشوائي من 1 -10
                list.RemoveAt(randomIndex); // يحذف الرقم من list 

                seletedTheme = itemThemes[random.Next(itemThemes.Length)]; // هيختار شكل عشوائي من array

                lbl_Title.Text = $"Collect {targetCount} {seletedTheme}s"; //title

                Image itemImg;
                switch (seletedTheme)
                {
                    case "apple":
                        itemImg = Properties.Resources.apple; break;
                    case "star":
                        itemImg = Properties.Resources.star; break;
                    case "ball":
                        itemImg = Properties.Resources.ballon; break;
                    case "rabbit":
                        itemImg = Properties.Resources.rabbit; break;
                    default:
                        itemImg = Properties.Resources.planet; break;
                }
                //توزيع الصور علي الكل
                pic_Star1.Image = pic_Star2.Image = pic_Star3.Image = pic_Star4.Image = pic_Star5.Image = pic_Star6.Image = pic_Star7.Image = pic_Star8.Image = pic_Star9.Image = pic_Star10.Image = itemImg;

                //ناكد ان كل الصور ظاهره
                pic_Star1.Visible = pic_Star2.Visible = pic_Star3.Visible = pic_Star4.Visible = pic_Star5.Visible = pic_Star6.Visible = pic_Star7.Visible = pic_Star8.Visible = pic_Star9.Visible = pic_Star10.Visible = true;


            }
        }

        
        private void CollectItem(PictureBox pic)
        {
            if (pic.Visible == true) 
            {
                pic.Visible = false; // يخفي النجمة كأنه خدها
                collectedCount++; 

                
                if (collectedCount == targetCount)
                {
                    MessageBox.Show($"🌟 برافو! جمعت الـ {targetCount} {seletedTheme}s بنجاح!"); ;

                    if (list.Count > 0)  //لو لسه في ارقام مظهرتش يعيد ليفل جديد
                    {
                        SetupRandomLevel();
                    }
                    else
                    {
                        MessageBox.Show("مبروك يا بطل! أنهيت كل تحديات التجميع 🏆", "فوز ساحق");

                        Form1 parentForm = (Form1)this.FindForm();
                        if (parentForm != null)
                        {
                            //استدعاء داله الاسكور
                            parentForm.LoadScreen(new StairsLevelControl());
                        }
                    }
                }

            }
        }

        
        private void pic_Star1_Click(object sender, EventArgs e) { CollectItem(pic_Star1); }
        private void pic_Star2_Click(object sender, EventArgs e) { CollectItem(pic_Star2); }
        private void pic_Star3_Click(object sender, EventArgs e) { CollectItem(pic_Star3); }
        private void pic_Star4_Click(object sender, EventArgs e) { CollectItem(pic_Star4); }
        private void pic_Star5_Click(object sender, EventArgs e) { CollectItem(pic_Star5); }
        private void pic_Star6_Click(object sender, EventArgs e) { CollectItem(pic_Star6); }
        private void pic_Star7_Click(object sender, EventArgs e) { CollectItem(pic_Star7); }
        private void pic_Star8_Click(object sender, EventArgs e) { CollectItem(pic_Star8); }
        private void pic_Star9_Click(object sender, EventArgs e) { CollectItem(pic_Star9); }
        private void pic_Star10_Click(object sender, EventArgs e) { CollectItem(pic_Star10); }



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