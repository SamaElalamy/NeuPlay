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
        public static void ShowMessage(bool isCorrect)
        {
            string message;
            string title;

            if (isCorrect)
            {
                message = correctMessages[random.Next(correctMessages.Length)];
                title = "Correct!";
            }
            else
            { 
                message = wrongMessages[random.Next(wrongMessages.Length)];
                title = "Incorrect";
            }

            MessageBox.Show(message,title);
        }
    }
}
