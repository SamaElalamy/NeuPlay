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
            lbl_Num1 = new Label();
            lbl_Operator = new Label();
            lbl_Num2 = new Label();
            btn_Greater = new Button();
            btn_Equal = new Button();
            btn_Less = new Button();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // lbl_Num1
            // 
            lbl_Num1.Location = new Point(88, 128);
            lbl_Num1.Name = "lbl_Num1";
            lbl_Num1.Size = new Size(232, 225);
            lbl_Num1.TabIndex = 0;
            lbl_Num1.Text = "label1";
            // 
            // lbl_Operator
            // 
            lbl_Operator.Location = new Point(376, 136);
            lbl_Operator.Name = "lbl_Operator";
            lbl_Operator.Size = new Size(232, 225);
            lbl_Operator.TabIndex = 1;
            lbl_Operator.Text = "?";
            // 
            // lbl_Num2
            // 
            lbl_Num2.Location = new Point(664, 136);
            lbl_Num2.Name = "lbl_Num2";
            lbl_Num2.Size = new Size(232, 225);
            lbl_Num2.TabIndex = 2;
            lbl_Num2.Text = "label3";
            // 
            // btn_Greater
            // 
            btn_Greater.Location = new Point(232, 448);
            btn_Greater.Name = "btn_Greater";
            btn_Greater.Size = new Size(120, 69);
            btn_Greater.TabIndex = 3;
            btn_Greater.Text = "<";
            btn_Greater.UseVisualStyleBackColor = true;
            btn_Greater.Click += btn_Greater_Click;
            // 
            // btn_Equal
            // 
            btn_Equal.Location = new Point(424, 440);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(120, 69);
            btn_Equal.TabIndex = 4;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // btn_Less
            // 
            btn_Less.Location = new Point(616, 440);
            btn_Less.Name = "btn_Less";
            btn_Less.Size = new Size(120, 69);
            btn_Less.TabIndex = 5;
            btn_Less.Text = ">";
            btn_Less.UseVisualStyleBackColor = true;
            btn_Less.Click += btn_Less_Click;
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(16, 16);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(94, 29);
            btn_Back.TabIndex = 6;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // CompareLevelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Back);
            Controls.Add(btn_Less);
            Controls.Add(btn_Equal);
            Controls.Add(btn_Greater);
            Controls.Add(lbl_Num2);
            Controls.Add(lbl_Operator);
            Controls.Add(lbl_Num1);
            Name = "CompareLevelControl";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_Num1;
        private Label lbl_Operator;
        private Label lbl_Num2;
        private Button btn_Greater;
        private Button btn_Equal;
        private Button btn_Less;
        private Button btn_Back;
    }
}
