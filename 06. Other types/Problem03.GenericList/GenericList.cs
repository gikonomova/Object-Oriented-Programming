using System;
using System.Collections;
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
    public class GenericList<T> : IEnumerable<T>

        where T : IComparable
    {
        private const int DefaulfCapacity = 16;
        private T[] array;
        private int currentIndex;
        private int currentCapacity;

        public GenericList(int initialCapacity = DefaulfCapacity)
        {
            this.array = new T[initialCapacity];
            this.currentIndex = 0;
        }

        public void Add(T item) //Adding an element 
        {
            if (this.currentIndex >= this.array.Length)
            {
                this.Resize();
            }
           
            this.array[this.currentIndex] = item;
            this.currentIndex++;
        }

        private void Resize() //Implement auto-grow functionality
        {
            var newElements = new T[this.array.Length * 2];
            for (int i = 0; i < currentIndex; i++)
            {
                newElements[i] = this.array[i];
            }
            this.array = newElements;
        }

        public int IndexOf(T indexItem) //Finding element index by given value
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty!");
            }
            for (int i = 0; i < currentIndex; i++)
            {
                if (this.array[i].Equals(indexItem))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(T item) //Removing an element by index
        {
            if (this.currentIndex == -1)
            {
                throw new ArgumentException("Element not found!");
            }
            int index = this.IndexOf(item);
            for (int i = 0; i < this.currentIndex - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.currentIndex--;
            this.array[currentIndex] = default(T);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Max() //Generic methods Max<T>() 
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty!");
            }
            T maxElement = this.array[0];
            for (int i = 1; i < currentIndex; i++)
            {
                if ((maxElement.CompareTo(this.array[i]) < 0))
                {
                    maxElement = this.array[i];
                }
            }
            return maxElement;
        }

        public T Min() //Generic methods Min<T>() 
        {
            if (this.currentIndex == 0)
            {
                throw new ArgumentException("The list is empty!");
            }
            T minElement = this.array[0];
            for (int i = 1; i < currentIndex; i++)
            {
                if ((minElement.CompareTo(this.array[i]) > 0))
                {
                    minElement = this.array[i];
                }
            }
            return minElement;
        }

        public T this[int i]  //Accessing element by index
        {
            get
            {
                if (i < 0 || i >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index was outside the boundaries of the custom list!");
                }
                return this.array[i];
            }
            set
            {
                this.array[i] = value;
            }

        }
        public override string ToString() //Printing the entire list (override ToString()). 
        {
            return string.Format("[{0}]", string.Join(", ", this.array.Take(currentIndex)));
        }
    }
}
