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
    public class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, char gender, double size, ConsoleColor color = ConsoleColor.Green) : base(name, age, gender)
        {
            this.Size = size;
            this.Color = color;            
        }

        public double Size { get; set; }
        public ConsoleColor Color { get; set; }       

        public void Jumping()
        {
            Console.WriteLine("{0} the frog is jumping aroung", this.Name);
        }

        public void ProduceSound()
        {
            Console.WriteLine("Ribbit, ribbit, ribbit!");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name:" + " " + this.Name);
            sb.AppendLine("Gender:" + " " + this.Gender);
            sb.AppendLine("Age:" + " " + this.Age);
            if (this.Size != 0)
            {
                sb.AppendLine("Size:" + " " + this.Size + " " + "cm.");
            }
            if (this.Color != null)
            {
                sb.AppendLine("Color:" + " " + this.Color);
            }
            
            return sb.ToString();
        }
    }
}
