using Problem03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime startDate, string details, State state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
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
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details field cannot be null or empty. ");
                }
                this.details = value;
            }
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }


        public void CloseProject()
        {
            if (this.State == State.Open)
            {
                this.State = State.Closed;
            }
        }
    }
}
