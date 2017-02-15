using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh03
{
    class Program
    {
        static void Main(string[] args)
        {
            // create GlaDOS
            GLaDOS glados = new GLaDOS();
            // create Human
            Chell human = new Chell("Chell");
            // GLaDOS uses human
            glados.UseHuman(human);
            // null GLaDOS
            glados = null;

            GC.Collect();

            human.Printdata();

            Console.ReadLine();

        }
    }
}
