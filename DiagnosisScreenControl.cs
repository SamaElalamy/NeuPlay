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
        public DiagnosisScreenControl()
        {
            InitializeComponent();
<<<<<<< HEAD

            Theme.ApplyTheme(this);
=======
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
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

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new ResultControlcs(" "));
            }
        }
        private void btn_FinishTest_Click(object sender, EventArgs e)
        {


            string testReport = "بناءً على الإجابات، نوصي بالبدء بألعاب مستوى الحروف والأرقام الأساسية.";

            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ResultControlcs(testReport));
            }
        }
        }
}
