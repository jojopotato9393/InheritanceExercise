using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birds : Animals
    {
        public string BirdColor  { get; set; }
        public string BeakType { get; set; }
        public string FoodType { get; set; }
        public string BirdType { get; set; }

        public void MyBird()
        {
            Console.WriteLine($"A {BirdColor} {BirdType} is eating {FoodType} with its {BeakType} beak near a {Biome} ");
        }

    }
}
