using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class StairsLevelControl : UserControl
    {
        public StairsLevelControl()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            
            bool isStep3Correct = txt_Step3.Text == "3";
            bool isStep5Correct = txt_Step5.Text == "5";

            if (isStep3Correct && isStep5Correct)
            {
                
                pic_Bunny.Location = new Point(txt_Step5.Location.X - 30, txt_Step5.Location.Y - 20);

                MessageBox.Show("برافو! الأرنب وصل للقمة بفضل مساعدتك 🐰", "ممتاز", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null) parentForm.LoadScreen(new CompareLevelControl());
            }
            else
            {
                //MessageBox.Show("الأرنب محتار.. راجع الأرقام الناقصة تاني!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new NumbersLand());
            }
        }
    }
}