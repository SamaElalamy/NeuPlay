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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Name = new TextBox();
            txt_Age = new TextBox();
            txt_Password = new TextBox();
            label5 = new Label();
            roundedButton1 = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Bold);
            label1.Location = new Point(24, 152);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Bold);
            label2.Location = new Point(24, 224);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 13;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Bold);
            label3.Location = new Point(32, 304);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(136, 152);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(192, 27);
            txt_Name.TabIndex = 15;
            // 
            // txt_Age
            // 
            txt_Age.Location = new Point(120, 232);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(80, 27);
            txt_Age.TabIndex = 16;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(200, 304);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.ReadOnly = true;
            txt_Password.Size = new Size(160, 27);
            txt_Password.TabIndex = 17;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(155, 111, 255);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(249, 235, 249);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1024, 88);
            label5.TabIndex = 18;
            label5.Text = "My Profile";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BorderRadius = 20;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(16, 592);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(134, 69);
            roundedButton1.TabIndex = 20;
            roundedButton1.Text = "Back";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(roundedButton1);
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
        private RoundedButton roundedButton1;
    }
}
