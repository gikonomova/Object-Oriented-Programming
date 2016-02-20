using System;

//Define a class Computer that holds name, several components and price. 
//The components (processor, graphics card, motherboard, etc.) should be objects of class Component, which holds name, 
//details (optional) and price. 
//Define several constructors that take different sets of arguments.Use proper variable types.Use properties to validate the data.
//Throw exceptions when improper data is entered.
//Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. 
//The total price is the sum of all components' price.Print the prices in BGN currency format.
//Create several Computer objects, sort them by price, and print them on the console using the created display method.

class Component
{
    private string name;
    private string detail;
    private double price;

    public Component(string name, double price)
    {
        this.Name = name; 
        this.Price = price;
    }
    public Component(string name, string detail, double price) : this(name, price)
    {
        this.Detail = detail;
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

    public string Detail
    {
        get
        {
            return this.detail;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.detail = value;
        }
    }

    public double Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number must be possitive!");
            }
            this.price = value;
        }
    }

}