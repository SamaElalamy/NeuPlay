namespace NeuPlay
{
    partial class NumbersLand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumbersLand));
            label4 = new Label();
            btn_Start = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(246, 202, 78);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 120);
            label4.TabIndex = 9;
            label4.Text = "Numbers' Land";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Start
            // 
            btn_Start.BackgroundImage = (Image)resources.GetObject("btn_Start.BackgroundImage");
            btn_Start.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Start.FlatAppearance.BorderSize = 0;
            btn_Start.FlatStyle = FlatStyle.Flat;
            btn_Start.Location = new Point(320, 168);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(344, 328);
            btn_Start.TabIndex = 11;
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
          
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 638);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(123, 41);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "Back";
            guna2Button1.Click += btn_Back_Click;
            // 
            // NumbersLand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(btn_Start);
            Controls.Add(label4);
            Name = "NumbersLand";
            Size = new Size(1024, 720);
            Load += NumbersLand_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Button btn_Start;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
