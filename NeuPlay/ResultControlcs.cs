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
    public partial class ResultControlcs : UserControl
    {
        public ResultControlcs(string resultMessage)
        {
            InitializeComponent();
            lbl_FinalResult.Text = resultMessage;

            Theme.ApplyTheme(this);

        }

        private void CreatingAccountbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new RegisterScreenControl());
            }
        }
    }
}
