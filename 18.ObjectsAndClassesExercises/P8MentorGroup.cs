using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;


namespace P8MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                string[] data = input.Split(new char[] { ' ', ',' }).ToArray();
                string studentName = data[0];
                List<DateTime> dates = new List<DateTime>();
                List<string> comments = new List<string>();

                if (data.Length > 1)
                {
                    dates = data.Skip(1).Select(x => DateTime.ParseExact(x ,"dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                }

                //Check if dates are empty!
                if (students.Any(x => x.studentName == studentName))
                {
                    int studentIndx = students.FindIndex(x => x.studentName == studentName);
                    students[studentIndx].attendanceDays.AddRange(dates);
                }
                else
                {
                    Student student = new Student();
                    student.studentName = studentName;
                    student.attendanceDays = dates;
                    student.Comments = comments;

                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] data = input.Split('-').ToArray();

                string studentName = data[0];
                string comment = data[1];

                if (students.Any(x => x.studentName == studentName))
                {
                    int studentIndx = students.FindIndex(x => x.studentName == studentName);
                    students[studentIndx].Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x => x.studentName))
            {
                Console.WriteLine(student.studentName);
                Console.WriteLine("Comments:");

                foreach (var coment in student.Comments)
                {
                    Console.WriteLine($"- {coment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.attendanceDays.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }

    class Student
    {
        public string studentName { get; set; }
        public List<DateTime> attendanceDays{ get; set; }
        public List<string> Comments { get; set; }
    }
}
