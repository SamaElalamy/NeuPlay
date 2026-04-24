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
            btn_Register = new Button();
            btn_BackToLogin = new Button();
            txt_NewUsername = new TextBox();
            txt_NewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_ConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmb_Age = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(256, 480);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(136, 53);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_BackToLogin
            // 
            btn_BackToLogin.Location = new Point(584, 480);
            btn_BackToLogin.Name = "btn_BackToLogin";
            btn_BackToLogin.Size = new Size(192, 56);
            btn_BackToLogin.TabIndex = 1;
            btn_BackToLogin.Text = "I have already an Account";
            btn_BackToLogin.UseVisualStyleBackColor = true;
            btn_BackToLogin.Click += btn_BackToLogin_Click;
            // 
            // txt_NewUsername
            // 
            txt_NewUsername.Location = new Point(216, 72);
            txt_NewUsername.Name = "txt_NewUsername";
            txt_NewUsername.Size = new Size(125, 27);
            txt_NewUsername.TabIndex = 2;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.Location = new Point(208, 144);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.PasswordChar = '*';
            txt_NewPassword.Size = new Size(125, 27);
            txt_NewPassword.TabIndex = 3;
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
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Location = new Point(208, 216);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.PasswordChar = '*';
            txt_ConfirmPassword.Size = new Size(125, 27);
            txt_ConfirmPassword.TabIndex = 6;
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
            // RegisterScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(cmb_Age);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_NewPassword);
            Controls.Add(txt_NewUsername);
            Controls.Add(btn_BackToLogin);
            Controls.Add(btn_Register);
            Name = "RegisterScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register;
        private Button btn_BackToLogin;
        private TextBox txt_NewUsername;
        private TextBox txt_NewPassword;
        private Label label1;
        private Label label2;
        private TextBox txt_ConfirmPassword;
        private Label label3;
        private Label label4;
        private ComboBox cmb_Age;
        private Label label5;
    }
}
