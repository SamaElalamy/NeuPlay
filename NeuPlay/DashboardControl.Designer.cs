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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            lbl_Welcome = new Label();
            lbl_Level = new Label();
            lbl_Score = new Label();
            lbl_Badge = new Label();
            btn_Achievements = new Button();
            btn_Profile = new Button();
            label5 = new Label();
            TitleLable = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LetsPlaybtn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.AutoSize = true;
            lbl_Welcome.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Welcome.ForeColor = Color.FromArgb(217, 214, 224);
            lbl_Welcome.Location = new Point(3, 0);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(139, 46);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "Hello,";
            lbl_Welcome.Click += lbl_Welcome_Click;
            // 
            // lbl_Level
            // 
            lbl_Level.AutoSize = true;
            lbl_Level.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Level.ForeColor = Color.FromArgb(217, 214, 224);
            lbl_Level.Location = new Point(3, 0);
            lbl_Level.Name = "lbl_Level";
            lbl_Level.Size = new Size(192, 46);
            lbl_Level.TabIndex = 1;
            lbl_Level.Text = "level no.";
            // 
            // lbl_Score
            // 
            lbl_Score.AutoSize = true;
            lbl_Score.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Score.ForeColor = Color.FromArgb(217, 214, 224);
            lbl_Score.Location = new Point(3, 0);
            lbl_Score.Name = "lbl_Score";
            lbl_Score.Size = new Size(301, 46);
            lbl_Score.TabIndex = 2;
            lbl_Score.Text = "current score";
            lbl_Score.Click += lbl_Score_Click;
            // 
            // lbl_Badge
            // 
            lbl_Badge.AutoSize = true;
            lbl_Badge.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Badge.ForeColor = Color.FromArgb(217, 214, 224);
            lbl_Badge.Location = new Point(144, 0);
            lbl_Badge.Name = "lbl_Badge";
            lbl_Badge.Size = new Size(254, 46);
            lbl_Badge.TabIndex = 3;
            lbl_Badge.Text = "Badge/Title";
            // 
            // btn_Achievements
            // 
            btn_Achievements.BackColor = Color.FromArgb(106, 36, 138);
            btn_Achievements.BackgroundImage = (Image)resources.GetObject("btn_Achievements.BackgroundImage");
            btn_Achievements.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Achievements.Location = new Point(3, 3);
            btn_Achievements.Name = "btn_Achievements";
            btn_Achievements.Size = new Size(264, 280);
            btn_Achievements.TabIndex = 4;
            btn_Achievements.UseVisualStyleBackColor = false;
            btn_Achievements.Click += btn_Achievements_Click;
            // 
            // btn_Profile
            // 
            btn_Profile.BackColor = Color.FromArgb(106, 36, 138);
            btn_Profile.BackgroundImage = (Image)resources.GetObject("btn_Profile.BackgroundImage");
            btn_Profile.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Profile.ForeColor = Color.FromArgb(255, 211, 91);
            btn_Profile.Location = new Point(543, 3);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(264, 277);
            btn_Profile.TabIndex = 5;
            btn_Profile.UseVisualStyleBackColor = false;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(249, 235, 249);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(106, 36, 138);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 80);
            label5.TabIndex = 9;
            label5.Text = "Dashboard:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLable.ForeColor = Color.FromArgb(217, 214, 224);
            TitleLable.Location = new Point(3, 0);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(135, 46);
            TitleLable.TabIndex = 11;
            TitleLable.Text = "Title: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(106, 36, 138);
            flowLayoutPanel1.Controls.Add(btn_Achievements);
            flowLayoutPanel1.Controls.Add(LetsPlaybtn);
            flowLayoutPanel1.Controls.Add(btn_Profile);
            flowLayoutPanel1.Location = new Point(80, 376);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(832, 296);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // LetsPlaybtn
            // 
            LetsPlaybtn.BackColor = Color.FromArgb(106, 36, 138);
            LetsPlaybtn.BackgroundImage = (Image)resources.GetObject("LetsPlaybtn.BackgroundImage");
            LetsPlaybtn.BackgroundImageLayout = ImageLayout.Zoom;
            LetsPlaybtn.Location = new Point(273, 3);
            LetsPlaybtn.Name = "LetsPlaybtn";
            LetsPlaybtn.Size = new Size(264, 277);
            LetsPlaybtn.TabIndex = 6;
            LetsPlaybtn.UseVisualStyleBackColor = false;
            LetsPlaybtn.Click += btn_Play_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lbl_Welcome);
            flowLayoutPanel2.Location = new Point(8, 88);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(984, 56);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(TitleLable);
            flowLayoutPanel3.Controls.Add(lbl_Badge);
            flowLayoutPanel3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel3.Location = new Point(8, 280);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(984, 56);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lbl_Score);
            flowLayoutPanel4.Location = new Point(8, 152);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(984, 56);
            flowLayoutPanel4.TabIndex = 16;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(lbl_Level);
            flowLayoutPanel5.Location = new Point(8, 216);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(984, 56);
            flowLayoutPanel5.TabIndex = 15;
            // 
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(106, 36, 138);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Name = "DashboardControl";
            Size = new Size(1024, 720);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Welcome;
        private Label lbl_Level;
        private Label lbl_Score;
        private Label lbl_Badge;
        private Button btn_Achievements;
        private Button btn_Profile;
        private Label label5;
        private Label TitleLable;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button LetsPlaybtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
    }
}
