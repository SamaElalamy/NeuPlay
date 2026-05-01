using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NeuPlay
{
    public partial class DiagnosisScreenControl : UserControl
    {
        private DifficultyType currentTestType;
        public DiagnosisScreenControl(DifficultyType selectedTest)
        {
            InitializeComponent();
            //Theme.ApplyTheme(this);
            currentTestType = selectedTest;
        }

        public DiagnosisScreenControl()
        {
            InitializeComponent();
            //Theme.ApplyTheme(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void DiagnosisScreenControl_Load(object sender, EventArgs e)
        {
            // 1. نجهز المصفوفة الأول
            Question[] currentQuestions = new Question[10];

            // 2. نحدد نوع الاختبار ونملى المصفوفة بناءً عليه
            if (currentTestType == DifficultyType.Dysgraphia)
            {
                currentQuestions = Tests.dysgraphiaTest;
            }
            else if (currentTestType == DifficultyType.Dyscalculia)
            {
                currentQuestions = Tests.dyscalculiaTest;
            }
            else if (currentTestType == DifficultyType.Both)
            {
                // دمج: هناخد أول 5 أسئلة من الدسجرافيا، وأول 5 من الدسكالكوليا
                for (int i = 0; i < 5; i++)
                {
                    currentQuestions[i] = Tests.dysgraphiaTest[i];
                    currentQuestions[i + 5] = Tests.dyscalculiaTest[i];
                }
            }

            // تأمين عشان لو مفيش داتا ميضربش
            if (currentQuestions == null || currentQuestions.Length < 10) return;

            // 3. نعرض الأسئلة على الشاشة (الخطوة دي لازم تكون في الآخر بعد ما المصفوفة اتملت)
            Q1.Text = currentQuestions[0].Q;
            Q2.Text = currentQuestions[1].Q;
            Q3.Text = currentQuestions[2].Q;
            Q4.Text = currentQuestions[3].Q;
            Q5.Text = currentQuestions[4].Q;
            Q6.Text = currentQuestions[5].Q;
            Q7.Text = currentQuestions[6].Q;
            Q8.Text = currentQuestions[7].Q;
            Q9.Text = currentQuestions[8].Q;
            Q10.Text = currentQuestions[9].Q;
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            
                Tests.score = 0; 
                Question[] currentQuestions = null;
                if (currentTestType == DifficultyType.Dysgraphia)
                {
                    currentQuestions = Tests.dysgraphiaTest;
                }
                else if (currentTestType == DifficultyType.Dyscalculia)
                {
                    currentQuestions = Tests.dyscalculiaTest;
                }
                if (currentQuestions == null || currentQuestions.Length < 10) return;

                // السؤال الأول (Q1)
                if (RB1.Checked) Tests.score += currentQuestions[0].Score;
                else if (RB3.Checked) Tests.score += (currentQuestions[0].Score / 2);

                // السؤال الثاني (Q2)
                if (RB4.Checked) Tests.score += currentQuestions[1].Score;
                else if (RB6.Checked) Tests.score += (currentQuestions[1].Score / 2);

                // السؤال الثالث (Q3)
                if (RB7.Checked) Tests.score += currentQuestions[2].Score;
                else if (RB9.Checked) Tests.score += (currentQuestions[2].Score / 2);

                // السؤال الرابع (Q4)
                if (RB10.Checked) Tests.score += currentQuestions[3].Score;
                else if (RB12.Checked) Tests.score += (currentQuestions[3].Score / 2);

                // السؤال الخامس (Q5)
                if (RB13.Checked) Tests.score += currentQuestions[4].Score;
                else if (RB15.Checked) Tests.score += (currentQuestions[4].Score / 2);

                // السؤال السادس (Q6)
                if (RB16.Checked) Tests.score += currentQuestions[5].Score;
                else if (RB18.Checked) Tests.score += (currentQuestions[5].Score / 2);

                // السؤال السابع (Q7)
                if (RB19.Checked) Tests.score += currentQuestions[6].Score;
                else if (RB21.Checked) Tests.score += (currentQuestions[6].Score / 2);

                // السؤال الثامن (Q8)
                if (RB22.Checked) Tests.score += currentQuestions[7].Score;
                else if (RB24.Checked) Tests.score += (currentQuestions[7].Score / 2);

                // السؤال التاسع (Q9)
                if (RB25.Checked) Tests.score += currentQuestions[8].Score;
                else if (RB27.Checked) Tests.score += (currentQuestions[8].Score / 2);

                // السؤال العاشر (Q10)
                if (RB28.Checked) Tests.score += currentQuestions[9].Score;
                else if (RB30.Checked) Tests.score += (currentQuestions[9].Score / 2);

                
                string testReport = "Normal";

                if (currentTestType == DifficultyType.Dysgraphia)
                {
                    if (Tests.score >= 50) testReport = "Dysgraphia"; 
                }
                else if (currentTestType == DifficultyType.Dyscalculia)
                {
                    if (Tests.score >= 50) testReport = "Dyscalculia";
                }

                if (currentTestType == DifficultyType.Dysgraphia)
                {
                    if (Tests.score >= 50) testReport = "Dysgraphia";
                }
                else if (currentTestType == DifficultyType.Dyscalculia)
                {
                    if (Tests.score >= 50) testReport = "Dyscalculia";
                }
                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null)
                {
                    parentForm.LoadScreen(new ResultControlcs(testReport));
                }

                string finalDiagnosis = "Normal";

    
    if (currentTestType == DifficultyType.Dysgraphia && Tests.score >= 50)
    {
        finalDiagnosis = "Dysgraphia";
    }
    else if (currentTestType == DifficultyType.Dyscalculia && Tests.score >= 50)
    {
        finalDiagnosis = "Dyscalculia";
    }
    else if (currentTestType == DifficultyType.Both && Tests.score >= 50)
    {
        finalDiagnosis = "Both";
    }

    
            }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RB6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB17_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
