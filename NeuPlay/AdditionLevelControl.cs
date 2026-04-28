using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class AdditionLevelControl : UserControl
    {
        private int num1, num2, correctAnswer;
        private Random random = new Random();
        TrackingSystem tracking; //عملنا object
        private List<Button> optionButtons;
        public AdditionLevelControl()
        {
            InitializeComponent();
            //اللعبه هتكون 7 جولات
            tracking = new TrackingSystem(7, progressBar1);
            GenerateQuestion();
            Theme.ApplyTheme(this);
        }

        private void GenerateQuestion()
        {
            num1 = random.Next(1, 11);
            num2 = random.Next(1, 11);
            correctAnswer = num2 + num1;

            // عرض الصور على حسب الأرقام
            SetNumberImage(num1, pictureBox1);
            SetNumberImage(num2, pictureBox2);

            //عرض الارقام 
            label4.Text = num1.ToString();
            label5.Text = num2.ToString();

            //(هنجهز 3 اختيارات(واحد صح و 2 غلط
            List<int> choices = new List<int>() { correctAnswer };
            while (choices.Count < 3)
            {
                int wrongAnswer = random.Next(1, 11);
                if (!choices.Contains(wrongAnswer))
                {
                    choices.Add(wrongAnswer);
                }
            }
            // نلخبط أماكن الإجابات عشان الصح ميكونش في نفس الزرار كل مرة
            choices = choices.OrderBy(x => random.Next()).ToList();

            // نحط الأرقام على الزراير
            button1.Text = choices[0].ToString();
            button2.Text = choices[1].ToString();
            button3.Text = choices[2].ToString();

        }
        private void SetNumberImage(int number, PictureBox box)
        {
            switch (number)
            {
                case 1: box.Image = Properties.Resources.sum1; break;
                case 2: box.Image = Properties.Resources.sum2; break;
                case 3: box.Image = Properties.Resources.sum3; break;
                case 4: box.Image = Properties.Resources.sum4; break;
                case 5: box.Image = Properties.Resources.sum5; break;
                case 6: box.Image = Properties.Resources.sum6; break;
                case 7: box.Image = Properties.Resources.sum7_png; break;
                case 8: box.Image = Properties.Resources.sum8_png; break;
                case 9: box.Image = Properties.Resources.sum9; break;
                case 10: box.Image = Properties.Resources.sum10; break;
            }
        }
        private void lbl_Operator_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            int selectAnswer = int.Parse(click.Text);

            if (selectAnswer == correctAnswer)
            {
                bool finished = tracking.Add(); //زياده progressBar
                if (finished)
                {
                    MessageBox.Show("عبقري رياضيات! خلصت ليفل الجمع 🏆", "ممتاز");
                    tracking.Reset(); //بنصغر العداد
                }
                else
                {
                    MessageBox.Show("برافو! إجابة صحيحة 🌟", "ممتاز");
                    GenerateQuestion();
                }

            }
            else
            {
                MessageBox.Show("حاول مرة تانية يا بطل، عد الأشياء في الصور!", "Oops");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new NumbersLand());
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
                parentForm.LoadScreen(new NumbersLand());
        }
    }
}
