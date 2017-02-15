using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh03
{
    class Chell
    {

        public string Name { get; set; }
        public void Printdata()
        {
            Console.WriteLine("Chell is still alive");
            Console.WriteLine("Cake was not a lie");
        }
        public Chell(string name)
        {
            Name = name;
        }

        ~Chell()
        {
            Console.WriteLine("Chell " + Name + " is destructed");
        }
    }
}
