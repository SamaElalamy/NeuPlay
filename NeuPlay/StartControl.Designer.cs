namespace NeuPlay
{
    partial class StartControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartControl));
            startingbtn = new RoundedButton();
            SuspendLayout();
            // 
            // startingbtn
            // 
            startingbtn.BackColor = Color.FromArgb(155, 111, 255);
            startingbtn.BorderRadius = 20;
            startingbtn.FlatAppearance.BorderSize = 0;
            startingbtn.FlatStyle = FlatStyle.Flat;
            startingbtn.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startingbtn.ForeColor = Color.White;
            startingbtn.Location = new Point(432, 496);
            startingbtn.Name = "startingbtn";
            startingbtn.Size = new Size(158, 61);
            startingbtn.TabIndex = 1;
            startingbtn.Text = "Start";
            startingbtn.UseVisualStyleBackColor = false;
            startingbtn.Click += startingbtn_Click;
            // 
            // StartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(startingbtn);
            Name = "StartControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion
        private RoundedButton startingbtn;
    }
}
