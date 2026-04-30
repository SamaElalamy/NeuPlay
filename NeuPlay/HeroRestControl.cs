using System;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class HeroRestControl : UserControl
    {
        public HeroRestControl()
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
        }

        private void btn_Tips_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                HeroContentDisplay displayScreen = new HeroContentDisplay();

                TipsContent myTips = new TipsContent(); // التغيير هنا بس!

                displayScreen.SetContent(myTips);

                Form1 p = (Form1)this.FindForm();
                if (p != null) p.LoadScreen(displayScreen);
            }

        }


        private void btn_Stories_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                HeroContentDisplay displayScreen = new HeroContentDisplay();

                
                StoryContent myStory = new StoryContent();

                displayScreen.SetContent(myStory);

                
                Form1 p = (Form1)this.FindForm();
                if (p != null) p.LoadScreen(displayScreen);
            }
        }

        private void btn_Parental_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                HeroContentDisplay displayScreen = new HeroContentDisplay();

                ParentContent myparentaltips = new ParentContent(); 

                displayScreen.SetContent(myparentaltips);

                Form1 p = (Form1)this.FindForm();
                if (p != null) p.LoadScreen(displayScreen);
            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }

        private void BACKbtn_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {

                parentForm.LoadScreen(new ServicesScreenControl("Both"));
            }
        }
    }
}