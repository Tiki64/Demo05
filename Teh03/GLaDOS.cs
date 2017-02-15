using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh03
{
    class GLaDOS
    {
        public void UseHuman(Chell human)
        {
            Console.WriteLine("GLaDOS uses human for testing : " + human.Name);
        }

        ~GLaDOS()
        {
            Console.WriteLine("GLadDOS is destructed.");
        }
        
    }
}
