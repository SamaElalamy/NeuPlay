internal class DysgraphiaTest : Question
{
    // Attributes
    public long dysgraphiaTestScore;

    // Constructor
    public DysgraphiaTest(long score = 0)
    {
        dysgraphiaTestScore = score;
    }

    // Overload Operator
    public static DysgraphiaTest operator ++(DysgraphiaTest a)
    {
        // Increments the score and returns a new instance
        return new DysgraphiaTest(a.dysgraphiaTestScore + 1);
    }
}