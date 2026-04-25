namespace NeuPlay
{
    partial class CountAndMatchControl
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
            pic_Quantity = new PictureBox();
            btn_Num1 = new Button();
            btn_Num2 = new Button();
            btn_Num3 = new Button();
            btn_Num4 = new Button();
            btn_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Quantity).BeginInit();
            SuspendLayout();
            // 
            // pic_Quantity
            // 
            pic_Quantity.Location = new Point(272, 64);
            pic_Quantity.Name = "pic_Quantity";
            pic_Quantity.Size = new Size(432, 384);
            pic_Quantity.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Quantity.TabIndex = 0;
            pic_Quantity.TabStop = false;
            // 
            // btn_Num1
            // 
            btn_Num1.Location = new Point(176, 488);
            btn_Num1.Name = "btn_Num1";
            btn_Num1.Size = new Size(104, 45);
            btn_Num1.TabIndex = 1;
            btn_Num1.Text = "button1";
            btn_Num1.UseVisualStyleBackColor = true;
            btn_Num1.Click += btn_Num1_Click;
            // 
            // btn_Num2
            // 
            btn_Num2.Location = new Point(320, 488);
            btn_Num2.Name = "btn_Num2";
            btn_Num2.Size = new Size(104, 45);
            btn_Num2.TabIndex = 2;
            btn_Num2.Text = "button2";
            btn_Num2.UseVisualStyleBackColor = true;
            btn_Num2.Click += btn_Num2_Click;
            // 
            // btn_Num3
            // 
            btn_Num3.Location = new Point(480, 488);
            btn_Num3.Name = "btn_Num3";
            btn_Num3.Size = new Size(104, 45);
            btn_Num3.TabIndex = 3;
            btn_Num3.Text = "button3";
            btn_Num3.UseVisualStyleBackColor = true;
            btn_Num3.Click += btn_Num3_Click;
            // 
            // btn_Num4
            // 
            btn_Num4.Location = new Point(624, 488);
            btn_Num4.Name = "btn_Num4";
            btn_Num4.Size = new Size(104, 45);
            btn_Num4.TabIndex = 4;
            btn_Num4.Text = "button4";
            btn_Num4.UseVisualStyleBackColor = true;
            btn_Num4.Click += btn_Num4_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(816, 16);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(184, 45);
            btn_Back.TabIndex = 7;
            btn_Back.Text = "Back to Numbers' Land";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // CountAndMatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Back);
            Controls.Add(btn_Num4);
            Controls.Add(btn_Num3);
            Controls.Add(btn_Num2);
            Controls.Add(btn_Num1);
            Controls.Add(pic_Quantity);
            Name = "CountAndMatchControl";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pic_Quantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Quantity;
        private Button btn_Num1;
        private Button btn_Num2;
        private Button btn_Num3;
        private Button btn_Num4;
        private Button btn_Back;
    }
}
