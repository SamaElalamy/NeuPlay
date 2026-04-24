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
            // LoginScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_GoToRegister);
            Controls.Add(btn_Login);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Name = "LoginScreenControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Login;
        private Button btn_GoToRegister;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}
