using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class CountAndMatchControl : UserControl
    {
        int currentNumber = 1; //هيبدا من 1 ل 10
        Random rnd = new Random();

        public CountAndMatchControl()
        {
            InitializeComponent();
            GenerateQuestion(); 
            Theme.ApplyTheme(this);
        }

        private void GenerateQuestion()
        {
            int correctAnswer = currentNumber; //الرقم اللي عليه الدور

            //اختيار الصوره بالترتيب
            switch (correctAnswer)
            {
                case 1: pic_Quantity.Image = Properties.Resources._1; break;
                case 2: pic_Quantity.Image = Properties.Resources._2; break;
                case 3: pic_Quantity.Image = Properties.Resources._3; break;
                case 4: pic_Quantity.Image = Properties.Resources._4; break;
                case 5: pic_Quantity.Image = Properties.Resources._5; break;
                case 6: pic_Quantity.Image = Properties.Resources._6; break;
                case 7: pic_Quantity.Image = Properties.Resources._7; break;
                case 8: pic_Quantity.Image = Properties.Resources._8; break;
                case 9: pic_Quantity.Image = Properties.Resources._9; break;
                case 10: pic_Quantity.Image = Properties.Resources._10; break;
            }

            // نجهز 4 اختيارات (واحد صح وتلاتة غلط)
            List<int> choices = new List<int> { correctAnswer };
            while (choices.Count < 4)
            {
                int wrongAnswer = rnd.Next(1, 11);
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
            if (selectedNum == currentNumber)
            {
                if(currentNumber < 10)
                {
                    MessageBox.Show("إجابة صحيحة! برافو 🌟", "ممتاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentNumber++;
                    GenerateQuestion();
                }
                else
                {
                    MessageBox.Show("مبروك! تعلمت الأرقام من 1 لـ 10 بنجاح 🏆", "بطل الأرقام");

                    Form1 parentForm = (Form1)this.FindForm();
                    if (parentForm != null) parentForm.LoadScreen(new CollectLevelControl());
                }
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