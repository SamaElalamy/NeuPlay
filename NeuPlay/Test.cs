using System;

namespace NeuPlay
{
    // Supporting Enums for the Test logic
    public enum Ans
    {
        Yes,
        No,
        Sometimes
    }

    public enum DifficultyType
    {
        Dysgraphia,
        Dyscalculia,
        Both
    }

    // Question class structure
    public class Question
    {
        public string Q { get; set; }
        public int Score { get; set; }

        public Question(string q, int score)
        {
            Q = q;
            Score = score;
        }
    }

    internal class Tests
    {
        public static long score = 0;

        // Dysgraphia Test Questions
        public static Question[] dysgraphiaTest = new Question[]
        {
            new Question("Does the child have difficulty copying paragraphs and writing tasks?", 10),
            new Question("Does the child have difficulty expressing what he wants in writing?", 10),
            new Question("Does the child confuse the different types of (solar and lunar) as well as the uppercase and lowercase letters?", 10),
            new Question("Does the child find it difficult to adhere to the rules of correct writing?", 10),
            new Question("Does the child make mistakes when copying letters or shapes correctly?", 10),
            new Question("Is the child having difficulty using letter and word connectives?", 10),
            new Question("Does the child have difficulty forming coherent words and sentences?", 10),
            new Question("Does the child have difficulty with grammar rules while writing?", 10),
            new Question("Is the child having difficulty adhering to the specified spaces for writing?", 10),
            new Question("Does the child find it difficult to adhere to the rules of handwriting and fonts?", 10)
        };

        // Dyscalculia Test Questions
        public static Question[] dyscalculiaTest = new Question[]
        {
            new Question("Does the child have difficulty distinguishing between similar numbers?", 10),
            new Question("Does the child find it difficult to perform the required multiplication and division operations?", 10),
            new Question("Does the child have difficulty solving addition and subtraction problems, especially when borrowing?", 10),
            new Question("Is the child putting numbers or decimal points in the wrong places?", 10),
            new Question("Does the child have difficulty using comparative symbols such as (greater than > / less than <)?", 10),
            new Question("Does the child find it difficult to solve multi-step mental problems?", 10),
            new Question("Does the child not understand the meanings of simple mathematical symbols (÷, ×, +, -)?", 10),
            new Question("Does the child find it difficult to convert between different units?", 10),
            new Question("Does the child have difficulty arranging numbers in ascending or descending order?", 10),
            new Question("Does the child make mistakes in choosing the appropriate mathematical operation when solving problems?", 10)
        };

        // Method to display questions and collect answers
        public static void ShowQuestions(Question[] questions)
        {
            if (questions == null || questions.Length == 0)
            {
                Console.WriteLine("NO QUESTION HERE");
                return;
            }

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{i + 1} -> {questions[i].Q}");
                
                while (true)
                {
                    Console.WriteLine("Choose Answer (Yes / No / Sometimes): ");
                    string input = Console.ReadLine();

                    if (Enum.TryParse(input, true, out Ans userAnswer))
                    {
                        switch (userAnswer)
                        {
                            case Ans.Yes:
                                Console.WriteLine("Keep going!"); 
                                score += questions[i].Score;
                                break;

                            case Ans.No:
                                Console.WriteLine("Understood."); 
                                break;

                            case Ans.Sometimes:
                                Console.WriteLine("Continuing..."); 
                                score += (questions[i].Score / 2);
                                break;
                        }
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Please write the answer correctly!");
                    }
                }
            }
        }

        // Method to choose the specific test type
        public static void ChooseTest()
        {
            Console.WriteLine("CHOOSE TEST ABOUT DIFFICULTY TYPE ->");
            
            while (true)
            {
                Console.Write("Available tests now are (Dysgraphia / Dyscalculia / Both): ");
                string test = Console.ReadLine();

                if (Enum.TryParse(test, true, out DifficultyType userTest))
                {
                    switch (userTest)
                    {
                        case DifficultyType.Dyscalculia:
                            score = 0;
                            ShowQuestions(dyscalculiaTest);
                            Console.WriteLine($"Probability of Dyscalculia is: {score}%");
                            break;

                        case DifficultyType.Dysgraphia:
                            score = 0;
                            ShowQuestions(dysgraphiaTest);
                            Console.WriteLine($"Probability of Dysgraphia is: {score}%");
                            break;

                        case DifficultyType.Both:
                            // Reset and run Dyscalculia
                            score = 0;
                            ShowQuestions(dyscalculiaTest);
                            Console.WriteLine($"Probability of Dyscalculia is: {score}%");
                            
                            // Reset and run Dysgraphia
                            score = 0;
                            ShowQuestions(dysgraphiaTest);
                            Console.WriteLine($"Probability of Dysgraphia is: {score}%");
                            break;
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input! Try Again!");
                }
            }
        }
    }
}