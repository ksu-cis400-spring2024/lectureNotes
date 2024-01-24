using Encapsulation;

public class Program
{
    private static List<Student> _students;

    private static void Main(string[] args)
    {
        LabRoom room = new LabRoom {Windows = false};

        LabRoom.DrinksAllowed = true;
        //room.DrinksAllowed = false; //this changed policy for everyone


        _students = new();

        //Bob, CS, 80/70/92

        Student bob = new Student { Name = "Bob", Major = "CS" };
        bob.AddScore(80);
        bob.AddScore(70);
        bob.AddScore(92);

        //Jill, CMPEN, 95/68/88

        //print each average
        Console.WriteLine(bob.Average);
        _students.Add(bob);

        //change major of Bob to MATH
    }
}