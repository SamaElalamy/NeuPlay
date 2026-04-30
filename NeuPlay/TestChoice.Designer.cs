namespace NeuPlay
{
    partial class TestChoice
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
            label1 = new Label();
            roundedButton1 = new RoundedButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1024, 56);
            label1.TabIndex = 3;
            label1.Text = "Diagnose Test\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BorderRadius = 20;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(3, 3);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(269, 325);
            roundedButton1.TabIndex = 4;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedButton1);
            flowLayoutPanel1.Controls.Add(roundedButton2);
            flowLayoutPanel1.Controls.Add(roundedButton3);
            flowLayoutPanel1.Location = new Point(80, 184);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(832, 344);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.MediumSlateBlue;
            roundedButton2.BorderRadius = 20;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(278, 3);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(269, 325);
            roundedButton2.TabIndex = 5;
            roundedButton2.Text = "roundedButton2";
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.MediumSlateBlue;
            roundedButton3.BorderRadius = 20;
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.ForeColor = Color.White;
            roundedButton3.Location = new Point(553, 3);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(269, 325);
            roundedButton3.TabIndex = 6;
            roundedButton3.Text = "roundedButton3";
            roundedButton3.UseVisualStyleBackColor = false;
            // 
            // TestChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "TestChoice";
            Size = new Size(1024, 720);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RoundedButton roundedButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
    }
}
