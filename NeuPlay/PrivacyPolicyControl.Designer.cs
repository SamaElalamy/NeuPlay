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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            rtb_PolicyText = new RichTextBox();
            chk_Agree = new CheckBox();
            button_continue = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // rtb_PolicyText
            // 
            rtb_PolicyText.Location = new Point(120, 32);
            rtb_PolicyText.Name = "rtb_PolicyText";
            rtb_PolicyText.ReadOnly = true;
            rtb_PolicyText.Size = new Size(408, 400);
            rtb_PolicyText.TabIndex = 0;
            rtb_PolicyText.Text = resources.GetString("rtb_PolicyText.Text");
            // 
            // chk_Agree
            // 
            chk_Agree.AutoSize = true;
            chk_Agree.Location = new Point(136, 472);
            chk_Agree.Name = "chk_Agree";
            chk_Agree.Size = new Size(204, 24);
            chk_Agree.TabIndex = 1;
            chk_Agree.Text = "agree on terms and policy";
            chk_Agree.UseVisualStyleBackColor = true;
            chk_Agree.CheckedChanged += chk_Agree_CheckedChanged;
            chk_Agree.Click += chk_Agree_CheckedChanged;
            // 
            // button_continue
            // 
            button_continue.BorderRadius = 15;
            button_continue.CustomizableEdges = customizableEdges1;
            button_continue.DisabledState.BorderColor = Color.DarkGray;
            button_continue.DisabledState.CustomBorderColor = Color.DarkGray;
            button_continue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_continue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_continue.Font = new Font("Segoe UI", 9F);
            button_continue.ForeColor = Color.White;
            button_continue.Location = new Point(417, 438);
            button_continue.Name = "button_continue";
            button_continue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button_continue.Size = new Size(111, 28);
            button_continue.TabIndex = 2;
            button_continue.Text = "continue";
            button_continue.Click += button_Continue_Click;
            // 
            // PrivacyPolicyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_continue);
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
        private Guna.UI2.WinForms.Guna2Button button_continue;
    }
}
