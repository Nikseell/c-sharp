using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : Person
    {
        private double _gpa;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public double GetGpa()
        {
            return _gpa;
        }

        public void SetGpa(double gpa)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"Gpa: {_gpa}");
        }
    }
}
