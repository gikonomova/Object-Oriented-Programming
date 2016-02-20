using System;
using System.Text;

//Define a class Person that has name, age and email. The name and age are mandatory. 
//The email is optional. Define properties that accept non-empty name and age in the range [1 ... 100]. 
//In case of invalid arguments, throw an exception. 
//Define a property for the email that accepts either null or non-empty string containing '@'. 
//Define two constructors. The first constructor should take name, age and email. 
//The second constructor should take name and age only and call the first constructor.
//Implement the ToString() method to enable printing persons at the console.

class Persons
{
    private string name;
    private int age;
    private string email;

    public Persons(string name, int age)
    {
        this.Name = name;
        this.Age = age;        
    }

    public Persons(string name, int age, string email) : this(name, age)
    {
        this.Email = email;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 1 && value > 100)
            {
                throw new ArgumentException("Age must be a possitive number between [1...100]!");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if ((value != null) && (value == ""))
            {
                throw new ArgumentException("String must be null or non-empty!");
            }
            this.email = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Name:" + " " + this.Name);
        sb.AppendLine("Age:" + " " + this.Age);

        if (this.Email != null)
        {
            sb.AppendLine("Email:" + " " + this.Email);
        }

        return sb.ToString();        
    }

    static void Main()
    {
        Console.WriteLine("Enter name:");
        string namePersonOne = Console.ReadLine();
        Console.WriteLine("Enter age:");
        int agePersonOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter email:");
        string emailPersonOne = Console.ReadLine();
               
        Persons personOne = new Persons(namePersonOne, agePersonOne, emailPersonOne);
        Persons personTwo = new Persons(namePersonOne, agePersonOne);

        Console.WriteLine();
        Console.WriteLine(personOne.ToString());
        Console.WriteLine(personTwo.ToString());
        Console.ReadLine();
    }
}

