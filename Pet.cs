using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B
{
    public abstract class Pet
    {
        protected string name;

        public Pet(string name) 
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

    }
}
