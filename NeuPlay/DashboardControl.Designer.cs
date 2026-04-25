namespace NeuPlay
{
    partial class DashboardControl
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
            lbl_Welcome = new Label();
            lbl_Level = new Label();
            lbl_Score = new Label();
            lbl_Badge = new Label();
            btn_Achievements = new Button();
            btn_Profile = new Button();
            label5 = new Label();
            btn_Play = new Button();
            TitleLable = new Label();
            ChildLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ChildLogo).BeginInit();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Segoe UI", 18F);
            lbl_Welcome.Location = new Point(32, 56);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(94, 41);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Hello,";
            lbl_Welcome.Click += lbl_Welcome_Click;
            // 
            // lbl_Level
            // 
            lbl_Level.AutoSize = true;
            lbl_Level.Font = new Font("Segoe UI", 18F);
            lbl_Level.Location = new Point(24, 120);
            lbl_Level.Name = "lbl_Level";
            lbl_Level.Size = new Size(128, 41);
            lbl_Level.TabIndex = 1;
            lbl_Level.Text = "level no.";
            lbl_Level.Click += lbl_Level_Click;
            // 
            // lbl_Score
            // 
            lbl_Score.AutoSize = true;
            lbl_Score.Font = new Font("Segoe UI", 18F);
            lbl_Score.Location = new Point(24, 176);
            lbl_Score.Name = "lbl_Score";
            lbl_Score.Size = new Size(191, 41);
            lbl_Score.TabIndex = 2;
            lbl_Score.Text = "current score";
            // 
            // lbl_Badge
            // 
            lbl_Badge.AutoSize = true;
            lbl_Badge.Font = new Font("Segoe UI", 18F);
            lbl_Badge.Location = new Point(120, 256);
            lbl_Badge.Name = "lbl_Badge";
            lbl_Badge.Size = new Size(170, 41);
            lbl_Badge.TabIndex = 3;
            lbl_Badge.Text = "Badge/Title";
            lbl_Badge.Click += lbl_Badge_Click;
            // 
            // btn_Achievements
            // 
            btn_Achievements.BackgroundImage = Properties.Resources.Gemini_Generated_Image_kwyp8vkwyp8vkwyp1;
            btn_Achievements.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Achievements.Location = new Point(88, 304);
            btn_Achievements.Name = "btn_Achievements";
            btn_Achievements.Size = new Size(264, 280);
            btn_Achievements.TabIndex = 4;
            btn_Achievements.UseVisualStyleBackColor = true;
            btn_Achievements.Click += btn_Achievements_Click;
            // 
            // btn_Profile
            // 
            btn_Profile.BackgroundImage = Properties.Resources.Gemini_Generated_Image_3izssl3izssl3izs;
            btn_Profile.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Profile.Location = new Point(664, 296);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(264, 288);
            btn_Profile.TabIndex = 5;
            btn_Profile.UseVisualStyleBackColor = true;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 48);
            label5.TabIndex = 9;
            label5.Text = "Dashboard";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Play
            // 
            btn_Play.Location = new Point(432, 608);
            btn_Play.Name = "btn_Play";
            btn_Play.Size = new Size(128, 56);
            btn_Play.TabIndex = 10;
            btn_Play.Text = "Let's Start!";
            btn_Play.UseVisualStyleBackColor = true;
            btn_Play.Click += btn_Play_Click;
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.Font = new Font("Segoe UI", 18F);
            TitleLable.Location = new Point(40, 256);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(89, 41);
            TitleLable.TabIndex = 11;
            TitleLable.Text = "Title: ";
            // 
            // ChildLogo
            // 
            ChildLogo.BackgroundImage = Properties.Resources.Gemini_Generated_Image_egrrhgegrrhgegrr;
            ChildLogo.BackgroundImageLayout = ImageLayout.Zoom;
            ChildLogo.Location = new Point(432, 48);
            ChildLogo.Name = "ChildLogo";
            ChildLogo.Size = new Size(125, 112);
            ChildLogo.TabIndex = 12;
            ChildLogo.TabStop = false;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChildLogo);
            Controls.Add(TitleLable);
            Controls.Add(btn_Play);
            Controls.Add(label5);
            Controls.Add(btn_Profile);
            Controls.Add(btn_Achievements);
            Controls.Add(lbl_Badge);
            Controls.Add(lbl_Score);
            Controls.Add(lbl_Level);
            Controls.Add(lbl_Welcome);
            Name = "DashboardControl";
            Size = new Size(1024, 720);
            
            ((System.ComponentModel.ISupportInitialize)ChildLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Welcome;
        private Label lbl_Level;
        private Label lbl_Score;
        private Label lbl_Badge;
        private Button btn_Achievements;
        private Button btn_Profile;
        private Label label5;
        private Button btn_Play;
        private Label TitleLable;
        private PictureBox ChildLogo;
    }
}
