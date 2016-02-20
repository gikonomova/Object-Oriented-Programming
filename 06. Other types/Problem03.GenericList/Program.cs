using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with a certain capacity,
//which is given as an optional parameter in the class constructor. Declare the default capacity of 16 as a constant.
//1.Implement methods for:
//2.Adding an element 
//3.Accessing element by index
//4.Removing element by index
//5.Inserting element at given position
//6.Clearing the list
//7.Finding element index by given value
//8.Checking if the list contains a value
//9.Printing the entire list (override ToString()). 
//Check all input parameters to avoid accessing elements at invalid positions.
//Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
//You may need to add generic constraints for the type T to implement IComparable<T>.

namespace Problem03.GenericList
{
    public class Program
    {
        public static void Main()
        {
            var list = new GenericList<int>(2);
            list.Add(0);
            list.Add(5);
            list.Add(-11);
            list.Add(-2);
            list.Add(100);
           
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.IndexOf(2));
       }
    }
}
