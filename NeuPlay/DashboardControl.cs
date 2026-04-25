using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class DashboardControl : UserControl
    {

        public DashboardControl(string childName, int currentScore)
        {
            InitializeComponent();
            lbl_Welcome.Text = "Hello, " + childName + " !";
            lbl_Score.Text = currentScore.ToString();
            lbl_Level.Text = "Level: 1";
            lbl_Badge.Text = "Beginner";
            lbl_Welcome.Text = "Hello, " + childName + "!";
            lbl_Score.Text = "Score: " + currentScore.ToString();
            lbl_Level.Text = "Level: 1";


            if (currentScore >= 50)
                lbl_Badge.Text = "Numbers' Nerd 🌟";
            else
                lbl_Badge.Text = "New Explorer 🔍";
        }


        private void btn_Play_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl());
            }
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Badge_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Level_Click(object sender, EventArgs e)
        {

        }

        private void btn_Achievements_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new AchievementsControl());
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ProfileControl());
            }
        }

        public DashboardControl()
        {
            InitializeComponent();

            Theme.ApplyTheme(this);
            lbl_Welcome.Text = "Hello, Hero !";
            lbl_Score.Text = "Score: 0";
            lbl_Level.Text = "Level: 1";
            lbl_Badge.Text = "New Explorer";
        }
    }
}