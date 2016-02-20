using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an abstract class Animal holding name, age and gender.
//Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. Dogs, frogs and cats are animals.
//Kittens are female cats and Tomcats are male cats. Define useful constructors and methods. 
//Define an interface ISoundProducible which holds the method ProduceSound(). All animals should implement this interface. 
//The ProduceSound() method should produce a specific sound depending on the animal invoking it (e.g. the dog should bark).
//Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ

namespace Problem02.Animals
{
    public class Cat : Animal, ISoundProducible
    {
        public Cat(string name, int age, char gender, ConsoleColor color = ConsoleColor.White) : base(name, age, gender)
        {
            this.Color = color;
        }

        public Cat(string name, int age, ConsoleColor color = ConsoleColor.White)
            : base(name, age)
        {
            this.Color = color;
        }

        public ConsoleColor Color { get; set; }

        public void Scratching()
        {
            Console.WriteLine("{0} the cat is scratching on the floor", this.Name);
        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow, meow, meow!");
        }

        
    }
}
