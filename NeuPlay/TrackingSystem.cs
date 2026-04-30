using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuPlay
{
    public class TrackingSystem
    {
        private int correctWins; // عداد المرات اللي الطفل حل فيها السلم صح
        private int targetWins; // عدد المرات المطلوبة للنقل لليفل تاني
        private ProgressBar progressBar;

        public int CorrectWins
        {
            set //public void set(int value)
            {
                correctWins = value;
            }
            get //public int get()
            {
                return correctWins;
            }
        }
        public int TargetWins
        {
            set 
            {
                targetWins = value;
            }
            get
            {
                return targetWins;
            }
        }
        //حطيت parameters علي حسب في كل لعبه هو محتاج كام عشان يعدي
        public TrackingSystem(int target, ProgressBar bar) 
        {
            targetWins = target;
            correctWins = 0;
            progressBar = bar;

            if (progressBar != null) //لو الشريط موجوده اشتغل مش موجود متعملش حاجه
            {
                progressBar.Maximum = target;
                progressBar.Value = 0;
            }
        }
        // دي لما يحل صح 
        public bool Add()
        {
            correctWins++;
            if (correctWins <= progressBar.Maximum) //لما progress يساوي عدد المرات الصح
            {
                progressBar.Value = correctWins;
            }
            if (correctWins == targetWins)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // بنصفر لما يبدا ليفل جديد
        public void Reset()
        {
            correctWins = 0;
            progressBar.Value= 0;
        }
    }
}
