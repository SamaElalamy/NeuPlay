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
            BACKbtn = new RoundedButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 127, 255);
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
            flowLayoutPanel1.Location = new Point(96, 176);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(808, 336);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_Tips
            // 
            btn_Tips.BackColor = Color.FromArgb(255, 211, 91);
            btn_Tips.BackgroundImage = (Image)resources.GetObject("btn_Tips.BackgroundImage");
            btn_Tips.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Tips.Location = new Point(3, 3);
            btn_Tips.Name = "btn_Tips";
            btn_Tips.Size = new Size(269, 325);
            btn_Tips.TabIndex = 0;
            btn_Tips.UseVisualStyleBackColor = false;
            btn_Tips.Click += btn_Tips_Click;
            // 
            // btn_Stories
            // 
            btn_Stories.BackColor = Color.FromArgb(255, 211, 91);
            btn_Stories.BackgroundImage = (Image)resources.GetObject("btn_Stories.BackgroundImage");
            btn_Stories.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Stories.Location = new Point(278, 3);
            btn_Stories.Name = "btn_Stories";
            btn_Stories.Size = new Size(250, 325);
            btn_Stories.TabIndex = 1;
            btn_Stories.UseVisualStyleBackColor = false;
            btn_Stories.Click += btn_Stories_Click;
            // 
            // btn_Parental
            // 
            btn_Parental.BackColor = Color.FromArgb(255, 211, 91);
            btn_Parental.BackgroundImage = (Image)resources.GetObject("btn_Parental.BackgroundImage");
            btn_Parental.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Parental.Location = new Point(534, 3);
            btn_Parental.Name = "btn_Parental";
            btn_Parental.Size = new Size(258, 325);
            btn_Parental.TabIndex = 2;
            btn_Parental.UseVisualStyleBackColor = false;
            btn_Parental.Click += btn_Parental_Click;
            // 
            // BACKbtn
            // 
            BACKbtn.BackColor = Color.FromArgb(91, 127, 255);
            BACKbtn.BorderRadius = 20;
            BACKbtn.FlatAppearance.BorderSize = 0;
            BACKbtn.FlatStyle = FlatStyle.Flat;
            BACKbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BACKbtn.ForeColor = Color.White;
            BACKbtn.Location = new Point(24, 584);
            BACKbtn.Name = "BACKbtn";
            BACKbtn.Size = new Size(160, 64);
            BACKbtn.TabIndex = 6;
            BACKbtn.Text = "Back to Services";
            BACKbtn.UseVisualStyleBackColor = false;
            BACKbtn.Click += BACKbtn_Click;
            // 
            // HeroRestControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 227, 151);
            Controls.Add(BACKbtn);
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
        private RoundedButton BACKbtn;
    }
}
