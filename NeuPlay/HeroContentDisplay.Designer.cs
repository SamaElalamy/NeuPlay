namespace NeuPlay
{
    partial class HeroContentDisplay
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
            Backbtn = new RoundedButton();
            displaypic = new PictureBox();
            slogan = new Label();
            nextDisplaybtn = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)displaypic).BeginInit();
            SuspendLayout();
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(21, 12, 126);
            Backbtn.BorderRadius = 20;
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.White;
            Backbtn.Location = new Point(16, 8);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(96, 48);
            Backbtn.TabIndex = 0;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // displaypic
            // 
            displaypic.BackgroundImageLayout = ImageLayout.Zoom;
            displaypic.Location = new Point(40, 64);
            displaypic.Name = "displaypic";
            displaypic.Size = new Size(896, 504);
            displaypic.SizeMode = PictureBoxSizeMode.Zoom;
            displaypic.TabIndex = 1;
            displaypic.TabStop = false;
            // 
            // slogan
            // 
            slogan.AutoSize = true;
            slogan.BackColor = Color.FromArgb(255, 227, 151);
            slogan.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            slogan.ForeColor = Color.FromArgb(21, 12, 126);
            slogan.Location = new Point(136, 8);
            slogan.Name = "slogan";
            slogan.Size = new Size(578, 46);
            slogan.TabIndex = 3;
            slogan.Text = "Where Learning Meets Play";
            // 
            // nextDisplaybtn
            // 
            nextDisplaybtn.BackColor = Color.FromArgb(21, 12, 126);
            nextDisplaybtn.BorderRadius = 20;
            nextDisplaybtn.FlatAppearance.BorderSize = 0;
            nextDisplaybtn.FlatStyle = FlatStyle.Flat;
            nextDisplaybtn.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextDisplaybtn.ForeColor = Color.White;
            nextDisplaybtn.Location = new Point(416, 592);
            nextDisplaybtn.Name = "nextDisplaybtn";
            nextDisplaybtn.Size = new Size(134, 53);
            nextDisplaybtn.TabIndex = 4;
            nextDisplaybtn.Text = "Next";
            nextDisplaybtn.UseVisualStyleBackColor = false;
            nextDisplaybtn.Click += nextDisplaybtn_Click;
            // 
            // HeroContentDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 227, 151);
            Controls.Add(nextDisplaybtn);
            Controls.Add(slogan);
            Controls.Add(displaypic);
            Controls.Add(Backbtn);
            Name = "HeroContentDisplay";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)displaypic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton Backbtn;
        private PictureBox displaypic;
        private Label slogan;
        private RoundedButton nextDisplaybtn;
    }
}
