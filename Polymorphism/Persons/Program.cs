using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
            Person person1 = new Person("Nick", "Johnson", "Brodway street", 1);
            Student student1 = new Student(5.24);
            Employee employee1 = new Employee("Truck driver");


            person1.Display();
            student1.Display();
            employee1.Display();
        }
    }
}