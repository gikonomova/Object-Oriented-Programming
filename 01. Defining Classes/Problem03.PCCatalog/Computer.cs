using System;
using System.Text;

//Define a class Computer that holds name, several components and price. 
//The components (processor, graphics card, motherboard, etc.) should be objects of class Component, which holds name, 
//details (optional) and price. 
//Define several constructors that take different sets of arguments.Use proper variable types.Use properties to validate the data.
//Throw exceptions when improper data is entered.
//Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. 
//The total price is the sum of all components' price.Print the prices in BGN currency format.
//Create several Computer objects, sort them by price, and print them on the console using the created display method.

class Computer
{
    private string comName;
    private Component processor;
    private Component ram;
    private Component graphicsCard;
    private double price;

    public Computer(string comName, Component ram, Component processor, Component graphicsCard)
    {
        this.ComName = comName;
        this.Ram = ram;
        this.Processor = processor;
        this.GraphicsCard = graphicsCard;
    }


    public string ComName
    {
        get
        {
            return this.comName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.comName = value;
        }
    }
    public double Price
    {      
        get
        {
            return GraphicsCard.Price + Ram.Price + Processor.Price;
        }
    }   
    public Component Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }
    public Component Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            this.ram = value;
        }
    }
    public Component GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Name:" + " " + this.ComName);

        if (this.Processor != null)
        {
            sb.AppendLine(string.Format("Processor name: {0}", this.Processor.Name));
            if (Processor.Detail != null)
            {
                sb.AppendLine(string.Format("Processor detail: {0}", this.Processor.Detail));
            }            
            sb.AppendLine(string.Format("Processor price: {0}", this.Processor.Price));
        }
        if (this.Ram != null)
        {
            sb.AppendLine(string.Format("Ram name: {0}", this.Ram.Name));
            if (Ram.Detail != null)
            {
                sb.AppendLine(string.Format("Ram detail: {0}", this.Ram.Detail));
            }
            sb.AppendLine(string.Format("Ram price: {0}", this.Ram.Price));
        }
        if (this.GraphicsCard != null)
        {
            sb.AppendLine(string.Format("Graphics Card name: {0}", this.GraphicsCard.Name));
            if (GraphicsCard.Detail != null)
            {
                sb.AppendLine(string.Format("Graphics Card detail: {0}", this.GraphicsCard.Detail));
            }
            sb.AppendLine(string.Format("Graphics Card price: {0}", this.GraphicsCard.Price));
        }
        sb.AppendLine("Total Price:" + " " + this.Price);
        return  sb.ToString();
    }
}