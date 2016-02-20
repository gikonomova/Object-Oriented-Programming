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
    public class Kitten : Cat
    {
        public Kitten(string name, int age, ConsoleColor color, ConsoleColor eyeColor)
            : base(name, age)
        {
            this.Gender = 'F';
            this.Color = color;
            this.EyeColor = eyeColor;

        }
        public ConsoleColor EyeColor { get; set; }
        public ConsoleColor Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name:" + " " + this.Name);
            sb.AppendLine("Gender:" + " " + this.Gender);
            sb.AppendLine("Age:" + " " + this.Age);
            
            if (this.Color != null)
            {
                sb.AppendLine("Color:" + " " + this.Color);
            }
            if (this.EyeColor != null)
            {
                sb.AppendLine("Eye Color:" + " " + this.EyeColor);
            }
            return sb.ToString();
        }
    }
}
