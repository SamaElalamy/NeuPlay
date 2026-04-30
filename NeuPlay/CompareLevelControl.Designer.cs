namespace NeuPlay
{
    partial class CompareLevelControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbl_Operator = new Label();
            btn_Greater = new Button();
            btn_Equal = new Button();
            btn_Less = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_Operator
            // 
            lbl_Operator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Operator.ForeColor = Color.DodgerBlue;
            lbl_Operator.Location = new Point(458, 249);
            lbl_Operator.Name = "lbl_Operator";
            lbl_Operator.Size = new Size(105, 69);
            lbl_Operator.TabIndex = 1;
            lbl_Operator.Text = "?";
            lbl_Operator.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Operator.Click += lbl_Operator_Click;
            // 
            // btn_Greater
            // 
            btn_Greater.Location = new Point(275, 516);
            btn_Greater.Name = "btn_Greater";
            btn_Greater.Size = new Size(120, 69);
            btn_Greater.TabIndex = 3;
            btn_Greater.Text = "<";
            btn_Greater.UseVisualStyleBackColor = true;
            btn_Greater.Click += btn_Greater_Click;
            // 
            // btn_Equal
            // 
            btn_Equal.Location = new Point(458, 516);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(120, 69);
            btn_Equal.TabIndex = 4;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // btn_Less
            // 
            btn_Less.Location = new Point(648, 516);
            btn_Less.Name = "btn_Less";
            btn_Less.Size = new Size(120, 69);
            btn_Less.TabIndex = 5;
            btn_Less.Text = ">";
            btn_Less.UseVisualStyleBackColor = true;
            btn_Less.Click += btn_Less_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(912, 16);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(94, 29);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Back";
            guna2Button1.Click += btn_Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(597, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 407);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(98, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(331, 407);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(13, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 51);
            textBox1.TabIndex = 10;
            textBox1.Text = "Compare between Two numbers";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(307, 603);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(427, 29);
            progressBar1.TabIndex = 11;
            progressBar1.Click += progressBar1_Click;
            // 
            // CompareLevelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(guna2Button1);
            Controls.Add(btn_Less);
            Controls.Add(btn_Equal);
            Controls.Add(btn_Greater);
            Controls.Add(lbl_Operator);
            Name = "CompareLevelControl";
            Size = new Size(1026, 918);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Operator;
        private Button btn_Greater;
        private Button btn_Equal;
        private Button btn_Less;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private ProgressBar progressBar1;
    }
}
