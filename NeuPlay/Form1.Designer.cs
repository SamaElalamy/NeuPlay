namespace NeuPlay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_MainContent = new Panel();
            SuspendLayout();
            // 
            // pnl_MainContent
            // 
            pnl_MainContent.Dock = DockStyle.Fill;
            pnl_MainContent.Location = new Point(0, 0);
            pnl_MainContent.Name = "pnl_MainContent";
            pnl_MainContent.Size = new Size(1006, 673);
            pnl_MainContent.TabIndex = 1;
            pnl_MainContent.Paint += pnl_MainContent_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 235, 249);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1006, 673);
            Controls.Add(pnl_MainContent);
            Cursor = Cursors.Hand;
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Indigo;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NeuPlay";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ResumeLayout(false);


        }

        #endregion
        private Panel pnl_MainContent;
    }
}
