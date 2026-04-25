namespace NeuPlay
{
    partial class CollectLevelControl
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
            lbl_Title = new Label();
            pic_Star1 = new PictureBox();
            pic_Star2 = new PictureBox();
            pic_Star3 = new PictureBox();
            pic_Star4 = new PictureBox();
            pic_Star5 = new PictureBox();
            btn_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star5).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 18F);
            lbl_Title.Location = new Point(152, 32);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(202, 41);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Collect 3 stars";
            // 
            // pic_Star1
            // 
            pic_Star1.Location = new Point(200, 168);
            pic_Star1.Name = "pic_Star1";
            pic_Star1.Size = new Size(69, 64);
            pic_Star1.TabIndex = 1;
            pic_Star1.TabStop = false;
            pic_Star1.Click += pic_Star1_Click;
            // 
            // pic_Star2
            // 
            pic_Star2.Location = new Point(312, 120);
            pic_Star2.Name = "pic_Star2";
            pic_Star2.Size = new Size(69, 64);
            pic_Star2.TabIndex = 2;
            pic_Star2.TabStop = false;
            pic_Star2.Click += pic_Star2_Click;
            // 
            // pic_Star3
            // 
            pic_Star3.Location = new Point(432, 80);
            pic_Star3.Name = "pic_Star3";
            pic_Star3.Size = new Size(69, 64);
            pic_Star3.TabIndex = 3;
            pic_Star3.TabStop = false;
            pic_Star3.Click += pic_Star3_Click;
            // 
            // pic_Star4
            // 
            pic_Star4.Location = new Point(544, 112);
            pic_Star4.Name = "pic_Star4";
            pic_Star4.Size = new Size(69, 64);
            pic_Star4.TabIndex = 4;
            pic_Star4.TabStop = false;
            pic_Star4.Click += pic_Star4_Click;
            // 
            // pic_Star5
            // 
            pic_Star5.Location = new Point(648, 176);
            pic_Star5.Name = "pic_Star5";
            pic_Star5.Size = new Size(69, 64);
            pic_Star5.TabIndex = 5;
            pic_Star5.TabStop = false;
            pic_Star5.Click += pic_Star5_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(32, 520);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 29);
            btn_Back.TabIndex = 6;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // CollectLevelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Back);
            Controls.Add(pic_Star5);
            Controls.Add(pic_Star4);
            Controls.Add(pic_Star3);
            Controls.Add(pic_Star2);
            Controls.Add(pic_Star1);
            Controls.Add(lbl_Title);
            Name = "CollectLevelControl";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pic_Star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Star5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private PictureBox pic_Star1;
        private PictureBox pic_Star2;
        private PictureBox pic_Star3;
        private PictureBox pic_Star4;
        private PictureBox pic_Star5;
        private Button btn_Back;
    }
}
