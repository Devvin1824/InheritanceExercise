using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal 
    {
        public bool LayEggs { get; set; }
        public bool HaveScales { get; set; }
        public int MaxSpeed { get; set; }
        public bool Carnivore { get; set; }
    }
}
