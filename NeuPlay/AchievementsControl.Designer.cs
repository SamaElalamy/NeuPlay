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
            roundedButton1 = new RoundedButton();
            pictureBox1 = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            flp_Achievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            flp_Achievements.Controls.Add(pictureBox1);
            flp_Achievements.Location = new Point(48, 112);
            flp_Achievements.Name = "flp_Achievements";
            flp_Achievements.Size = new Size(944, 496);
            flp_Achievements.TabIndex = 14;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BorderRadius = 20;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(464, 608);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(134, 69);
            roundedButton1.TabIndex = 21;
            roundedButton1.Text = "Back";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_May_1__2026__12_26_09_PM;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(525, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
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
            // 
            // AchievementsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedButton1);
            Controls.Add(flp_Achievements);
            Controls.Add(label5);
            ForeColor = Color.FromArgb(249, 235, 249);
            Name = "AchievementsControl";
            Size = new Size(1024, 720);
            flp_Achievements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private FlowLayoutPanel flp_Achievements;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button btnback;
        private RoundedButton roundedButton1;
        private PictureBox pictureBox1;
    }
}
