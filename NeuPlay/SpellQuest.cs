using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class SpellQuest : UserControl
    {
        private Users loggedInUser;
        public SpellQuest(Users currentUser)
        {
            InitializeComponent();
            loggedInUser=currentUser;  
            
        }


        private void startbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new Phase1FlashCardControl(loggedInUser));
            }
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl(loggedInUser));
            }
        }
    }
}