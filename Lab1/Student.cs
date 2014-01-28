using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    class Student: IComparable
    {
        private string _m_name;
        private double _m_grade;

        public string m_name
        {
            get { return this._m_name; }
            set { this._m_name = value;  }
        }
        public double m_grade
        {
            get { return this._m_grade; }
            set { this._m_grade = value; }
        }

        public void Print()
        {
            Console.WriteLine(String.Format("Student's name....: {0}", _m_name));
            Console.WriteLine(String.Format("Student's grade...: {0}", _m_grade));
            Console.WriteLine();
        }

        public Student(String name, double grade)
        {
            this._m_grade = grade;
            this._m_name = name;
        }

        public Student()
        {
        }

        public class CompareByName : IComparer<Student>
        {
            public int Compare(Student a, Student b)
            {
                if (a == null) return -1;
                if (b == null) return +1;
                return String.Compare(a._m_name, b._m_name);
            }
        }

        
        public int CompareTo(Object other)
        {
            Student otherStudent = (Student)other;
            if (this._m_grade < otherStudent._m_grade) return -1;
            if (this._m_grade > otherStudent._m_grade) return +1;
            return 0;
        }
    }
}
