using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B
{
    public class Cat : Pet, ITalkable
    {
        private int mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            this.mousesKilled = mousesKilled;

        }

        public int GetMousesKilled()
        {
            return mousesKilled;
        }

        public void AddMouse()
        {
            mousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: name={name} mousesKilled={mousesKilled}";
        }


    }
}
