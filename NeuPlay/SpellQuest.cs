using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class SpellQuest : UserControl
    {
        public SpellQuest()
        {
            InitializeComponent();
            
        }


        private void startbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new Phase1FlashCardControl());
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl());
            }
        }
    }
}