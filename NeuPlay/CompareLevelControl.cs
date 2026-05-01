using System;
using System.Windows.Forms;
using NeuPlay.Properties;

namespace NeuPlay
{
    public partial class CompareLevelControl : UserControl
    {
        int num1, num2;
        string correctAnswer;
        Random rnd = new Random();
        TrackingSystem tracker;
        Score score = new Score();

        public CompareLevelControl()
        {
            InitializeComponent();
            tracker = new TrackingSystem(5, progressBar1); //هيلعب 5 جولات
            GenerateQuestion();
            Theme.ApplyTheme(this);

        }

        private void GenerateQuestion()
        {
            // أرقام عشوائية من 1 لـ 10
            num1 = rnd.Next(1, 11);
            num2 = rnd.Next(1, 11);

            // تحديد الإجابة الصحيحة برمجياً
            if (num1 > num2) correctAnswer = ">";
            else if (num1 < num2) correctAnswer = "<";
            else correctAnswer = "=";

            lbl_Operator.Text = "?";

            // العرض على الشاشة
            // صور للرقم الاول
            switch (num1)
            {
                case 1: pictureBox1.Image = Properties.Resources.num1; break;
                case 2: pictureBox1.Image = Properties.Resources.num2; break;
                case 3: pictureBox1.Image = Properties.Resources.num3; break;
                case 4: pictureBox1.Image = Properties.Resources.num4; break;
                case 5: pictureBox1.Image = Properties.Resources.num5; break;
                case 6: pictureBox1.Image = Properties.Resources.num6; break;
                case 7: pictureBox1.Image = Properties.Resources.num7; break;
                case 8: pictureBox1.Image = Properties.Resources.nim8; break;
                case 9: pictureBox1.Image = Properties.Resources.num9; break;
                case 10: pictureBox1.Image = Properties.Resources.num10; break;
            }

            //صور للرقم التاني
            switch (num2)
            {
                case 1: pictureBox2.Image = Properties.Resources.num1; break;
                case 2: pictureBox2.Image = Properties.Resources.num2; break;
                case 3: pictureBox2.Image = Properties.Resources.num3; break;
                case 4: pictureBox2.Image = Properties.Resources.num4; break;
                case 5: pictureBox2.Image = Properties.Resources.num5; break;
                case 6: pictureBox2.Image = Properties.Resources.num6; break;
                case 7: pictureBox2.Image = Properties.Resources.num7; break;
                case 8: pictureBox2.Image = Properties.Resources.nim8; break;
                case 9: pictureBox2.Image = Properties.Resources.num9; break;
                case 10: pictureBox2.Image = Properties.Resources.num10; break;
            }
        }

        private void CheckAnswer(string chosenOperator)
        {
            if (chosenOperator == correctAnswer)
            {
                lbl_Operator.Text = chosenOperator; // بنظهر العلامة الصح

                // بننادي على Add() وهي هترجع True لو الطفل خلص الـ 5 جولات
                bool isFinished = tracker.Add();

                if (isFinished)
                {
                    MessageBox.Show("بطل المقارنة! شريط التقدم اكتمل 🏆", "مبروك");

                    score.AddPoints("CompareLevel"); //استدعاء داله الاسكور
                    MessageBox.Show("نقاطك: " + Score.points, "برافو🎉");

                    tracker.Reset(); //بنصفر العداد

                    // كود الانتقال لليفل الترتيب
                    Form1 parentForm = (Form1)this.FindForm();
                    if (parentForm != null) parentForm.LoadScreen(new AdditionLevelControl());
                }
                else
                {
                    int remaining = tracker.TargetWins - tracker.CorrectWins; //دي بتحسب فاضل كام و ال bar يكتمل
                    MessageBox.Show($"صح! فاضلك {remaining} ونروح لليفل الترتيب 🌟", "ممتاز");
                    GenerateQuestion();
                }
            }
            else
            {
                MessageBox.Show("فكر تاني بالراحة، مين الرقم الأكبر؟", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // أحداث الزراير
        private void btn_Greater_Click(object sender, EventArgs e) { CheckAnswer(">"); }
        private void btn_Equal_Click(object sender, EventArgs e) { CheckAnswer("="); }
        private void btn_Less_Click(object sender, EventArgs e) { CheckAnswer("<"); }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new OrderLevelControl());
            }
        }

        private void lbl_Operator_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}