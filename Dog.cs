using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_B
{
    public class Dog : Pet, ITalkable
    {
        private bool friendly;
        public Dog(bool friendly, string name) : base(name)
        {
            this.friendly = friendly;
        }

        public bool IsFriendly()
        {
            return friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: name={name} friendly={IsFriendly}";
        }
    }
}
