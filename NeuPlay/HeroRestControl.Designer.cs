namespace NeuPlay
{
    partial class HeroRestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroRestControl));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Tips = new Button();
            btn_Stories = new Button();
            btn_Parental = new Button();
            BACK = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1024, 104);
            label1.TabIndex = 3;
            label1.Text = "Hero's Rest Core";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_Tips);
            flowLayoutPanel1.Controls.Add(btn_Stories);
            flowLayoutPanel1.Controls.Add(btn_Parental);
            flowLayoutPanel1.Location = new Point(168, 160);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(728, 248);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_Tips
            // 
            btn_Tips.BackgroundImage = Properties.Resources.Gemini_Generated_Image_dlrhzldlrhzldlrh__1_1;
            btn_Tips.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Tips.Location = new Point(3, 3);
            btn_Tips.Name = "btn_Tips";
            btn_Tips.Size = new Size(229, 237);
            btn_Tips.TabIndex = 0;
            btn_Tips.UseVisualStyleBackColor = true;
            btn_Tips.Click += btn_Tips_Click;
            // 
            // btn_Stories
            // 
            btn_Stories.BackgroundImage = (Image)resources.GetObject("btn_Stories.BackgroundImage");
            btn_Stories.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Stories.Location = new Point(238, 3);
            btn_Stories.Name = "btn_Stories";
            btn_Stories.Size = new Size(229, 237);
            btn_Stories.TabIndex = 1;
            btn_Stories.UseVisualStyleBackColor = true;
            btn_Stories.Click += btn_Stories_Click;
            // 
            // btn_Parental
            // 
            btn_Parental.BackgroundImage = (Image)resources.GetObject("btn_Parental.BackgroundImage");
            btn_Parental.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Parental.Location = new Point(473, 3);
            btn_Parental.Name = "btn_Parental";
            btn_Parental.Size = new Size(229, 237);
            btn_Parental.TabIndex = 2;
            btn_Parental.UseVisualStyleBackColor = true;
            btn_Parental.Click += btn_Parental_Click;
            // 
            // BACK
            // 
            BACK.Location = new Point(16, 472);
            BACK.Name = "BACK";
            BACK.Size = new Size(136, 45);
            BACK.TabIndex = 5;
            BACK.Text = "Back to Services";
            BACK.UseVisualStyleBackColor = true;
            BACK.Click += BACK_Click;
            // 
            // HeroRestControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BACK);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "HeroRestControl";
            Size = new Size(1024, 720);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Tips;
        private Button btn_Stories;
        private Button btn_Parental;
        private Button BACK;
    }
}
