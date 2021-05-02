using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs
{
    class Dogs
    {
        private string _name;
        private string _sex;
        private string _father;
        private string _mother;

        public Dogs(string name, string sex,string father, string mother)
        {
            _name = name;
            _sex = sex;
            _father = father;
            _mother = mother;
        }

        public void FathersName()
        {
            if(_father == string.Empty)
            {
                Console.WriteLine("Father unknown");
            }
            else
            {
                Console.WriteLine($"Father is: {_father}");
            }
        }

        public bool HasSameMotherAs(Dogs name)
        {
            if(_mother == name._mother)
            {
                Console.Write("true");
                return true;
            }
            else
            {
                Console.Write("false");
                return false;
            }
        }
    }
}
