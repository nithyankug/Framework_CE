using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace DayOne
{
    class Program
    {
        static private List<Student> _students;

        static void AddStudent(String name, double grade)
        {
            _students.Add(new Student(name, grade));
        }

        static void ListStudents()
        {
            Student std;
            double avrg = 0;

            Console.WriteLine("\nList of students:\n-----------------\n");
            for (int i = 0; i < _students.Count; i++)
            {
                std = _students[i] as Student;
                std.Print();
                avrg += std.m_grade;
            }
            avrg /= (double)_students.Count;

            Console.Write(String.Format("Average: {0}", avrg));
        }

        static void Main(string[] args)
        {
            Student.CompareByName nameComparator;

            /* Init list */
            _students = new List<Student>();

            /* Add some students */
            AddStudent("Zebra",   17);
            AddStudent("Jean",    18.5);
            AddStudent("Nithyan", 18.5);
            AddStudent("Arizona", 9);
            AddStudent("Patrick", 12);
            AddStudent("Jane",    2);

            /* List them, just to show everything is all right */
            ListStudents();

            /* Get a comparator */
            nameComparator = new Student.CompareByName();

            /* Sort using the name and list to prove it worked */
            _students.Sort(nameComparator as IComparer<Student>);
            Console.WriteLine("\n\n===============================");
            Console.WriteLine("Sorted list by name:");
            Console.WriteLine("\n");
            ListStudents();

            /*Sort using the mark of each students */
            _students.Sort();
            Console.WriteLine("\n\n===============================");
            Console.WriteLine("Sorted list by marks:");
            Console.WriteLine("\n");
            ListStudents();

            // Wait for key to close console
            Console.Read();
        }
    }
}
