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
    public partial class DiagnosisScreenControl : UserControl
    {
        private DifficultyType currentTestType;
        private Question[] currentQuestions;

        
        private int currentPage = 1;

        public DiagnosisScreenControl(DifficultyType selectedTest)
        {
            InitializeComponent();
            currentTestType = selectedTest;
        }

        public DiagnosisScreenControl()
        {
            InitializeComponent();
        }

        private void DiagnosisScreenControl_Load(object sender, EventArgs e)
        {
            
            Tests.score = 0;

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
                
                currentQuestions = new Question[20];
                for (int i = 0; i < 10; i++)
                {
                    currentQuestions[i] = Tests.dysgraphiaTest[i];      
                    currentQuestions[i + 10] = Tests.dyscalculiaTest[i]; 
                }
            }

            if (currentQuestions == null || currentQuestions.Length < 10) return;

            
            Display10Questions(0);
        }

        
        private void Display10Questions(int startIndex)
        {
            Q1.Text = currentQuestions[startIndex + 0].Q;
            Q2.Text = currentQuestions[startIndex + 1].Q;
            Q3.Text = currentQuestions[startIndex + 2].Q;
            Q4.Text = currentQuestions[startIndex + 3].Q;
            Q5.Text = currentQuestions[startIndex + 4].Q;
            Q6.Text = currentQuestions[startIndex + 5].Q;
            Q7.Text = currentQuestions[startIndex + 6].Q;
            Q8.Text = currentQuestions[startIndex + 7].Q;
            Q9.Text = currentQuestions[startIndex + 8].Q;
            Q10.Text = currentQuestions[startIndex + 9].Q;
        }

        
        private void UncheckAllRadioButtons(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is RadioButton rb) rb.Checked = false;
                else UncheckAllRadioButtons(c); 
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (currentQuestions == null || currentQuestions.Length < 10) return;

            
            int startIndex = (currentPage == 1) ? 0 : 10;

            
            if (RB1.Checked) Tests.score += currentQuestions[startIndex + 0].Score;
            else if (RB3.Checked) Tests.score += (currentQuestions[startIndex + 0].Score / 2);

            if (RB4.Checked) Tests.score += currentQuestions[startIndex + 1].Score;
            else if (RB6.Checked) Tests.score += (currentQuestions[startIndex + 1].Score / 2);

            if (RB7.Checked) Tests.score += currentQuestions[startIndex + 2].Score;
            else if (RB9.Checked) Tests.score += (currentQuestions[startIndex + 2].Score / 2);

            if (RB10.Checked) Tests.score += currentQuestions[startIndex + 3].Score;
            else if (RB12.Checked) Tests.score += (currentQuestions[startIndex + 3].Score / 2);

            if (RB13.Checked) Tests.score += currentQuestions[startIndex + 4].Score;
            else if (RB15.Checked) Tests.score += (currentQuestions[startIndex + 4].Score / 2);

            if (RB16.Checked) Tests.score += currentQuestions[startIndex + 5].Score;
            else if (RB18.Checked) Tests.score += (currentQuestions[startIndex + 5].Score / 2);

            if (RB19.Checked) Tests.score += currentQuestions[startIndex + 6].Score;
            else if (RB21.Checked) Tests.score += (currentQuestions[startIndex + 6].Score / 2);

            if (RB22.Checked) Tests.score += currentQuestions[startIndex + 7].Score;
            else if (RB24.Checked) Tests.score += (currentQuestions[startIndex + 7].Score / 2);

            if (RB25.Checked) Tests.score += currentQuestions[startIndex + 8].Score;
            else if (RB27.Checked) Tests.score += (currentQuestions[startIndex + 8].Score / 2);

            if (RB28.Checked) Tests.score += currentQuestions[startIndex + 9].Score;
            else if (RB30.Checked) Tests.score += (currentQuestions[startIndex + 9].Score / 2);

            
            
            
            if (currentTestType == DifficultyType.Both && currentPage == 1)
            {
                currentPage = 2; 
                Display10Questions(10); 
                UncheckAllRadioButtons(this); 
                btn_submit.Text = "Submit Final"; 
                MessageBox.Show("Great! Now let's answer the remaining 10 questions.", "Next Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            
            
            
            string testReport = "Normal";

            
            if (currentTestType == DifficultyType.Dysgraphia && Tests.score >= 50)
                testReport = "Dysgraphia";
            else if (currentTestType == DifficultyType.Dyscalculia && Tests.score >= 50)
                testReport = "Dyscalculia";
            else if (currentTestType == DifficultyType.Both && Tests.score >= 100)
                testReport = "Both";

            
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new ResultControlcs(testReport));
            }
        }

        
        private void label1_Click(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void groupBox6_Enter(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void RB6_CheckedChanged(object sender, EventArgs e) { }
        private void RB17_CheckedChanged(object sender, EventArgs e) { }
    }
}