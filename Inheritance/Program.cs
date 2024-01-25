using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var birds1 = new Birds() { BirdType = "Conure", BirdColor = "Orange", BeakType = "Curved", FoodType = "Large seeds", Biome = "woods", };
            birds1.MyBird();

            Console.WriteLine();
            var Rep1 = new Reptile() { Type = "Snake", Eats = "mice", Size = "long", IdealTemp = 80, AvrageAge = 16, CanKillYou = true, Biome = "Unknown " };
            Rep1.MyReps();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
