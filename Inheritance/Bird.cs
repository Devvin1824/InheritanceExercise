using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int BeakLength { get; set; }
        public int WingSpan { get; set; }
        public bool CanFly { get; set; }
        public string ChirpNoise { get; set; }
    }
}
