﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh02
{
    class Biisi
    {
        public string Name { get; set; }
        public string Length { get; set; }

        public override string ToString()
        {
            return "  - " + Name + ", " + Length;
        }
    }
}
