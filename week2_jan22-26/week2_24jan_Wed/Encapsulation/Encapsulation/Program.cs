using Encapsulation;

public class Program
{
    private static List<string> _names;
    private static Dictionary<string, List<int>> _scores;
    private static Dictionary<string, string> _majors;

    private static void Main(string[] args)
    {
         _names = new();
        _scores = new();
        _majors = new();

        //Bob, CS, 80/70/92
        //Jill, CMPEN, 95/68/88

        //write get average method

        //change major of Bob to MATH
    }

    private static double GetAverage(string name)
    {
        return 0.0;
    }

    private static void ChangeMajor(string name, string newMajor)
    {
        
    }
}