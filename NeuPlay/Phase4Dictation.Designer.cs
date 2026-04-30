namespace NeuPlay
{
    partial class Phase4Dictation
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
            ScoreLabel = new Label();
            progressBar1 = new ProgressBar();
            InputWordtxtbox = new TextBox();
            Checkbtn = new RoundedButton();
            HintPic = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HintPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.BackColor = Color.FromArgb(150, 38, 163);
            ScoreLabel.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.ForeColor = Color.FromArgb(217, 214, 224);
            ScoreLabel.Location = new Point(384, 24);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(104, 56);
            ScoreLabel.TabIndex = 9;
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(55, 96, 242);
            progressBar1.Location = new Point(536, 24);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(381, 37);
            progressBar1.TabIndex = 10;
            // 
            // InputWordtxtbox
            // 
            InputWordtxtbox.BackColor = Color.FromArgb(150, 38, 163);
            InputWordtxtbox.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputWordtxtbox.ForeColor = Color.FromArgb(249, 235, 249);
            InputWordtxtbox.Location = new Point(184, 304);
            InputWordtxtbox.Name = "InputWordtxtbox";
            InputWordtxtbox.Size = new Size(328, 167);
            InputWordtxtbox.TabIndex = 12;
            InputWordtxtbox.TextChanged += InputWordtxtbox_TextChanged;
            // 
            // Checkbtn
            // 
            Checkbtn.BackColor = Color.FromArgb(150, 38, 163);
            Checkbtn.BorderRadius = 20;
            Checkbtn.FlatAppearance.BorderSize = 0;
            Checkbtn.FlatStyle = FlatStyle.Flat;
            Checkbtn.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Checkbtn.ForeColor = Color.FromArgb(217, 214, 224);
            Checkbtn.Location = new Point(264, 512);
            Checkbtn.Name = "Checkbtn";
            Checkbtn.Size = new Size(168, 61);
            Checkbtn.TabIndex = 13;
            Checkbtn.Text = "Check";
            Checkbtn.UseVisualStyleBackColor = false;
            Checkbtn.Click += Checkbtn_Click;
            // 
            // HintPic
            // 
            HintPic.Location = new Point(576, 152);
            HintPic.Name = "HintPic";
            HintPic.Size = new Size(328, 392);
            HintPic.TabIndex = 11;
            HintPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Apr_30__2026__11_54_46_AM;
            pictureBox1.Location = new Point(-64, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(552, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Phase4Dictation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            Controls.Add(Checkbtn);
            Controls.Add(InputWordtxtbox);
            Controls.Add(HintPic);
            Controls.Add(progressBar1);
            Controls.Add(ScoreLabel);
            Controls.Add(pictureBox1);
            Name = "Phase4Dictation";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)HintPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ScoreLabel;
        private ProgressBar progressBar1;
        private TextBox InputWordtxtbox;
        private RoundedButton Checkbtn;
        private PictureBox HintPic;
        private PictureBox pictureBox1;
    }
}
