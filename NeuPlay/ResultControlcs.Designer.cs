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
            CreatingAccountbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(155, 111, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(249, 235, 249);
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
            lbl_FinalResult.Location = new Point(296, 160);
            lbl_FinalResult.Name = "lbl_FinalResult";
            lbl_FinalResult.Size = new Size(400, 96);
            lbl_FinalResult.TabIndex = 4;
            lbl_FinalResult.Text = "Result Of The Test";
            lbl_FinalResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreatingAccountbtn
            // 
            CreatingAccountbtn.BackColor = Color.FromArgb(155, 111, 255);
            CreatingAccountbtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatingAccountbtn.ForeColor = Color.FromArgb(249, 235, 249);
            CreatingAccountbtn.Location = new Point(336, 360);
            CreatingAccountbtn.Name = "CreatingAccountbtn";
            CreatingAccountbtn.Size = new Size(320, 61);
            CreatingAccountbtn.TabIndex = 5;
            CreatingAccountbtn.Text = "Log in to your account";
            CreatingAccountbtn.UseVisualStyleBackColor = false;
            CreatingAccountbtn.Click += CreatingAccountbtn_Click;
            // 
            // ResultControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(CreatingAccountbtn);
            Controls.Add(lbl_FinalResult);
            Controls.Add(label1);
            Name = "ResultControlcs";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_FinalResult;
        private Button CreatingAccountbtn;
    }
}
