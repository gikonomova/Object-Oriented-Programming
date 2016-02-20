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
    public class Company
    {
        public static void Main()
        {
            List<Project> projects = new List<Project>()
            {
                new Project("New Year development party", new DateTime(2015, 12, 31), "Celebrating New Year with C#, MSSQL and all other bros", State.Open),
                new Project("asdasdadaw", new DateTime(2015, 11, 12), "dasdsadsadsadasdsadsadsa", State.Open)
            };

            List<Sale> sales = new List<Sale>()
            {
                new Sale("Sony Xperia Z", new DateTime(2013, 5, 23), 800)
            };

            List<Employee> managerEmployees = new List<Employee>()
            {
                new DeveloperEmployee("Tasko", "Taskov", 3215, 23523, Departments.Production, projects),
                new SalesEmployee("Trifon", "Trifonov", 1234, 2353, Departments.Sales, sales)
            };
            //DeveloperEmployee dev = new DeveloperEmployee("Tasko", "Taskov", 3215, 23523, Departments.Production, projects);
            //Console.WriteLine(dev.ToString());

            List<Employee> employees = new List<Employee>()
            {
                new Manager("Bai", "Ganio", 666, 99999999, Departments.Sales, managerEmployees),
                new DeveloperEmployee("Tasko", "Taskov", 3215, 23523, Departments.Production, projects),
                new SalesEmployee("Trifon", "Trifonov", 1234, 2353, Departments.Sales, sales)
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
