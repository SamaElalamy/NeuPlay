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
            label1 = new Label();
            lbl_FinalResult = new Label();
            btn_GoToLogin = new Button();
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
            // btn_GoToLogin
            // 
            btn_GoToLogin.Location = new Point(400, 376);
            btn_GoToLogin.Name = "btn_GoToLogin";
            btn_GoToLogin.Size = new Size(198, 85);
            btn_GoToLogin.TabIndex = 5;
            btn_GoToLogin.Text = "create an account";
            btn_GoToLogin.UseVisualStyleBackColor = true;
            btn_GoToLogin.Click += btn_GoToLogin_Click_1;
            // 
            // ResultControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_GoToLogin);
            Controls.Add(lbl_FinalResult);
            Controls.Add(label1);
            Name = "ResultControlcs";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_FinalResult;
        private Button btn_GoToLogin;
    }
}
