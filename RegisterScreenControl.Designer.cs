namespace NeuPlay
{
    partial class RegisterScreenControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmb_Age = new ComboBox();
            label5 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            txt_NewUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txt_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txt_ConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 80);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 152);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 224);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 48);
            label4.TabIndex = 8;
            label4.Text = "Sign in";
            // 
            // cmb_Age
            // 
            cmb_Age.FormattingEnabled = true;
            cmb_Age.Items.AddRange(new object[] { "4", "5", "6", "7", "8" });
            cmb_Age.Location = new Point(208, 288);
            cmb_Age.Name = "cmb_Age";
            cmb_Age.Size = new Size(151, 28);
            cmb_Age.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 296);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 10;
            label5.Text = "Age";
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
            guna2Button1.Location = new Point(208, 480);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Register";
            guna2Button1.Click += btn_Register_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(630, 480);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(225, 56);
            guna2Button2.TabIndex = 12;
            guna2Button2.Text = "I have already an Account";
            guna2Button2.Click += btn_BackToLogin_Click;
            // 
            // txt_NewUsername
            // 
            txt_NewUsername.BorderColor = Color.LightGray;
            txt_NewUsername.BorderRadius = 15;
            txt_NewUsername.CustomizableEdges = customizableEdges5;
            txt_NewUsername.DefaultText = "";
            txt_NewUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_NewUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_NewUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_NewUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_NewUsername.FocusedState.BorderColor = Color.DodgerBlue;
            txt_NewUsername.Font = new Font("Segoe UI", 12F);
            txt_NewUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NewUsername.Location = new Point(208, 80);
            txt_NewUsername.Margin = new Padding(4, 6, 4, 6);
            txt_NewUsername.Name = "txt_NewUsername";
            txt_NewUsername.PlaceholderText = "";
            txt_NewUsername.SelectedText = "";
            txt_NewUsername.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_NewUsername.Size = new Size(151, 27);
            txt_NewUsername.TabIndex = 15;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.BorderColor = Color.LightGray;
            txt_NewPassword.BorderRadius = 15;
            txt_NewPassword.CustomizableEdges = customizableEdges7;
            txt_NewPassword.DefaultText = "";
            txt_NewPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_NewPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_NewPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_NewPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_NewPassword.FocusedState.BorderColor = Color.DodgerBlue;
            txt_NewPassword.Font = new Font("Segoe UI", 12F);
            txt_NewPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_NewPassword.Location = new Point(208, 152);
            txt_NewPassword.Margin = new Padding(4, 6, 4, 6);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.PlaceholderText = "";
            txt_NewPassword.SelectedText = "";
            txt_NewPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_NewPassword.Size = new Size(151, 27);
            txt_NewPassword.TabIndex = 16;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.BorderColor = Color.LightGray;
            txt_ConfirmPassword.BorderRadius = 15;
            txt_ConfirmPassword.CustomizableEdges = customizableEdges9;
            txt_ConfirmPassword.DefaultText = "";
            txt_ConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_ConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_ConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_ConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_ConfirmPassword.FocusedState.BorderColor = Color.DodgerBlue;
            txt_ConfirmPassword.Font = new Font("Segoe UI", 12F);
            txt_ConfirmPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_ConfirmPassword.Location = new Point(208, 217);
            txt_ConfirmPassword.Margin = new Padding(4, 6, 4, 6);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.PlaceholderText = "";
            txt_ConfirmPassword.SelectedText = "";
            txt_ConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_ConfirmPassword.Size = new Size(151, 27);
            txt_ConfirmPassword.TabIndex = 17;
            // 
            // RegisterScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(txt_NewPassword);
            Controls.Add(txt_NewUsername);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label5);
            Controls.Add(cmb_Age);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmb_Age;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_NewUsername;
        private Guna.UI2.WinForms.Guna2TextBox txt_NewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_ConfirmPassword;
    }
}
