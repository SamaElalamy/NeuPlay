namespace NeuPlay
{
    partial class PrivacyPolicyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivacyPolicyControl));
            rtb_PolicyText = new RichTextBox();
            chk_Agree = new CheckBox();
            label4 = new Label();
            continuebtn = new RoundedButton();
            SuspendLayout();
            // 
            // rtb_PolicyText
            // 
            rtb_PolicyText.BackColor = Color.FromArgb(106, 36, 138);
            rtb_PolicyText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtb_PolicyText.ForeColor = Color.WhiteSmoke;
            rtb_PolicyText.Location = new Point(128, 72);
            rtb_PolicyText.Name = "rtb_PolicyText";
            rtb_PolicyText.ReadOnly = true;
            rtb_PolicyText.Size = new Size(744, 440);
            rtb_PolicyText.TabIndex = 0;
            rtb_PolicyText.Text = resources.GetString("rtb_PolicyText.Text");
            // 
            // chk_Agree
            // 
            chk_Agree.AutoSize = true;
            chk_Agree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chk_Agree.Location = new Point(136, 560);
            chk_Agree.Name = "chk_Agree";
            chk_Agree.Size = new Size(563, 27);
            chk_Agree.TabIndex = 1;
            chk_Agree.Text = "I have read and agree to the Privacy Policy and Medical Disclaimer";
            chk_Agree.UseVisualStyleBackColor = true;
            chk_Agree.CheckedChanged += chk_Agree_CheckedChanged;
            chk_Agree.Click += chk_Agree_CheckedChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 56);
            label4.TabIndex = 9;
            label4.Text = "Privacy and Policy:";
            // 
            // continuebtn
            // 
            continuebtn.BackColor = Color.FromArgb(155, 111, 255);
            continuebtn.BorderRadius = 20;
            continuebtn.Enabled = false;
            continuebtn.FlatAppearance.BorderSize = 0;
            continuebtn.FlatStyle = FlatStyle.Flat;
            continuebtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continuebtn.ForeColor = Color.White;
            continuebtn.Location = new Point(728, 536);
            continuebtn.Name = "continuebtn";
            continuebtn.Size = new Size(142, 53);
            continuebtn.TabIndex = 10;
            continuebtn.Text = "Continue";
            continuebtn.UseVisualStyleBackColor = false;
            continuebtn.Click += continuebtn_Click_1;
            // 
            // PrivacyPolicyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(continuebtn);
            Controls.Add(label4);
            Controls.Add(chk_Agree);
            Controls.Add(rtb_PolicyText);
            Name = "PrivacyPolicyControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_PolicyText;
        private CheckBox chk_Agree;
        private Label label4;
        private RoundedButton continuebtn;
    }
}
