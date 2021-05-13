using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public string GetJobTitle()
        {
            return _jobTitle;
        }

        public void SetJobTitle(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"Job: {_jobTitle}");
        }
    }
}
