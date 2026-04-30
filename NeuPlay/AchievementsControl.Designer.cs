namespace NeuPlay
{
    partial class AchievementsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label5 = new Label();
            flp_Achievements = new FlowLayoutPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(106, 36, 138);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(249, 235, 249);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 80);
            label5.TabIndex = 13;
            label5.Text = "My Achievements";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flp_Achievements
            // 
            flp_Achievements.Location = new Point(48, 112);
            flp_Achievements.Name = "flp_Achievements";
            flp_Achievements.Size = new Size(944, 408);
            flp_Achievements.TabIndex = 14;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(18, 504);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(145, 56);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "Back";
            guna2Button1.Click += btn_Back_Click;
            // 
            // AchievementsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_Achievements);
            Controls.Add(label5);
            Controls.Add(btnback);
            ForeColor = Color.FromArgb(249, 235, 249);
            Name = "AchievementsControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private FlowLayoutPanel flp_Achievements;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
