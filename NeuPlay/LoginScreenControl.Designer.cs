namespace NeuPlay
{
    partial class LoginScreenControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 96);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 48);
            label4.TabIndex = 9;
            label4.Text = "Log in";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(116, 456);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(140, 53);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Log in";
            guna2Button1.Click += btn_Login_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges11;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(636, 456);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Button2.Size = new Size(225, 53);
            guna2Button2.TabIndex = 11;
            guna2Button2.Text = "Don't have an account? Register Now";
            guna2Button2.Click += btn_GoToRegister_Click;
            // 
            // txt_Username
            // 
            txt_Username.BorderColor = Color.LightGray;
            txt_Username.BorderRadius = 15;
            txt_Username.CustomizableEdges = customizableEdges13;
            txt_Username.DefaultText = "";
            txt_Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Username.FocusedState.BorderColor = Color.DodgerBlue;
            txt_Username.Font = new Font("Segoe UI", 9F);
            txt_Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Username.Location = new Point(144, 96);
            txt_Username.Margin = new Padding(3, 4, 3, 4);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "";
            txt_Username.SelectedText = "";
            txt_Username.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txt_Username.Size = new Size(125, 27);
            txt_Username.TabIndex = 12;
            // 
            // txt_Password
            // 
            txt_Password.BorderColor = Color.LightGray;
            txt_Password.BorderRadius = 15;
            txt_Password.CustomizableEdges = customizableEdges15;
            txt_Password.DefaultText = "";
            txt_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Password.FocusedState.BorderColor = Color.DodgerBlue;
            txt_Password.Font = new Font("Segoe UI", 9F);
            txt_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Password.Location = new Point(144, 153);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "";
            txt_Password.SelectedText = "";
            txt_Password.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 13;
            // 
            // LoginScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
    }
}
