internal class Users
{
    // Attributes
    public string Name { get; set; }
    public string Password { get; set; } // For login purposes
    public UserType Type { get; set; } // Useful for future role-based logic
    public string KnowsCondition { get; set; } // Tracks if the user is aware of their condition
    public int Age { get; set; }

    // Constructor
    public Users(string name, string pass, UserType type, string know, int age)
    {
        Name = name;
        Password = pass;
        Type = type;
        KnowsCondition = know;
        Age = age;
    }
}