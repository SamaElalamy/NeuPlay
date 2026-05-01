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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Quantity).BeginInit();
            SuspendLayout();
            // 
            // pic_Quantity
            // 
            pic_Quantity.Location = new Point(295, 151);
            pic_Quantity.Name = "pic_Quantity";
            pic_Quantity.Size = new Size(432, 384);
            pic_Quantity.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Quantity.TabIndex = 0;
            pic_Quantity.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightYellow;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(29, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 61);
            textBox1.TabIndex = 13;
            textBox1.Text = "Count and Match";
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(126, 605);
            button1.Name = "button1";
            button1.Size = new Size(110, 43);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_Num1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(331, 605);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn_Num2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(541, 605);
            button3.Name = "button3";
            button3.Size = new Size(110, 41);
            button3.TabIndex = 16;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_Num3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(768, 605);
            button4.Name = "button4";
            button4.Size = new Size(110, 41);
            button4.TabIndex = 17;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btn_Num4_Click;
            // 
            // CountAndMatchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pic_Quantity);
            Name = "CountAndMatchControl";
            Size = new Size(1022, 755);
            ((System.ComponentModel.ISupportInitialize)pic_Quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Quantity;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
