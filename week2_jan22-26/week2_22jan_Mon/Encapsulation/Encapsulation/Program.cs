using Encapsulation;

public class Program
{
    private static List<string> _names;
    private static Dictionary<string, List<int>> _scores;
    private static Dictionary<string, string> _majors;

    private static void Main(string[] args)
    {
        //Create a PointStruct called p1 storing (3, 4)
        PointStruct p1 = new(3, 4);

        //Make another, p2, and set equal to p1
        PointStruct p2 = p1;
        //p2.X = 10;

        p1.Print();
        p2.Print();

        //what happens when we change one?

        //What happens when we pass to a method?



        /*
         _names = new();
        _scores = new();
        _majors = new();

        //Bob, CS, 80/70/92
        //Jill, CMPEN, 95/68/88

        //write get average method

        //change major of Bob to MATH

         */
    }

    private static void ChangePoint(PointStruct p)
    {

    }

    private static double GetAverage(string name)
    {
        return 0.0;
    }

    private static void ChangeMajor(string name, string newMajor)
    {
        
    }
}