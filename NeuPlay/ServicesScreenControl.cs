using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class ServicesScreenControl : UserControl
    {
        public ServicesScreenControl()
        {
            InitializeComponent();
        }


        public ServicesScreenControl(string diagnosis)
        {
            InitializeComponent();


            btn_SpellQuest.Visible = false;
            btn_NumbersLand.Visible = false;
            btn_HeroRest.Visible = true;


            if (diagnosis == "Dysgraphia" || diagnosis == "Both")
            {
                btn_SpellQuest.Visible = true;
            }

            if (diagnosis == "Dyscalculia" || diagnosis == "Both")
            {
                btn_NumbersLand.Visible = true;
            }
        }

        private void btn_NumbersLand_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new NumbersLand());
            }
        }

        private void btn_HeroRest_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Welcome to Hero's Rest! Stories and tips coming soon.", "NeuPlay");
        }

        private void btn_SpellQuest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Spell Quest! Word games coming soon.", "NeuPlay");
        }

        private void btn_HeroRest_Click_1(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new HeroRestControl());
            }
        }

        private void btn_SpellQuest_Click_1(object sender, EventArgs e)
        {

            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new SpellQuest());
            }
        }
    }
}