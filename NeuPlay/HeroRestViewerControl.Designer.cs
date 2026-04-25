namespace NeuPlay
{
    partial class HeroRestViewerControl
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
            pic_Content = new PictureBox();
            btnNext = new Button();
            btnPre = new Button();
            BACK = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Content).BeginInit();
            SuspendLayout();
            // 
            // pic_Content
            // 
            pic_Content.Location = new Point(264, 56);
            pic_Content.Name = "pic_Content";
            pic_Content.Size = new Size(488, 432);
            pic_Content.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Content.TabIndex = 0;
            pic_Content.TabStop = false;
            pic_Content.Click += pic_Content_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(584, 520);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btn_Next_Click;
            // 
            // btnPre
            // 
            btnPre.Location = new Point(296, 520);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(94, 29);
            btnPre.TabIndex = 2;
            btnPre.Text = "Previous";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btn_Prev_Click;
            // 
            // BACK
            // 
            BACK.Location = new Point(16, 16);
            BACK.Name = "BACK";
            BACK.Size = new Size(136, 45);
            BACK.TabIndex = 6;
            BACK.Text = "Back to Core";
            BACK.UseVisualStyleBackColor = true;
            BACK.Click += btn_Back_Click;
            // 
            // HeroRestViewerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BACK);
            Controls.Add(btnPre);
            Controls.Add(btnNext);
            Controls.Add(pic_Content);
            Name = "HeroRestViewerControl";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pic_Content).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Content;
        private Button btnNext;
        private Button btnPre;
        private Button BACK;
    }
}
