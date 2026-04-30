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
            label1 = new Label();
            label4 = new Label();
            NewUsername = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            NewPassword = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            ConfirmPassword = new TextBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label5 = new Label();
            cmb_Age = new ComboBox();
            LogInbtn = new RoundedButton();
            btnRegister = new RoundedButton();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(106, 36, 138);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(217, 214, 224);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 72);
            label4.TabIndex = 8;
            label4.Text = "Sign Up:";
            // 
            // NewUsername
            // 
            NewUsername.BackColor = Color.FromArgb(249, 235, 249);
            NewUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NewUsername.ForeColor = Color.FromArgb(21, 12, 126);
            NewUsername.Location = new Point(198, 3);
            NewUsername.Name = "NewUsername";
            NewUsername.Size = new Size(186, 39);
            NewUsername.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(NewUsername);
            flowLayoutPanel1.Location = new Point(32, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(408, 64);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(NewPassword);
            flowLayoutPanel2.Location = new Point(24, 328);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(402, 64);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 46);
            label2.TabIndex = 20;
            label2.Text = "Password:";
            // 
            // NewPassword
            // 
            NewPassword.BackColor = Color.FromArgb(249, 235, 249);
            NewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NewPassword.ForeColor = Color.FromArgb(21, 12, 126);
            NewPassword.Location = new Point(189, 3);
            NewPassword.Name = "NewPassword";
            NewPassword.PasswordChar = '*';
            NewPassword.Size = new Size(179, 39);
            NewPassword.TabIndex = 21;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(ConfirmPassword);
            flowLayoutPanel3.Location = new Point(24, 440);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(520, 64);
            flowLayoutPanel3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(320, 46);
            label3.TabIndex = 21;
            label3.Text = "Confirm Password:";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.BackColor = Color.FromArgb(249, 235, 249);
            ConfirmPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ConfirmPassword.ForeColor = Color.FromArgb(21, 12, 126);
            ConfirmPassword.Location = new Point(329, 3);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.Size = new Size(167, 39);
            ConfirmPassword.TabIndex = 22;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(cmb_Age);
            flowLayoutPanel4.Location = new Point(32, 232);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(264, 56);
            flowLayoutPanel4.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 46);
            label5.TabIndex = 12;
            label5.Text = "Age:";
            // 
            // cmb_Age
            // 
            cmb_Age.BackColor = Color.FromArgb(249, 235, 249);
            cmb_Age.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cmb_Age.ForeColor = Color.FromArgb(21, 12, 126);
            cmb_Age.FormattingEnabled = true;
            cmb_Age.Items.AddRange(new object[] { "4", "5", "6", "7", "8" });
            cmb_Age.Location = new Point(101, 3);
            cmb_Age.Name = "cmb_Age";
            cmb_Age.Size = new Size(151, 39);
            cmb_Age.TabIndex = 11;
            // 
            // LogInbtn
            // 
            LogInbtn.BackColor = Color.FromArgb(106, 36, 138);
            LogInbtn.BorderRadius = 20;
            LogInbtn.FlatAppearance.BorderSize = 0;
            LogInbtn.FlatStyle = FlatStyle.Flat;
            LogInbtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbtn.ForeColor = Color.FromArgb(217, 214, 224);
            LogInbtn.Location = new Point(520, 576);
            LogInbtn.Name = "LogInbtn";
            LogInbtn.Size = new Size(296, 61);
            LogInbtn.TabIndex = 26;
            LogInbtn.Text = "I have already an account";
            LogInbtn.UseVisualStyleBackColor = false;
            LogInbtn.Click += LogInbtn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(106, 36, 138);
            btnRegister.BorderRadius = 20;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(217, 214, 224);
            btnRegister.Location = new Point(128, 576);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(144, 61);
            btnRegister.TabIndex = 25;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterScreenControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(LogInbtn);
            Controls.Add(btnRegister);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Name = "RegisterScreenControl";
            Size = new Size(1024, 720);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label4;
        private TextBox NewUsername;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox NewPassword;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private TextBox ConfirmPassword;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label5;
        private ComboBox cmb_Age;
        private RoundedButton LogInbtn;
        private RoundedButton btnRegister;
    }
}
