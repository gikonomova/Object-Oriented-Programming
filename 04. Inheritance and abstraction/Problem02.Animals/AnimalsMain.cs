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
//Create an array of different kinds of animals and calculate the average age of each kind of animal using LINQ.

namespace Problem02.Animals
{
    class AnimalsMain
    {
        static void Main()
        {
            Animal[] animals = new Animal[10]
            { 
            new Frog("Lacho", 3, 'M', 12),
            new Kitten("Maci", 10, ConsoleColor.DarkGray, ConsoleColor.Blue),
            new Tomcat("Tom", 8, ConsoleColor.DarkRed, ConsoleColor.DarkYellow),
            new Tomcat("Jim", 12, ConsoleColor.Magenta, ConsoleColor.Blue),
            new Dog("Jessy", 3, 'F', "Pomeran"), 
            new Frog("Froggy", 1, 'F', 34, ConsoleColor.DarkGreen),
            new Dog("Balkan", 14, 'M', "Gonche"),
            new Frog("Jabka", 40, 'F', 43),
            new Kitten("Sashka", 6, ConsoleColor.Gray, ConsoleColor.Blue),
            new Dog("Petko", 9, 'M', "Labrador", ConsoleColor.White)        
            };
            
             animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            animals.GroupBy(animal => animal.GetType().Name).Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                }).OrderByDescending(group => group.AverageAge).ToList().ForEach(group => Console.WriteLine("{0}'s average age is: {1:F2}", group.AnimalName, group.AverageAge));
            Console.ReadLine();
        }

    }
}
