internal class Question 
{
    // Attributes
    public string Q { get; set; }
    public DifficultyType Category { get; set; }
    public long Score { get; set; }

    // Constructors
    public Question() { } // Default constructor for inheritance purposes

    public Question(string q, long score, DifficultyType category = 0)  
    {
        Q = q;
        Score = score;
        Category = category;
    }

    // Operator Overloading
    public static Question operator ++(Question x) 
    {
        // Increments the score by 1 and returns a new Question instance
        return new Question(x.Q, x.Score + 1, x.Category);
    }
}