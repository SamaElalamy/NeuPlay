using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NeuPlay
{
    public partial class PrivacyPolicyControl : UserControl
    {
        public PrivacyPolicyControl()
        {
            InitializeComponent();

            Theme.ApplyTheme(this);
        }

        private void chk_Agree_CheckedChanged(object sender, EventArgs e)
        {
            continuebtn.Enabled = chk_Agree.Checked;
            if (chk_Agree.Checked)
            {
                continuebtn.Enabled = true;
                continuebtn.Cursor = Cursors.Hand;
            }
            else
            {
                continuebtn.Enabled = false;
                continuebtn.Cursor = Cursors.Default;
            }
        }

        private void continuebtn_Click_1(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new TestChoice());
            }
        }
    }
}