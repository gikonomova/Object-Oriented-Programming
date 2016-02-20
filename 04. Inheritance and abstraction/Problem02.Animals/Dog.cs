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
    public class Dog : Animal, ISoundProducible
    {
        private string breed;
        public Dog(string name, int age, char gender, string breed, ConsoleColor color = ConsoleColor.Black)
            : base(name, age, gender)
        {
            this.Breed = breed;
            this.Color = color;
        }

        public string Breed
        {
            get { return this.breed; } 

            set 
        {
            if (value == "")
            {
                throw new ArgumentNullException("Value cannot be null!");
            }
            this.breed = breed;
        }
        }
        public ConsoleColor Color { get; set; }

        public void WagTail()
        {
            Console.WriteLine("{0} the dog is wagging it's tail.", this.Name);
        }

        public void ProduceSound()
        {
            Console.WriteLine("Bark! Bark! Bark!");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name:" + " " + this.Name);
            sb.AppendLine("Gender:" + " " + this.Gender);
            sb.AppendLine("Age:" + " " + this.Age);
            if (this.Breed != null)
            {
                sb.AppendLine("Breed:" + " " + this.Breed);
            }
            if (this.Color != null)
            {
                sb.AppendLine("Color:" + " " + this.Color);
            }

            return sb.ToString();
        }
    }
}
