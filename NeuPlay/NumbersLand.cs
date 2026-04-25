using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class NumbersLand : UserControl
    {
        public NumbersLand()
        {
            InitializeComponent();
        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new CountAndMatchControl());
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }

        private void NumbersLand_Load(object sender, EventArgs e)
        {

        }
    }
}