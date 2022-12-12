using System;
using System.Security;

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
           Bird bird = new Bird();
           bird.Walk = true;
           bird.Color = "Blue";
           bird.Height = "7 inches";
           bird.Age = 3;
           bird.BeakLength = 5;
           bird.WingSpan = 20;
           bird.CanFly = true;
           bird.ChirpNoise = "sqwuak";

           Console.WriteLine($"The answer to the question, 'Can this bird walk?' is {bird.Walk}. The bird is the color {bird.Color} and is {bird.Height} tall. It is {bird.Age} years" +
               $" old and has a beak length of {bird.BeakLength} inches. The Wingspan of this bird is {bird.WingSpan} inches and it is {bird.CanFly} that it can fly. The bird makes a " +
               $"{bird.ChirpNoise} noise");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            reptile.Walk = true;
            reptile.Color = "Brown";
            reptile.Height = "3 inches";
            reptile.Age = 12;
            reptile.LayEggs = true;
            reptile.HaveScales = true;
            reptile.MaxSpeed = 20;
            reptile.Carnivore = false;

            Console.WriteLine($"I found a reptile! Someone said it was {reptile.Walk} that it can walk, and it is {reptile.Color}. The reptile is only {reptile.Height} tall, but is {reptile.Age} " +
                $" years old and can move up to {reptile.MaxSpeed} miles per hour! Here is a list of other observation I have made: Does it Lay eggs? {reptile.LayEggs}." +
                $" Does it have scales?: {reptile.HaveScales}. " +
                $" Is it a Carnivore?: {reptile.Carnivore}.");
            


        }
    }
}
