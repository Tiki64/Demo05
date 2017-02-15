using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class CD
    {
        public string CdName { get; set; }
        public string Artist { get; set; }
        public List<Biisi> Biisit = new List<Biisi>();
        public float Hinta { get; set; }

        public void AddBiisi(string name, string length)
        {
            Biisit.Add(new Biisi { Name = name, Length = length});
        }

        public override string ToString()
        {
            string Songs = "";
            foreach (Biisi item in Biisit)
            {
                Songs = Songs +  item.ToString() + "\n";
            }
            return "CD data: \n- CD name: " + CdName + "\n- Artist: " + Artist + "\n- Hinta: " + Hinta + "\n- Songs: \n" + Songs;


        }
    }
}
