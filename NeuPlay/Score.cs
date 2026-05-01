using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuPlay
{
    public class Score
    {
        public static int points = 0; //بياخد مجموع النقط 

        //علي حسب ال ليفل اللي احنا فيه هيزود نقط
        public void AddPoints(string levelName)
        {
            if(levelName == "CountLevel" || levelName == "CollectLevel")
            {
                points += 5;
            }
            else if(levelName == "StairsLevel" || levelName == "OrderLevel")
            {
                points += 10;
            }
            else if(levelName == "CompareLevel" || levelName == "AdditionLevel")
            {
                points += 20;
            }
        }
    }
}
