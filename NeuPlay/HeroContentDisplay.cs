using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class HeroContentDisplay : UserControl
    {

        private HeroContent currentContent;

        public HeroContentDisplay()
        {
            InitializeComponent();
        }


        public void SetContent(HeroContent content)
        {
            currentContent = content;
            currentContent.PrepareData();

            slogan.Text = currentContent.Title;


            if (currentContent.ImagePaths.Count > 0)
            {
                currentContent.CurrentIndex = 0;
                displaypic.Image = Image.FromFile(currentContent.ImagePaths[0]);
            }
        }


        private void nextDisplaybtn_Click(object sender, EventArgs e)
        {

            if (currentContent != null && currentContent.CurrentIndex < currentContent.ImagePaths.Count - 1)
            {
                currentContent.CurrentIndex++;
                displaypic.Image = Image.FromFile(currentContent.ImagePaths[currentContent.CurrentIndex]); 
            }
            else
            {
                MessageBox.Show("End of content");
                Form1 p = (Form1)this.FindForm();
                if (p != null) p.LoadScreen(new HeroRestControl());
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new HeroRestControl());
            }
        }
    }
}
