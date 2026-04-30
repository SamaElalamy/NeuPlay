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

            Theme.ApplyTheme(this);
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


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string testReport = "Your Child is diagnosed by Dysgraphia";
            Form1 parentform = (Form1)this.FindForm();
            if (parentform != null)
            {
                parentform.LoadScreen(new ResultControlcs(testReport));
            }
        }
    }
}
