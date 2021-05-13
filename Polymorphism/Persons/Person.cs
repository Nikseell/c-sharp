using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        protected int _id;

        public Person()
        {

        }

        public Person(string fistName, string lastName, string adress, int id)
        {
            _firstName = fistName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }

        public string GetName()
        {
            return _firstName;
        }

        public void SetName(string name)
        {
            _firstName = name;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string name)
        {
            _lastName = name;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public void SetAdress(string adress)
        {
            _adress = adress;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Person: {_firstName}, {_lastName}, {_adress}, {_id}");
        }
    }
}
