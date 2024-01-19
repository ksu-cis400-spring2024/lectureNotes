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

        _names.Add("Bob");
        _scores.Add("Bob", new List<int> { 80, 70, 82 });


        _names.Add("Jill");
        _scores.Add("Jill", new List<int> { 95, 68, 88 });


        PointStruct p1 = new() { X = 3, Y = 4 };

        PointStruct p2 = p1;

        p2.X = 5;
        Console.WriteLine(p1.X);


    }

    public static int GetAverage(string name)
    {
        throw new NotImplementedException();
    }

    public static void ChangeMajor(string name, string newMajor)
    {
        throw new NotImplementedException();
    }
}