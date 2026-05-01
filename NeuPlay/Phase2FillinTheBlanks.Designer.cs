namespace NeuPlay
{
    partial class Phase2FillinTheBlanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phase2FillinTheBlanks));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Choice1 = new RoundedButton();
            ScoreLabel = new Label();
            progressBar1 = new ProgressBar();
            btn_Choice2 = new RoundedButton();
            btn_Choice3 = new RoundedButton();
            btn_Choice4 = new RoundedButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(106, 36, 138);
            flowLayoutPanel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            flowLayoutPanel1.ForeColor = Color.FromArgb(183, 154, 248);
            flowLayoutPanel1.Location = new Point(104, 264);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 181);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btn_Choice1
            // 
            btn_Choice1.BackColor = Color.FromArgb(106, 36, 138);
            btn_Choice1.BorderRadius = 20;
            btn_Choice1.FlatAppearance.BorderSize = 0;
            btn_Choice1.FlatStyle = FlatStyle.Flat;
            btn_Choice1.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            btn_Choice1.ForeColor = Color.FromArgb(217, 214, 224);
            btn_Choice1.Location = new Point(224, 512);
            btn_Choice1.Name = "btn_Choice1";
            btn_Choice1.Size = new Size(104, 85);
            btn_Choice1.TabIndex = 2;
            btn_Choice1.Text = "S";
            btn_Choice1.UseVisualStyleBackColor = false;
            // 
            // ScoreLabel
            // 
            ScoreLabel.BackColor = Color.FromArgb(106, 36, 138);
            ScoreLabel.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreLabel.ForeColor = Color.FromArgb(217, 214, 224);
            ScoreLabel.Location = new Point(440, 16);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(104, 56);
            ScoreLabel.TabIndex = 7;
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(55, 96, 242);
            progressBar1.Location = new Point(568, 32);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(381, 37);
            progressBar1.TabIndex = 8;
            // 
            // btn_Choice2
            // 
            btn_Choice2.BackColor = Color.FromArgb(106, 36, 138);
            btn_Choice2.BorderRadius = 20;
            btn_Choice2.FlatAppearance.BorderSize = 0;
            btn_Choice2.FlatStyle = FlatStyle.Flat;
            btn_Choice2.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            btn_Choice2.ForeColor = Color.FromArgb(217, 214, 224);
            btn_Choice2.Location = new Point(360, 512);
            btn_Choice2.Name = "btn_Choice2";
            btn_Choice2.Size = new Size(104, 85);
            btn_Choice2.TabIndex = 9;
            btn_Choice2.Text = "S";
            btn_Choice2.UseVisualStyleBackColor = false;
            // 
            // btn_Choice3
            // 
            btn_Choice3.BackColor = Color.FromArgb(106, 36, 138);
            btn_Choice3.BorderRadius = 20;
            btn_Choice3.FlatAppearance.BorderSize = 0;
            btn_Choice3.FlatStyle = FlatStyle.Flat;
            btn_Choice3.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            btn_Choice3.ForeColor = Color.FromArgb(217, 214, 224);
            btn_Choice3.Location = new Point(496, 512);
            btn_Choice3.Name = "btn_Choice3";
            btn_Choice3.Size = new Size(104, 85);
            btn_Choice3.TabIndex = 10;
            btn_Choice3.Text = "S";
            btn_Choice3.UseVisualStyleBackColor = false;
            // 
            // btn_Choice4
            // 
            btn_Choice4.BackColor = Color.FromArgb(106, 36, 138);
            btn_Choice4.BorderRadius = 20;
            btn_Choice4.FlatAppearance.BorderSize = 0;
            btn_Choice4.FlatStyle = FlatStyle.Flat;
            btn_Choice4.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            btn_Choice4.ForeColor = Color.FromArgb(217, 214, 224);
            btn_Choice4.Location = new Point(624, 512);
            btn_Choice4.Name = "btn_Choice4";
            btn_Choice4.Size = new Size(104, 85);
            btn_Choice4.TabIndex = 11;
            btn_Choice4.Text = "S";
            btn_Choice4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-96, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Phase2FillinTheBlanks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 214, 224);
            Controls.Add(btn_Choice4);
            Controls.Add(btn_Choice3);
            Controls.Add(btn_Choice2);
            Controls.Add(progressBar1);
            Controls.Add(ScoreLabel);
            Controls.Add(btn_Choice1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Phase2FillinTheBlanks";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private RoundedButton btn_Choice1;
        private Label ScoreLabel;
        private ProgressBar progressBar1;
        private RoundedButton btn_Choice2;
        private RoundedButton btn_Choice3;
        private RoundedButton btn_Choice4;
        private PictureBox pictureBox1;
    }
}
