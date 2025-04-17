using System.Threading.Channels;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Create a Program that depicts the usage of LINQ
             *  LINQ (Language Integrated Queries). LINQ is a
             *  C# Intergration feature that allows programmers to
             *  write SQL-like Queries such as:
             *  - Select
             *  - OrderBy, etc
             */

            /*
             * Create a Partial Class Called Student. Partial Classes
             * allow for a class definition to be split across multiple
             * files
             */
            List<Student> students = new List<Student>()
        {
            new Student() { Name = "John", Marks = 95 },
            new Student() { Name = "Jane", Marks = 85 },
            new Student() { Name = "Jack", Marks = 75 },
            new Student() { Name = "Jill", Marks = 65 },
            new Student() { Name = "Joe", Marks = 55 }
        };

            // Prompt the user to filter for a mark
            Console.WriteLine("Please enter a Mark to Filter: ");
            if (int.TryParse(Console.ReadLine(), out int userMark))
            {
                // Query Mark Based on Filter Entry
                var filteredStudents = from s in students // Searching students List
                                       where s.Marks >= userMark // Based on criteria
                                       select s; // Selecting only applicable students

                // Display
                Console.WriteLine("Filtered Students: ");
                foreach (var s in filteredStudents)
                {
                    Console.WriteLine(s.Name);
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");

            }

            // Query: Orderby students Names
            var orderedStudents = from s in students
                                  orderby s.Name
                                  select s;

            // Display
            Console.WriteLine("Sorted Students: ");
            foreach (var s in orderedStudents)
            {
                Console.WriteLine(s.Name);
            }
            // Query: Students Achieved A Aggregate
            var studentsAchievedA = from s in students
                                    where s.Grade() == "A"
                                    select s;

            // Display
            Console.WriteLine("Students Achieved A: ");
            foreach (var s in studentsAchievedA)
            {
                Console.WriteLine($" Name: {s.Name} with a mark of {s.Marks}");
            }
        }





    }

    //

}
