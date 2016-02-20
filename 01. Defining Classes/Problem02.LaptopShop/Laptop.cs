using System;
using System.Text;

//Define a class Laptop that holds the following information about a laptop device:
//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
//The model and price are mandatory.All other values are optional.
//Define two separate classes: a class Laptop holding an instance of class Battery.
//Define several constructors that take different sets of arguments(full laptop + battery information or only part of it). 
//Use proper variable types.
//Add a method in the Laptop class that displays information about the given instance
//Tip: override the ToString() method
//Put validation in all property setters and constructors.String values cannot be empty, and numeric data cannot be negative
//.Throw exceptions when improper data is entered.

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private double price;

    public Laptop(string model, string manufacturer, double price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
    }

    public Laptop(string model, string manufacturer, string processor, int ram, double price) : this(model, manufacturer, price)
    {
        this.Processor = processor;
        this.Ram = ram;
    }

    public Laptop(string model, string manufacturer, string processor, int ram, Battery battery, double price)
        : this(model, manufacturer, processor, ram, price)
    {
        this.Battery = battery;
 
    }

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard,
       string hdd, string screen, Battery battery, double price)
        : this(model, manufacturer, processor, ram, battery, price)
    {
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
     }    

    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.processor = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.graphicsCard = value;
        }
    }

    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.screen = value;
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

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number must be possitive!");
            }
            this.ram = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Model:" + " " + this.Model);

         if (this.Manufacturer != null)
        {
            sb.AppendLine("Manufacturer:" + " " + this.Manufacturer);
        }
        if (this.Processor != null)
        {
            sb.AppendLine("Processor:" + " " + this.Processor);
        }
        if (this.GraphicsCard != null)
        {
            sb.AppendLine("GraphicsCard:" + " " + this.GraphicsCard);
        }
        if (this.Ram != 0)
        {
            sb.AppendLine("RAM:" + " " + this.Ram + " " + "GB");
        }
        if (this.Hdd != null)
        {
            sb.AppendLine("HDD:" + " " + this.Hdd);
        }
        if (this.Screen != null)
        {
            sb.AppendLine("Screen:" + " " + this.Screen);
        }
        if (this.Battery != null)
        {
            sb.AppendLine(string.Format("Battery type: {0}", this.Battery.BatteryType));  
            sb.AppendLine(string.Format("Battery life: {0}", this.Battery.BatteryLife));
        }
            sb.AppendLine("Price:" + " " + this.Price);
        return sb.ToString();
    }
}

