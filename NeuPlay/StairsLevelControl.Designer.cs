namespace NeuPlay
{
    partial class StairsLevelControl
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
            lbl_Instruction = new Label();
            txt_Step1 = new Label();
            txt_Step5 = new Label();
            txt_Step4 = new Label();
            txt_Step3 = new Label();
            txt_Step2 = new Label();
            pic_Bunny = new PictureBox();
            btn_Check = new Button();
            btn_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Bunny).BeginInit();
            SuspendLayout();
            // 
            // lbl_Instruction
            // 
            lbl_Instruction.AutoSize = true;
            lbl_Instruction.Font = new Font("Segoe UI", 18F);
            lbl_Instruction.Location = new Point(328, 48);
            lbl_Instruction.Name = "lbl_Instruction";
            lbl_Instruction.Size = new Size(371, 41);
            lbl_Instruction.TabIndex = 0;
            lbl_Instruction.Text = "Fill in the missing numbers";
            // 
            // txt_Step1
            // 
            txt_Step1.Font = new Font("Segoe UI", 30F);
            txt_Step1.Location = new Point(168, 384);
            txt_Step1.Name = "txt_Step1";
            txt_Step1.Size = new Size(96, 84);
            txt_Step1.TabIndex = 1;
            txt_Step1.Text = "1";
            txt_Step1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Step5
            // 
            txt_Step5.Font = new Font("Segoe UI", 30F);
            txt_Step5.Location = new Point(560, 152);
            txt_Step5.Name = "txt_Step5";
            txt_Step5.Size = new Size(96, 84);
            txt_Step5.TabIndex = 3;
            txt_Step5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Step4
            // 
            txt_Step4.Font = new Font("Segoe UI", 30F);
            txt_Step4.Location = new Point(464, 200);
            txt_Step4.Name = "txt_Step4";
            txt_Step4.Size = new Size(96, 84);
            txt_Step4.TabIndex = 4;
            txt_Step4.Text = "4";
            txt_Step4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Step3
            // 
            txt_Step3.Font = new Font("Segoe UI", 30F);
            txt_Step3.Location = new Point(368, 240);
            txt_Step3.Name = "txt_Step3";
            txt_Step3.Size = new Size(96, 84);
            txt_Step3.TabIndex = 5;
            txt_Step3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Step2
            // 
            txt_Step2.Font = new Font("Segoe UI", 30F);
            txt_Step2.Location = new Point(272, 304);
            txt_Step2.Name = "txt_Step2";
            txt_Step2.Size = new Size(96, 84);
            txt_Step2.TabIndex = 6;
            txt_Step2.Text = "2";
            txt_Step2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_Bunny
            // 
            pic_Bunny.BackgroundImageLayout = ImageLayout.Zoom;
            pic_Bunny.Image = Properties.Resources.Gemini_Generated_Image_9m6gyn9m6gyn9m6g;
            pic_Bunny.Location = new Point(176, 304);
            pic_Bunny.Name = "pic_Bunny";
            pic_Bunny.Size = new Size(64, 64);
            pic_Bunny.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Bunny.TabIndex = 7;
            pic_Bunny.TabStop = false;
            // 
            // btn_Check
            // 
            btn_Check.Location = new Point(456, 528);
            btn_Check.Name = "btn_Check";
            btn_Check.Size = new Size(94, 29);
            btn_Check.TabIndex = 8;
            btn_Check.Text = "Check";
            btn_Check.UseVisualStyleBackColor = true;
            btn_Check.Click += btn_Check_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(32, 24);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 29);
            btn_Back.TabIndex = 9;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // StairsLevelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Back);
            Controls.Add(btn_Check);
            Controls.Add(pic_Bunny);
            Controls.Add(txt_Step2);
            Controls.Add(txt_Step3);
            Controls.Add(txt_Step4);
            Controls.Add(txt_Step5);
            Controls.Add(txt_Step1);
            Controls.Add(lbl_Instruction);
            Name = "StairsLevelControl";
            Size = new Size(1024, 720);
            ((System.ComponentModel.ISupportInitialize)pic_Bunny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Instruction;
        private Label txt_Step1;
        private Label txt_Step5;
        private Label txt_Step4;
        private Label txt_Step3;
        private Label txt_Step2;
        private PictureBox pic_Bunny;
        private Button btn_Check;
        private Button btn_Back;
    }
}
