using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

class SquareRoot
{
    static void Main()
    {
        string input = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(input);
            double sqRoot = Math.Sqrt(number);
            if (number < 1)
            {
                throw new ArgumentException("Number must be possitive!");
            }
            else
            {
                Console.WriteLine("Square Root is {0}", sqRoot);
            }

        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid integer format!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number cannot fit in an Int32!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Number must be possitive!");
        }
        finally
        {
            Console.WriteLine("Good Bye");
            Console.ReadLine();
        }
    }
}

