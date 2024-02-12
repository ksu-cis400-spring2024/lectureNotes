using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public enum Grade { A, B, C, D, F};

    public class Student
    {
        private double hours;
        private double points;

        public double GPA => points / hours;
        public string First { get; set; }
        public string Last { get; set; }

        public Student(string first, string last)
        {
            this.First = first;
            this.Last = last;
        }

        public void AddCourseGrade(uint creditHours, Grade finalGrade)
        {
            this.hours += creditHours;
            switch (finalGrade)
            {
                case Grade.A:
                    this.points += 4 * creditHours;
                    break;
                case Grade.B:
                    this.points += 3 * creditHours;
                    break;
                case Grade.C:
                    this.points += 2 * creditHours;
                    break;
                case Grade.D:
                    this.points += 1 * creditHours;
                    break;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {First} {Last}");
            Console.WriteLine($"GPA: {GPA}");
        }
    }


    public class UndergraduateStudent : Student
    {
        public UndergraduateStudent(string first, string last)
        {
            //why an error?
        }
    
        //Print?
    }


    public class GraduateStudent : Student
    {
        public string BachelorDegree { get; private set; }

        public GraduateStudent(string first, string last, string degree)
        {
            First = first;
            Last = last;
            BachelorDegree = degree;

            //why an error?
        }

        //Print?
    }
}
