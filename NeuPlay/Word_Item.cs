using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NeuPlay
{
    public class WordItem
    {
        public string OriginalWord
        {
            get; set;
        }

        public string ImagesPath
        {
            get; set;
        }

        public char MissingLetter
        {
            get;set;
        }

        public string ShuffledWord
        {
            get; set;
        }

        public WordItem(string _originalword)
        {
            OriginalWord = _originalword;
            //AI is used in generating the path
            //reaching the path of the images using Path function
            ImagesPath = Application.StartupPath + "\\SpellQuestWords\\" + OriginalWord + ".png";
            //withdrawing a random letter out of the word
            //AI is used to understand the technique of (Random)
            Random rand= new Random();
            int indexRandomness=rand.Next(0,OriginalWord.Length);
            //identifying the missed letter
            MissingLetter = OriginalWord[indexRandomness];
            //slicing the word into an array of chars
            char[] _shuffledword=OriginalWord.ToCharArray();
            //randomizing the positions of the word's letters
            for(int i=0;i<_shuffledword.Length;i++)
            {
                //swaping letters
                int swapedLetters =rand.Next(0,_shuffledword.Length);
                char temp=_shuffledword[i];
                _shuffledword[i]=_shuffledword[swapedLetters];
                _shuffledword[swapedLetters]=temp;
            }
            //creating a new shuffled string of the original word
            ShuffledWord = new string(_shuffledword);
        }

    }
}
