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
    public partial class TestChoice : UserControl
    {
        public TestChoice()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DifficultyType selectedTest = DifficultyType.Dysgraphia;


            Tests.score = 0;
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DiagnosisScreenControl(selectedTest));
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
                parentForm.LoadScreen(new DiagnosisScreenControl(DifficultyType.Both));
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
                parentForm.LoadScreen(new DiagnosisScreenControl(DifficultyType.Dyscalculia));
        }
    }
}
