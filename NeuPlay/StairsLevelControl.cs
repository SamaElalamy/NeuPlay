using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class StairsLevelControl : UserControl
    {
        int startNum;
        int totalsteps = 10;
        TrackingSystem trackingSystem; // عملنا object     
        Random random = new Random();
        private Point bunnyStartLocation;
        Label[] Labels;
        TextBox[] TextBoxes;

        public StairsLevelControl()
        {
            InitializeComponent();

            trackingSystem = new TrackingSystem(5, progressBar1);
            Labels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            TextBoxes = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };

            bunnyStartLocation = pic_Bunny.Location;
            SetupStairsLevel();
            Theme.ApplyTheme(this);
        }

        private void SetupStairsLevel()
        {
            for (int i = 0; i < totalsteps; i++)
            {
                int StepValue = i + 1; //الرقم الحقيقي لكل درجه

                TextBoxes[i].Text = "";
                TextBoxes[i].TextAlign = HorizontalAlignment.Left;
                TextBoxes[i].Font = new Font("Segoe UI", 14, FontStyle.Bold);

                //// بيختار رقم عشوائي بين 0 و 9؛ إذا كان الرقم أقل من 4 و بيخفيه عشان الطفل يكتبه
                bool missing = random.Next(0, 10) < 4;

                if (missing)
                {
                    Labels[i].Visible = false;
                    TextBoxes[i].Visible = true;
                }
                else
                {
                    Labels[i].Text = StepValue.ToString();
                    Labels[i].Visible = true;
                    TextBoxes[i].Visible = false;
                }
            }
            AtLeastTwoMissing();
        }

        private void AtLeastTwoMissing()
        {
            int currentMissing = 0;

            //نشوف كام مربع ظاهر
            foreach (var txt in TextBoxes)
            {
                if (txt.Visible) currentMissing++;
            }

            while (currentMissing < 2) // لو عدد اقل من 2 بتختار مربعات تانيه و تظهرها 
            {
                int rnd = random.Next(0, 10); //يختار مكان عشوائي

                if (!TextBoxes[rnd].Visible)
                {
                    Labels[rnd].Visible = false;
                    TextBoxes[rnd].Visible = true;
                    currentMissing++;
                }
            }
        }
        private void btn_Check_Click(object sender, EventArgs e)
        {
            bool isStepsCorrect = true;

            //بتعدي علي المربعات
            for (int i = 0; i < TextBoxes.Length; i++)
            {
                if (TextBoxes[i].Visible) //لو المربع طلع ظاهر 
                {
                    if (TextBoxes[i].Text != (i + 1).ToString()) //بتقارن اللي كتبه الطفل بالرقم الصح
                    {
                        isStepsCorrect = false; //"لو النتيجه طلع غلط ده الللي هيتنفذ و هيطبع "ان الارنب محتار
                        break;
                    }
                }
            }

            if (isStepsCorrect)
            {
                // بننادي على Add() وهي هترجع True لو الطفل خلص الـ 5 جولات
                bool finish = trackingSystem.Add();

                pic_Bunny.Location = new Point(TextBoxes[9].Location.X - 50, TextBoxes[9].Location.Y - 40); // علي حسب اللوكيشن

                MessageBox.Show("برافو! الأرنب وصل للقمة بفضل مساعدتك 🐰", "ممتاز", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pic_Bunny.Location = bunnyStartLocation; //الارنب يرجع مكانه

                if (finish)
                {
                    MessageBox.Show("مبروك! شريط التقدم اكتمل والأرنب فاز بالبطولة 🏆");

                    //بنصفر العداد 
                    trackingSystem.Reset();
                    Form1 parentForm = (Form1)this.FindForm();
                    if (parentForm != null) parentForm.LoadScreen(new OrderLevelControl());
                }
                else
                {
                    int remaining = trackingSystem.TargetWins - trackingSystem.CorrectWins;
                    MessageBox.Show($"إجابة صحيحة! فاضلك {remaining} خطوات ويملى العداد!");

                    pic_Bunny.Location = bunnyStartLocation;
                    SetupStairsLevel();
                }
            }
            else
            {
                MessageBox.Show("الأرنب محتار.. راجع الأرقام الناقصة تاني!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //بتمسح كل اللي الطفل كتبه في المربعات الظاهرة 
                foreach (var txt in TextBoxes)
                {
                    if (txt.Visible) txt.Text = "";
                }
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

        private void pic_Bunny_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}