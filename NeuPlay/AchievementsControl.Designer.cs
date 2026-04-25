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
            btnback = new Button();
            label5 = new Label();
            flp_Achievements = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(24, 496);
            btnback.Name = "btnback";
            btnback.Size = new Size(128, 56);
            btnback.TabIndex = 12;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btn_Back_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 48);
            label5.TabIndex = 13;
            label5.Text = "My Achievements";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flp_Achievements
            // 
            flp_Achievements.Location = new Point(48, 72);
            flp_Achievements.Name = "flp_Achievements";
            flp_Achievements.Size = new Size(944, 408);
            flp_Achievements.TabIndex = 14;
            // 
            // AchievementsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_Achievements);
            Controls.Add(label5);
            Controls.Add(btnback);
            Name = "AchievementsControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private Button btnback;
        private Label label5;
        private FlowLayoutPanel flp_Achievements;
    }
}
