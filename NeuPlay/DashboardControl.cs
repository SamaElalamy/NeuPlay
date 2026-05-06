using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class DashboardControl : UserControl
    {
        
        private Users loggedInUser;

        
        public DashboardControl(Users currentUser)
        {
            InitializeComponent();
            loggedInUser = currentUser;
            if (loggedInUser != null)
            {
                lbl_Welcome.Text = "Hello, " + loggedInUser.Name + "!";
            }
            else
            {
                lbl_Welcome.Text = "Hello, Guest!"; 
            }

            

            
            int currentScore = PopUpManager.TotalPoints;
            lbl_Score.Text = "Score: " + currentScore.ToString();
            lbl_Level.Text = "Level: 1";

            if (currentScore >= 50)
                lbl_Badge.Text = "Numbers' Nerd 🌟";
            else
                lbl_Badge.Text = "New Explorer 🔍";
        }

        
        public DashboardControl()
        {
            InitializeComponent();
            lbl_Welcome.Text = "Hello, Hero!";
            lbl_Score.Text = "Score: 0";
            lbl_Level.Text = "Level: 1";
            lbl_Badge.Text = "New Explorer 🔍";
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new ServicesScreenControl(loggedInUser));
            }
        }

        
        
        private void btn_Play_Click_1(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new ServicesScreenControl(loggedInUser));
            }
        }

        private void btn_Achievements_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new AchievementsControl(loggedInUser));
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                
                parentForm.LoadScreen(new ProfileControl(loggedInUser));
            }
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {
        }

        private void lbl_Score_Click(object sender, EventArgs e)
        {
        }
    }
}