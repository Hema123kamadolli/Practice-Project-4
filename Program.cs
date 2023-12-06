using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_4DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input details 
            Console.WriteLine("**** STUDENTS ****");
            Console.WriteLine("Enter the number of students:");
            int n = int.Parse(Console.ReadLine());

            // array to store Student objects
            Student[] stud = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter student {i + 1} name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter class:");
                int cls = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter section:");
                char section = char.Parse(Console.ReadLine());

                // Create a new Student object and store it in the array
                stud[i] = new Student(name, cls, section);
                Console.WriteLine();
            }

            // Input details 
            Console.WriteLine("**** TEACHERS ****");
            Console.WriteLine("Enter the number of teachers:");
            int n1 = int.Parse(Console.ReadLine());

            //array to store Teacher objects
            Teacher[] teacher = new Teacher[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine($"Enter teacher {i + 1} name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter class:");
                int class1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter section:");
                char section = char.Parse(Console.ReadLine());

                // Create a new Teacher object and store it in the array
                teacher[i] = new Teacher(name, class1, section);
                Console.WriteLine();
            }
            // Input details 
            Console.WriteLine("**** SUBJECTS ****");

            Console.WriteLine("Enter the number of subjects:");
            int n2 = int.Parse(Console.ReadLine());

           //array to store Subject objects
           Subject[] sub = new Subject[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine($"Enter subject {i + 1} name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter subject code:");
                string code = Console.ReadLine();

                Console.WriteLine($"Enter assigned teacher name for {name}:");
                string teacherName = Console.ReadLine();

                // Find the teacher from the array
                Teacher assignedTeacher = Array.Find(teacher, t => t.Name == teacherName);

                // Create a new Subject object and store it in the array
                sub[i] = new Subject(name, code, assignedTeacher);
                Console.WriteLine();
            }

            // Printing details of STUDENTS
            Console.WriteLine("********* PRINTING DETAILS OF STUDENTS ********");
            foreach (var item in stud)
            {
                Console.WriteLine($"Student Name  : {item.Name}");
                Console.WriteLine($"Class         : {item.Class}");
                Console.WriteLine($"Section       : {item.Section}");
                Console.WriteLine();
            }
            // Printing details of TEACHERS
            Console.WriteLine("********* PRINTING DETAILS OF TEACHERS *******");
            foreach (var item in teacher)
            {
                Console.WriteLine($"Name    : {item.Name}");
                Console.WriteLine($"Subject : {item.Class}");
                Console.WriteLine($"Section : {item.Section}");
                Console.WriteLine();
            }
            // Printing details of SUBJECTS
            Console.WriteLine("************ PRINTING DETAILS OF SUBJECTS *********");
            foreach (var item in sub)
            {
                Console.WriteLine($"Name            : {item.Name}");
                Console.WriteLine($"Subject Code    : {item.SubCode}");
                Console.WriteLine($"Assigned Teacher: {item.AssignedTeacher?.Name ?? "Not Assigned"}");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
