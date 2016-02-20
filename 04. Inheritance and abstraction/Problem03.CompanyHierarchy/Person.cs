using System;
using Problem03.CompanyHierarchy.Interfaces;
using System.Text;

//Create the following OOP class hierarchy:
//Person – general class for anyone, holding id, first name and last name.
//Employee – general class for all employees, holding the field salary and department. 
//The department can only be one of the following: Production, Accounting, Sales or Marketing.
//Manager – holds a set of employees under his command.
//RegularEmployee
//SalesEmployee – holds a set of sales. A sale holds product name, date and price.
//Developer – holds a set of projects. A project holds project name, project start date, details and a state (open or closed). A project can be closed through the method CloseProject().
//Customer – holds the net purchase amount (total amount of money the customer has spent).
//Extract interfaces for each class. (e.g. IPerson, IEmployee, IManager, etc.)
//The interfaces should hold their public properties and methods (e.g. IPerson should hold id, first name and last name).
//Each class should implement its respective interface.
//Define proper constructors. Avoid code duplication through abstraction. Encapsulate all data and validate the input. 
//Throw exceptions where necessary. Override ToString() in all classes to print detailed information about the object.
//Create several employees of type Manager, SalesEmployee and Developer and add them in a single collection. 
//Finally, print them in a for-each loop.

namespace Problem03.CompanyHierarchy
{
   public abstract class Person  : IPerson
    {
       private string firstName;
       private string lastName;
       private int id;     

       public Person(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");    
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ID cannot be negative or zero.");
                }
                this.id = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("First Name: {0}", this.FirstName));
            sb.AppendLine(string.Format("Last Name: {0}", this.LastName));
            sb.AppendLine(string.Format("ID: {0}", this.Id));

            return sb.ToString();
        }
    }
}
