using System;

namespace ConsoleTests
{
    // Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
    // If an invalid number or non-number text is entered, the method should throw an exception. Using this method
    // write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters
    // an invalid number, let the user to enter again.
    class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > start && input < end)
            {
                return input;
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Format("Number must be between {0} and {1}", start, end));
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("Enter a number: ");

                    if (i == 0)
                    {
                        numbers[i] = ReadNumber(0, 100);
                    }
                    else
                    {
                        numbers[i] = ReadNumber(numbers[i - 1], 100);

                    }

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Write(ex.Message + "\nEnter a valid number: ");
                    numbers[i] = ReadNumber(numbers[i - 1], 100);

                }

            }

            Console.WriteLine(string.Join(", ", numbers));

            Console.ReadLine();
        }

    }
}
