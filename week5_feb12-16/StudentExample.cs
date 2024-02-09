/// <summary>
/// A class representing a student
/// </summary>
public class Student {

  // private backing variables
  private double hours;
  private double points;

  public double GPA => points / hours;
  public string First { get; set; }
  public string Last { get; set; }

  public Student(string first, string last) {
    this.First = first;
    this.Last = last;
  }

  public AddCourseGrade(uint creditHours, Grade finalGrade) {
    this.hours += creditHours;
    switch(finalGrade) {
      case Grade.A:
        this.credits += 4 * creditHours;
        break;
      case Grade.B:
        this.credits += 3 * creditHours;
        break;
      case Grade.C:
        this.credits += 2 * creditHours;
        break;
      case Grade.D:
        this.credits += 1 * creditHours;
        break;
    }
  }
}


/// <summary>
/// A class representing an undergraduate student
/// </summary>
public class UndergraduateStudent : Student {

  public UndergraduateStudent(string first, string last) : base(first, last) {
  }
}


public class GraduateStudent : Student {
  public string BachelorDegree {
    get; private set;
  }

  public GraduateStudent(string first, string last, string degree) : base(first, last) {
    BachelorDegree = degree;
  }
}