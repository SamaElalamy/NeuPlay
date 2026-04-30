using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeuPlay
{
    public abstract class HeroContent
    {
        public string Title{get; set;}

        public List<string> ImagePaths = new List<string>();
        public int CurrentIndex = 0;
        public abstract void PrepareData();

    }

    public class ParentContent:HeroContent
    {
        public override void PrepareData()
        {
            Title = "Parental Tips";
            ImagePaths.Clear();
            string path = Application.StartupPath + "\\HeroRestVisuals\\parental tips\\";


            ImagePaths.Add(path + "parental tips1.png");
            ImagePaths.Add(path + "parental tips2.png");
            ImagePaths.Add(path + "parental tips3.png");
        }
    }

    public class TipsContent : HeroContent
    {
        public override void PrepareData()
        {
            Title = "My Tips";
            ImagePaths.Clear();
            string path = Application.StartupPath + "\\HeroRestVisuals\\tips\\";


            ImagePaths.Add(path + "tips1.png");
            ImagePaths.Add(path + "tips2.png");
            ImagePaths.Add(path + "tips3.png");
        }
        
    }

    public class StoryContent : HeroContent
    {
        public override void PrepareData()
        {
            Title = "Stories";
            ImagePaths.Clear();
            string path = Application.StartupPath + "\\HeroRestVisuals\\stories\\";

            
            ImagePaths.Add(path + "agatha christie.png");
            ImagePaths.Add(path + "ali.png");
            ImagePaths.Add(path + "layan.png");
            ImagePaths.Add(path + "loay.png");
            ImagePaths.Add(path + "sara.png");
            ImagePaths.Add(path + "thomas edison.png");
            ImagePaths.Add(path + "yousef.png");
        }
    }
}
