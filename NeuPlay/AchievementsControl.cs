using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class AchievementsControl : UserControl
    {
        public AchievementsControl()
        {
            InitializeComponent();
            
            AddBadge("Numbers Hero 🏆", Color.Gold);
            AddBadge("Quick Solver ⚡", Color.SkyBlue);
            AddBadge("New Explorer 🌟", Color.LightGreen);

            Theme.ApplyTheme(this);
        }

        private void AddBadge(string title, Color bgColor)
        {
            Label lblBadge = new Label();
            lblBadge.Text = title;
            lblBadge.BackColor = bgColor;
            lblBadge.ForeColor = Color.White;
            lblBadge.Size = new Size(160, 60);
            lblBadge.TextAlign = ContentAlignment.MiddleCenter;
            lblBadge.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblBadge.Margin = new Padding(10);

            
            flp_Achievements.Controls.Add(lblBadge);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new DashboardControl());
            }
        }
    }
}