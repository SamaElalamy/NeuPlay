namespace NeuPlay
{
    partial class ServicesScreenControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesScreenControl));
            btn_SpellQuest = new Button();
            btn_NumbersLand = new Button();
            btn_HeroRest = new Button();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btn_SpellQuest
            // 
            btn_SpellQuest.BackgroundImage = Properties.Resources.ChatGPT_Image_Apr_22__2026__08_48_33_PM;
            btn_SpellQuest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_SpellQuest.FlatAppearance.BorderSize = 0;
            btn_SpellQuest.FlatStyle = FlatStyle.Flat;
            btn_SpellQuest.Location = new Point(24, 216);
            btn_SpellQuest.Name = "btn_SpellQuest";
            btn_SpellQuest.Size = new Size(312, 344);
            btn_SpellQuest.TabIndex = 1;
            btn_SpellQuest.UseVisualStyleBackColor = true;
            btn_SpellQuest.Click += btn_SpellQuest_Click_1;
            // 
            // btn_NumbersLand
            // 
            btn_NumbersLand.BackgroundImage = (Image)resources.GetObject("btn_NumbersLand.BackgroundImage");
            btn_NumbersLand.BackgroundImageLayout = ImageLayout.Zoom;
            btn_NumbersLand.FlatAppearance.BorderSize = 0;
            btn_NumbersLand.FlatStyle = FlatStyle.Flat;
            btn_NumbersLand.Location = new Point(352, 216);
            btn_NumbersLand.Name = "btn_NumbersLand";
            btn_NumbersLand.Size = new Size(312, 344);
            btn_NumbersLand.TabIndex = 2;
            btn_NumbersLand.UseVisualStyleBackColor = true;
            btn_NumbersLand.Click += btn_NumbersLand_Click;
            // 
            // btn_HeroRest
            // 
            btn_HeroRest.BackColor = Color.LavenderBlush;
            btn_HeroRest.BackgroundImage = (Image)resources.GetObject("btn_HeroRest.BackgroundImage");
            btn_HeroRest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_HeroRest.FlatAppearance.BorderSize = 0;
            btn_HeroRest.FlatStyle = FlatStyle.Flat;
            btn_HeroRest.Location = new Point(680, 216);
            btn_HeroRest.Name = "btn_HeroRest";
            btn_HeroRest.Size = new Size(312, 344);
            btn_HeroRest.TabIndex = 3;
            btn_HeroRest.UseVisualStyleBackColor = false;
            btn_HeroRest.Click += btn_HeroRest_Click_1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1024, 128);
            label2.TabIndex = 4;
            label2.Text = "Choose Your Path !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new Point(16, 152);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // ServicesScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(btn_HeroRest);
            Controls.Add(btn_NumbersLand);
            Controls.Add(btn_SpellQuest);
            Name = "ServicesScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_SpellQuest;
        private Button btn_NumbersLand;
        private Button btn_HeroRest;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
