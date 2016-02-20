using System;

//Define a class Computer that holds name, several components and price. 
//The components (processor, graphics card, motherboard, etc.) should be objects of class Component, which holds name, 
//details (optional) and price. 
//Define several constructors that take different sets of arguments.Use proper variable types.Use properties to validate the data.
//Throw exceptions when improper data is entered.
//Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. 
//The total price is the sum of all components' price.Print the prices in BGN currency format.
//Create several Computer objects, sort them by price, and print them on the console using the created display method.

class PCCatalog
{
    static void Main()
    {
        Component processorOne = new Component("Intel Pentium B960 / 2.2 GHz", 256.56d);
        Component ramOne = new Component("168-pin SDRAM DIMMs", 100.34d);
        Component cardOne = new Component("Intel HD Graphics", "Dynamic Video Memory Technology 5.0", 2342);

        Computer first = new Computer("Toshiba Satellite C655-S5514", ramOne, processorOne, cardOne);

        Console.WriteLine(first.ToString());
        Console.ReadLine();

    }
}

