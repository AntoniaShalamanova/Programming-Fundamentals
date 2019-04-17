using System;
using System.Linq;
using System.Collections.Generic;

namespace P4AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> ourClass = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                Student student = new Student();

                student.Name = input[0];
                input.RemoveAt(0);
                student.Grades = input.Select(double.Parse).ToList();

                ourClass.Add(student);
            }

            foreach (var person in ourClass.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrade:F2}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); } }
    }
}
