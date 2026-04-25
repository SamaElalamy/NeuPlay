namespace NeuPlay
{
    partial class ResultControlcs
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
            label1 = new Label();
            lbl_FinalResult = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1024, 48);
            label1.TabIndex = 3;
            label1.Text = "Result Of The Test";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_FinalResult
            // 
            lbl_FinalResult.BackColor = SystemColors.ButtonHighlight;
            lbl_FinalResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_FinalResult.ImageAlign = ContentAlignment.TopCenter;
            lbl_FinalResult.Location = new Point(32, 152);
            lbl_FinalResult.Name = "lbl_FinalResult";
            lbl_FinalResult.Size = new Size(928, 48);
            lbl_FinalResult.TabIndex = 4;
            lbl_FinalResult.Text = "Result Of The Test";
            lbl_FinalResult.TextAlign = ContentAlignment.MiddleCenter;
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
            guna2Button1.Location = new Point(394, 387);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "create an account";
            guna2Button1.Click += btn_GoToLogin_Click_1;
            // 
            // ResultControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(lbl_FinalResult);
            Controls.Add(label1);
            Name = "ResultControlcs";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_FinalResult;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
