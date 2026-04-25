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
<<<<<<< HEAD
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
=======
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_Login = new Button();
            btn_GoToRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(144, 160);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 0;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(144, 88);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(125, 27);
            txt_Username.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(144, 456);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(120, 53);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Log in";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_GoToRegister
            // 
            btn_GoToRegister.Location = new Point(648, 456);
            btn_GoToRegister.Name = "btn_GoToRegister";
            btn_GoToRegister.Size = new Size(198, 53);
            btn_GoToRegister.TabIndex = 3;
            btn_GoToRegister.Text = "Don't have an account? Register Now";
            btn_GoToRegister.UseVisualStyleBackColor = true;
            btn_GoToRegister.Click += btn_GoToRegister_Click;
            // 
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
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
<<<<<<< HEAD
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
            guna2Button1.Location = new Point(160, 456);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(143, 53);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "Log in";
            guna2Button1.Click += btn_Login_Click;
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
            guna2Button2.Location = new Point(641, 456);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(214, 53);
            guna2Button2.TabIndex = 11;
            guna2Button2.Text = "Don't have an account? Register Now";
            guna2Button2.Click += btn_GoToRegister_Click;
            // 
            // txt_Username
            // 
            txt_Username.BorderColor = Color.LightGray;
            txt_Username.BorderRadius = 15;
            txt_Username.CustomizableEdges = customizableEdges5;
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
            txt_Username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_Username.Size = new Size(125, 27);
            txt_Username.TabIndex = 12;
            // 
            // txt_Password
            // 
            txt_Password.BorderColor = Color.LightGray;
            txt_Password.BorderRadius = 15;
            txt_Password.CustomizableEdges = customizableEdges7;
            txt_Password.DefaultText = "";
            txt_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Password.FocusedState.BorderColor = Color.DodgerBlue;
            txt_Password.Font = new Font("Segoe UI", 9F);
            txt_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Password.Location = new Point(144, 160);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "";
            txt_Password.SelectedText = "";
            txt_Password.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 13;
            // 
=======
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
            // LoginScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
=======
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_GoToRegister);
            Controls.Add(btn_Login);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
            Name = "LoginScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
<<<<<<< HEAD
        private Label label1;
        private Label label2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
=======

        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Login;
        private Button btn_GoToRegister;
        private Label label1;
        private Label label2;
        private Label label4;
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
    }
}
