namespace NeuPlay
{
    partial class ProfileControl
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
            label2 = new Label();
            label3 = new Label();
            txt_Name = new TextBox();
            txt_Age = new TextBox();
            txt_Password = new TextBox();
            label5 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 56);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 128);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 13;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 208);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(120, 64);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(125, 27);
            txt_Name.TabIndex = 15;
            // 
            // txt_Age
            // 
            txt_Age.Location = new Point(120, 136);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(125, 27);
            txt_Age.TabIndex = 16;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(128, 208);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.ReadOnly = true;
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 17;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 48);
            label5.TabIndex = 18;
            label5.Text = "My Profile";
            label5.TextAlign = ContentAlignment.TopCenter;
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
            guna2Button1.Location = new Point(24, 492);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(128, 56);
            guna2Button1.TabIndex = 19;
            guna2Button1.Text = "Back";
            guna2Button1.Click += btn_Back_Click;
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Button1);
            Controls.Add(label5);
            Controls.Add(txt_Password);
            Controls.Add(txt_Age);
            Controls.Add(txt_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Name;
        private TextBox txt_Age;
        private TextBox txt_Password;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
