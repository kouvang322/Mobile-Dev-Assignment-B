using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B
{
    public abstract class Person
    {
        private string Name;

        public Person(string name) { this.Name = name; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
