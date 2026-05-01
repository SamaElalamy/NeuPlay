internal class DyscalculiaTest : Question
{
    // Attributes
    public long dyscalculiaTestScore;

    // Constructor
    public DyscalculiaTest(long score = 0)
    {
        dyscalculiaTestScore = score;
    }

    // Overload Operator
    public static DyscalculiaTest operator ++(DyscalculiaTest x)
    {
        return new DyscalculiaTest(x.dyscalculiaTestScore + 1);
    }

    /* 
    public static DyscalculiaTest operator +(DyscalculiaTest x, DysgraphiaTest y)     
    {         
        long Totalscore = x.dyscalculiaTestScore + y.dyscalculiaTestScore;         
        return new DyscalculiaTest(Totalscore);     
    }
    */
}