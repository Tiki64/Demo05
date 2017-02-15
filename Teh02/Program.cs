using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new Teh02.CD();
            levy.Hinta = 20;
            levy.CdName = "Endless Forms Most Beautiful";
            levy.Artist = "Nightwish";
            levy.AddBiisi("Shudder Before the Beautiful", "6:29");
            levy.AddBiisi("Weak Fantasy", "5:23");
            levy.AddBiisi("Elan", "4:45");
            levy.AddBiisi("Yours Is an Empty Hope", "5:34");
            levy.AddBiisi("Our Decades in the Sun", "6:37");
            levy.AddBiisi("My Walden", "4:38");
            levy.AddBiisi("Endless Forms Most Beautiful", "5:07");
            levy.AddBiisi("Edema Ruh", "5:15");
            levy.AddBiisi("Alpenglow", "4:45");
            levy.AddBiisi("The Eyes of Sharbat Gula", "6:03");
            levy.AddBiisi("The Greatest Show on Earth", "24:00");
            Console.WriteLine(levy.ToString());
        }
    }
}
