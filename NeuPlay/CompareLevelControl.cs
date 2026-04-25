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

        public CompareLevelControl()
        {
            InitializeComponent();
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            // أرقام عشوائية من 1 لـ 9
            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);

            // تحديد الإجابة الصحيحة برمجياً
            if (num1 > num2) correctAnswer = ">";
            else if (num1 < num2) correctAnswer = "<";
            else correctAnswer = "=";

            // العرض على الشاشة
            lbl_Num1.Text = num1.ToString();
            lbl_Num2.Text = num2.ToString();
            lbl_Operator.Text = "?";
        }

        private void CheckAnswer(string chosenOperator)
        {
            if (chosenOperator == correctAnswer)
            {
                lbl_Operator.Text = chosenOperator; // بنظهر العلامة الصح
                MessageBox.Show("إجابة صحيحة! برافو عليك 🌟", "ممتاز", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                 Form1 parentForm = (Form1)this.FindForm();
                 if (parentForm != null) parentForm.LoadScreen(new OrderLevelControl());

                GenerateQuestion(); // مؤقتاً بنجيب سؤال جديد
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
                parentForm.LoadScreen(new NumbersLand());
            }
        }
    }
}