using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClass
{
    class Person
    {
        private string _name;
        private string _familyName;
        private int _age;

        public Person() 
        {
            
        }

        public Person(string name)
        {
            _name = name;
        }

        public void SetName(string name) 
        {
            _name = name;                      
        }

        public string GetName() 
        {
            return _name;
        }

    }
}
