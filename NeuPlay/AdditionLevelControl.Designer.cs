namespace NeuPlay
{
    partial class AdditionLevelControl
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lbl_Operator = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            back = new Button();
            progressBar1 = new ProgressBar();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(534, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(333, 309);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(825, 509);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 2;
            // 
            // lbl_Operator
            // 
            lbl_Operator.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Operator.ForeColor = Color.DodgerBlue;
            lbl_Operator.Location = new Point(963, 296);
            lbl_Operator.Name = "lbl_Operator";
            lbl_Operator.Size = new Size(70, 69);
            lbl_Operator.TabIndex = 3;
            lbl_Operator.Text = "?";
            lbl_Operator.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Operator.Click += lbl_Operator_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(417, 296);
            label3.Name = "label3";
            label3.Size = new Size(95, 60);
            label3.TabIndex = 5;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(873, 292);
            label2.Name = "label2";
            label2.Size = new Size(72, 69);
            label2.TabIndex = 6;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(236, 478);
            label4.Name = "label4";
            label4.Size = new Size(120, 69);
            label4.TabIndex = 7;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(534, 478);
            label5.Name = "label5";
            label5.Size = new Size(120, 69);
            label5.TabIndex = 8;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(392, 478);
            label6.Name = "label6";
            label6.Size = new Size(120, 69);
            label6.TabIndex = 9;
            label6.Text = "+";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(699, 492);
            label7.Name = "label7";
            label7.Size = new Size(120, 69);
            label7.TabIndex = 10;
            label7.Text = "=";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(825, 492);
            label8.Name = "label8";
            label8.Size = new Size(120, 69);
            label8.TabIndex = 11;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(236, 592);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += lbl_Operator_Click;
            // 
            // button2
            // 
            button2.Location = new Point(417, 592);
            button2.Name = "button2";
            button2.Size = new Size(124, 45);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += lbl_Operator_Click;
            // 
            // button3
            // 
            button3.Location = new Point(599, 592);
            button3.Name = "button3";
            button3.Size = new Size(124, 45);
            button3.TabIndex = 14;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += lbl_Operator_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 57);
            textBox1.TabIndex = 15;
            textBox1.Text = "Addition Two Numbers";
            // 
            // back
            // 
            back.BackColor = SystemColors.Control;
            back.Location = new Point(12, 651);
            back.Name = "back";
            back.Size = new Size(117, 37);
            back.TabIndex = 16;
            back.Text = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(310, 669);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(413, 29);
            progressBar1.TabIndex = 17;
            progressBar1.Click += progressBar1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(871, 22);
            button4.Name = "button4";
            button4.Size = new Size(162, 29);
            button4.TabIndex = 18;
            button4.Text = "back to Number land";
            button4.UseVisualStyleBackColor = true;
            button4.Click += back_Click;
            // 
            // AdditionLevelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(progressBar1);
            Controls.Add(back);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbl_Operator);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "AdditionLevelControl";
            Size = new Size(1036, 701);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lbl_Operator;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button back;
        private ProgressBar progressBar1;
        private Button button4;
    }
}
