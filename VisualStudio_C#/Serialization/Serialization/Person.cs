using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public int age;
        public string name;
        
        public Person(int Age, string Name)
        {
            this.age = Age;
            this.name = Name;
        }

        public Person()
        {

        }
    }
}
