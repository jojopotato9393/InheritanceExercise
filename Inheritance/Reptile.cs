using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animals
    {
        public string Type { get; set; }
        public string Eats {  get; set; }
        public string Size {  get; set; }
        public int IdealTemp { get; set; }

        public void MyReps()
        {
            Console.WriteLine($"{Type}:  Size:{Size}  Food:{Eats}  {IdealTemp}:degrees  " +
                $"Age:{AvrageAge}  Location:{Biome}  Dangerous {CanKillYou}");
        }

    }
}
