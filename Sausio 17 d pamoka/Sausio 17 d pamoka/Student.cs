using System;
using System.Collections.Generic;
using System.Linq;



namespace Sausio_17_d_pamoka
{
    internal struct Student
    {
        public string Name; // <-- by default čia yra ( get; set ) pagal nutylėjimą
        public string LastName;
        public List<int> Grades;

        public Student(string name, string lastName, List<int> grades) // <-- konstrukroius
        {
            Name = name;
            LastName = lastName;
            Grades = grades;
        }
        public double GetAverage()
        {
            return Grades.Average();
        }
    }
    public struct StudentX
    {
        public string Name;
        public string LastName;
        public DateTime CoueseStart;
        public DateTime CoueseEnd;

        public StudentX(string name, string lastName, DateTime coueseStart, DateTime coueseEnd)
        {
            Name = name;
            LastName = lastName;
            CoueseStart = coueseStart;
            CoueseEnd = coueseEnd;
        }

        public void PrintValues()
        {
            Console.WriteLine($"Students name: {Name}");
            Console.WriteLine($"Students last name: {LastName}");
            Console.WriteLine($"Coure start: {CoueseStart}");
            Console.WriteLine($"Course end: {CoueseEnd}");
        }
    }


}