namespace NeuPlay
{
    partial class SpellQuest
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
            pictureBox1 = new PictureBox();
            startbtn = new RoundedButton();
            backbtn = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(106, 36, 138);
            label1.Location = new Point(456, 208);
            label1.Name = "label1";
            label1.Size = new Size(496, 93);
            label1.TabIndex = 0;
            label1.Text = "Spell Quest";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(155, 111, 255);
            pictureBox1.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ym5hd3ym5hd3ym5h3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 728);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.FromArgb(155, 111, 255);
            startbtn.BorderRadius = 20;
            startbtn.FlatAppearance.BorderSize = 0;
            startbtn.FlatStyle = FlatStyle.Flat;
            startbtn.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startbtn.ForeColor = Color.White;
            startbtn.Location = new Point(568, 384);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(264, 93);
            startbtn.TabIndex = 4;
            startbtn.Text = "Start Game!";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(255, 211, 91);
            backbtn.BorderRadius = 20;
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backbtn.ForeColor = Color.White;
            backbtn.Location = new Point(8, 8);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(120, 64);
            backbtn.TabIndex = 5;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // SpellQuest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 211, 91);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(backbtn);
            Controls.Add(startbtn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "SpellQuest";
            Size = new Size(1022, 718);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private RoundedButton startbtn;
        private RoundedButton backbtn;
    }
}
