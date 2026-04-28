namespace NeuPlay
{
    partial class HeroRestViewerControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pic_Content = new PictureBox();
            btnPre = new Guna.UI2.WinForms.Guna2Button();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pic_Content).BeginInit();
            SuspendLayout();
            // 
            // pic_Content
            // 
            pic_Content.Location = new Point(264, 56);
            pic_Content.Name = "pic_Content";
            pic_Content.Size = new Size(488, 432);
            pic_Content.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Content.TabIndex = 0;
            pic_Content.TabStop = false;
            pic_Content.Click += pic_Content_Click;
            // 
            // btnPre
            // 
            btnPre.BorderRadius = 15;
            btnPre.CustomizableEdges = customizableEdges7;
            btnPre.DisabledState.BorderColor = Color.DarkGray;
            btnPre.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPre.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPre.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPre.Font = new Font("Segoe UI", 9F);
            btnPre.ForeColor = Color.White;
            btnPre.Location = new Point(306, 520);
            btnPre.Name = "btnPre";
            btnPre.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnPre.Size = new Size(94, 29);
            btnPre.TabIndex = 7;
            btnPre.Text = "Previous";
            btnPre.Click += btn_Prev_Click;
            // 
            // btnNext
            // 
            btnNext.BorderRadius = 15;
            btnNext.CustomizableEdges = customizableEdges9;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(585, 520);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.Click += btn_Next_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 15;
            guna2Button3.CustomizableEdges = customizableEdges11;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(13, 18);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button3.Size = new Size(136, 45);
            guna2Button3.TabIndex = 9;
            guna2Button3.Text = "Back to Core";
            guna2Button3.Click += btn_Back_Click;
            // 
            // HeroRestViewerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button3);
            Controls.Add(btnNext);
            Controls.Add(btnPre);
            Controls.Add(pic_Content);
            Name = "HeroRestViewerControl";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pic_Content).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Content;
        private Guna.UI2.WinForms.Guna2Button btnPre;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
