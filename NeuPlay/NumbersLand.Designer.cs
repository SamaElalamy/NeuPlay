namespace NeuPlay
{
    partial class NumbersLand
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
            label4 = new Label();
            btn_Start = new Button();
            BACK = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(246, 202, 78);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1024, 120);
            label4.TabIndex = 9;
            label4.Text = "Numbers' Land";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Start
            // 
            btn_Start.BackgroundImage = Properties.Resources.Gemini_Generated_Image_ipsp0wipsp0wipsp;
            btn_Start.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Start.FlatAppearance.BorderSize = 0;
            btn_Start.FlatStyle = FlatStyle.Flat;
            btn_Start.Location = new Point(320, 168);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(344, 328);
            btn_Start.TabIndex = 11;
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // BACK
            // 
            BACK.Location = new Point(8, 640);
            BACK.Name = "BACK";
            BACK.Size = new Size(96, 45);
            BACK.TabIndex = 12;
            BACK.Text = "Back ";
            BACK.UseVisualStyleBackColor = true;
            BACK.Click += btn_Back_Click;
            // 
            // NumbersLand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BACK);
            Controls.Add(btn_Start);
            Controls.Add(label4);
            Name = "NumbersLand";
            Size = new Size(1024, 720);
            Load += NumbersLand_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Button btn_Start;
        private Button BACK;
    }
}
