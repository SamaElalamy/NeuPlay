using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class PrivacyPolicyControl : UserControl
    {
        public PrivacyPolicyControl()
        {
            InitializeComponent();
        }

        private void chk_Agree_CheckedChanged(object sender, EventArgs e)
        {
            button_continue.Enabled = chk_Agree.Checked;
        }


        private void button_Continue_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DiagnosisScreenControl());
            }
        }

        private void button_continue_Click_1(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new DiagnosisScreenControl());
            }

        }
    }
}