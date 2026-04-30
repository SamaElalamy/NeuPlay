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
            label4 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            registringbtn = new RoundedButton();
            btn_LogIn = new RoundedButton();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(106, 36, 138);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(249, 235, 249);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 72);
            label4.TabIndex = 9;
            label4.Text = "Log in:";
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(249, 235, 249);
            Username.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Username.ForeColor = Color.FromArgb(21, 12, 126);
            Username.Location = new Point(198, 3);
            Username.Name = "Username";
            Username.Size = new Size(234, 39);
            Username.TabIndex = 19;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(249, 235, 249);
            Password.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Password.ForeColor = Color.FromArgb(21, 12, 126);
            Password.Location = new Point(189, 3);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(227, 39);
            Password.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 23;
            label1.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 46);
            label3.TabIndex = 24;
            label3.Text = "Password:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(Username);
            flowLayoutPanel1.Location = new Point(40, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(440, 64);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(Password);
            flowLayoutPanel2.Location = new Point(40, 248);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(424, 72);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // registringbtn
            // 
            registringbtn.BackColor = Color.FromArgb(106, 36, 138);
            registringbtn.BorderRadius = 20;
            registringbtn.FlatAppearance.BorderSize = 0;
            registringbtn.FlatStyle = FlatStyle.Flat;
            registringbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registringbtn.ForeColor = Color.FromArgb(217, 214, 224);
            registringbtn.Location = new Point(552, 488);
            registringbtn.Name = "registringbtn";
            registringbtn.Size = new Size(296, 61);
            registringbtn.TabIndex = 28;
            registringbtn.Text = "Don't have an account? Register Now";
            registringbtn.UseVisualStyleBackColor = false;
            registringbtn.Click += registringbtn_Click;
            // 
            // btn_LogIn
            // 
            btn_LogIn.BackColor = Color.FromArgb(106, 36, 138);
            btn_LogIn.BorderRadius = 20;
            btn_LogIn.FlatAppearance.BorderSize = 0;
            btn_LogIn.FlatStyle = FlatStyle.Flat;
            btn_LogIn.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_LogIn.ForeColor = Color.FromArgb(217, 214, 224);
            btn_LogIn.Location = new Point(160, 488);
            btn_LogIn.Name = "btn_LogIn";
            btn_LogIn.Size = new Size(144, 61);
            btn_LogIn.TabIndex = 27;
            btn_LogIn.Text = "Log in";
            btn_LogIn.UseVisualStyleBackColor = false;
            btn_LogIn.Click += btn_LogIn_Click;
            // 
            // LoginScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(registringbtn);
            Controls.Add(btn_LogIn);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Name = "LoginScreenControl";
            Size = new Size(1024, 720);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RoundedButton registringbtn;
        private RoundedButton btn_LogIn;
    }
}
