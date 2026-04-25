using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class CountAndMatchControl : UserControl
    {
        int correctAnswer;
        Random rnd = new Random();

        public CountAndMatchControl()
        {
            InitializeComponent();
            GenerateQuestion(); 
        }

        private void GenerateQuestion()
        {
            // بنختار رقم عشوائي من 1 لـ 4 (زي ما في الديزاين بتاعك)
            correctAnswer = rnd.Next(1, 5);

            // ملحوظة لسلمى: هنا هتحط كود يغير الصورة بناءً على الرقم
            // مثال: لو الرقم 3، تظهر صورة الـ 3 نجوم
            // if (correctAnswer == 3) pic_Quantity.Image = Properties.Resources.ThreeStars;

            // نجهز 4 اختيارات (واحد صح وتلاتة غلط)
            List<int> choices = new List<int> { correctAnswer };
            while (choices.Count < 4)
            {
                int wrongAnswer = rnd.Next(1, 10);
                if (!choices.Contains(wrongAnswer))
                {
                    choices.Add(wrongAnswer);
                }
            }

            // نلخبط أماكن الإجابات عشان الصح ميكونش في نفس الزرار كل مرة
            choices = choices.OrderBy(x => rnd.Next()).ToList();

            // نحط الأرقام على الزراير
            btn_Num1.Text = choices[0].ToString();
            btn_Num2.Text = choices[1].ToString();
            btn_Num3.Text = choices[2].ToString();
            btn_Num4.Text = choices[3].ToString();
        }

        private void CheckAnswer(int selectedNum)
        {
            if (selectedNum == correctAnswer)
            {
                MessageBox.Show("إجابة صحيحة! برافو 🌟", "ممتاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null) parentForm.LoadScreen(new CollectLevelControl());

                GenerateQuestion(); // مؤقتاً بنجيب سؤال جديد في نفس الشاشة
            }
            else
            {
                MessageBox.Show("حاول تعدهم تاني بالراحة", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btn_Num1_Click(object sender, EventArgs e) { CheckAnswer(int.Parse(btn_Num1.Text)); }
        private void btn_Num2_Click(object sender, EventArgs e) { CheckAnswer(int.Parse(btn_Num2.Text)); }
        private void btn_Num3_Click(object sender, EventArgs e) { CheckAnswer(int.Parse(btn_Num3.Text)); }
        private void btn_Num4_Click(object sender, EventArgs e) { CheckAnswer(int.Parse(btn_Num4.Text)); }

        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }
    }
}