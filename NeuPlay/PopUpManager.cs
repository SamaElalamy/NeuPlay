using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuPlay
{
    internal static class PopUpManager
    {
        private static Random random = new Random();

        static string[] correctMessages = {
            "Great job! 👏",
            "Well done!",
            "Excellent answer! 🌟",
            "That’s correct!",
            "Keep going 💪",
            "You did it right! 👍",
            "Amazing work! 🔥",
            "I’m proud of you! 😊",
            "You’re getting better and better! 🚀",
            "Perfect! Keep it up ⭐"
        };
        static string[] wrongMessages = {
            "That’s okay, try again 😊",
            "Nice try! Let’s do it together",
            "You’re very close! 👌",
            "Don’t worry, mistakes help us learn",
            "Take your time, no rush",
            "Let’s think about it one more time",
            "Good effort! Keep going 💪",
            "It’s okay to make mistakes 💛",
            "You’re learning, and that’s what matters"
        };

        public static int TotalPoints = 0;
        public static int CurrentStreak = 0; 
        private static int mistakesBeforeCorrect = 0;
        public static bool HasGreatComeback = false;
        public static bool HasStreakMaster = false;

        public static string GetCurrentBadge()
        {
            if (TotalPoints <= 100) return "The Little Explorer 🔍";
            if (TotalPoints <= 300) return "Neu Spark 💡";
            if (TotalPoints <= 600) return "Focus Hero 🎯";
            if (TotalPoints <= 1000) return "Neu Thinker 🧠";
            return "Neu Legend 👑"; // More than 1000
        }

        public static void ShowMessage(bool isCorrect, int pointsToEarn = 10)
        {
            string message;
            string title;

            if (isCorrect)
            {
                
                TotalPoints += pointsToEarn;
                CurrentStreak++;

                
                message = correctMessages[random.Next(correctMessages.Length)] +
                          "\n\n+" + pointsToEarn + " Points! ⭐\nTotal: " + TotalPoints + "\nBadge: " + GetCurrentBadge();
                title = "Correct!";

                
                CheckSpecialRewards();
                mistakesBeforeCorrect = 0;
            }
            else
            {
                
                CurrentStreak = 0; 
                mistakesBeforeCorrect++; 

                message = wrongMessages[random.Next(wrongMessages.Length)];
                title = "Keep Trying!";
            }

            MessageBox.Show(message, title, MessageBoxButtons.OK, isCorrect ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
        private static void CheckSpecialRewards()
        {
            
            if (mistakesBeforeCorrect >= 2 && !HasGreatComeback)
            {
                HasGreatComeback = true;
                MessageBox.Show("Awarded to a child who overcomes a big challenge!\n\nYou didn't give up... and that's your superpower! 💜",
                                "🏅 The Great Comeback!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            if (CurrentStreak == 3 && !HasStreakMaster)
            {
                HasStreakMaster = true;
                MessageBox.Show("Awarded to a child who keeps learning consistently!\n\nConsistency is your strength! 💚",
                                "⚡ Streak Master!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }
        public static void ResetGameSession()
        {
            TotalPoints = 0;
            CurrentStreak = 0;
            mistakesBeforeCorrect = 0;
        }
    }
}