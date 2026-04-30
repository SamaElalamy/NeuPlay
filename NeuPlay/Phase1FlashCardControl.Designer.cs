namespace NeuPlay
{
    partial class Phase1FlashCardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phase1FlashCardControl));
            WordPic = new PictureBox();
            Memorizedbtn = new RoundedButton();
            progressBar1 = new ProgressBar();
            ScoreLabel = new Label();
            pictureBox1 = new PictureBox();
            MagicCardpic = new PictureBox();
            revealbtn = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)WordPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MagicCardpic).BeginInit();
            SuspendLayout();
            // 
            // WordPic
            // 
            WordPic.BackgroundImageLayout = ImageLayout.Zoom;
            WordPic.Location = new Point(296, 136);
            WordPic.Name = "WordPic";
            WordPic.Size = new Size(384, 448);
            WordPic.SizeMode = PictureBoxSizeMode.Zoom;
            WordPic.TabIndex = 0;
            WordPic.TabStop = false;
            // 
            // Memorizedbtn
            // 
            Memorizedbtn.BackColor = Color.FromArgb(255, 211, 91);
            Memorizedbtn.BorderRadius = 20;
            Memorizedbtn.FlatAppearance.BorderSize = 0;
            Memorizedbtn.FlatStyle = FlatStyle.Flat;
            Memorizedbtn.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Memorizedbtn.ForeColor = Color.FromArgb(106, 36, 138);
            Memorizedbtn.Location = new Point(584, 600);
            Memorizedbtn.Name = "Memorizedbtn";
            Memorizedbtn.Size = new Size(176, 53);
            Memorizedbtn.TabIndex = 3;
            Memorizedbtn.Text = "Memorized";
            Memorizedbtn.UseVisualStyleBackColor = false;
            Memorizedbtn.Click += btnNext_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(55, 96, 242);
            progressBar1.Location = new Point(528, 16);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(381, 37);
            progressBar1.TabIndex = 4;
            // 
            // ScoreLabel
            // 
            ScoreLabel.BackColor = Color.FromArgb(255, 227, 151);
            ScoreLabel.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.ForeColor = Color.FromArgb(106, 36, 138);
            ScoreLabel.Location = new Point(408, 8);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(104, 56);
            ScoreLabel.TabIndex = 5;
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Apr_30__2026__12_00_42_PM;
            pictureBox1.Location = new Point(-80, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MagicCardpic
            // 
            MagicCardpic.BackgroundImageLayout = ImageLayout.Stretch;
            MagicCardpic.Image = (Image)resources.GetObject("MagicCardpic.Image");
            MagicCardpic.Location = new Point(296, 136);
            MagicCardpic.Name = "MagicCardpic";
            MagicCardpic.Size = new Size(384, 456);
            MagicCardpic.SizeMode = PictureBoxSizeMode.Zoom;
            MagicCardpic.TabIndex = 8;
            MagicCardpic.TabStop = false;
            // 
            // revealbtn
            // 
            revealbtn.BackColor = Color.FromArgb(255, 211, 91);
            revealbtn.BorderRadius = 20;
            revealbtn.FlatAppearance.BorderSize = 0;
            revealbtn.FlatStyle = FlatStyle.Flat;
            revealbtn.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            revealbtn.ForeColor = Color.FromArgb(106, 36, 138);
            revealbtn.Location = new Point(248, 600);
            revealbtn.Name = "revealbtn";
            revealbtn.Size = new Size(176, 53);
            revealbtn.TabIndex = 9;
            revealbtn.Text = "Reveal";
            revealbtn.UseVisualStyleBackColor = false;
            revealbtn.Click += revealbtn_Click;
            // 
            // Phase1FlashCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 154, 248);
            Controls.Add(revealbtn);
            Controls.Add(MagicCardpic);
            Controls.Add(ScoreLabel);
            Controls.Add(progressBar1);
            Controls.Add(Memorizedbtn);
            Controls.Add(WordPic);
            Controls.Add(pictureBox1);
            Name = "Phase1FlashCardControl";
            Size = new Size(1024, 720);
            Load += Phase1FlashCardControl_Load;
            ((System.ComponentModel.ISupportInitialize)WordPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MagicCardpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox WordPic;
        private RoundedButton Memorizedbtn;
        private ProgressBar progressBar1;
        private Label ScoreLabel;
        private PictureBox pictureBox1;
        private PictureBox MagicCardpic;
        private RoundedButton revealbtn;
    }
}
