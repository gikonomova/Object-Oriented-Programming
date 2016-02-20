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
    public class SalesEmployee : Employee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Departments departments, List<Sale> sales)
            : base(firstName, lastName, id, salary, departments)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/////////////////////////////////////////////");
            sb.AppendLine("Employee type: Sales");
            sb.AppendLine(base.ToString());
            sb.AppendLine("Employee sales: ");
            foreach (var sale in this.Sales)
            {
                sb.AppendLine("------------------");
                sb.AppendLine(string.Format("Sale product name: {0}", sale.ProductName));
                sb.AppendLine(string.Format("Sale date: {0}", sale.Date));
                sb.AppendLine(string.Format("Sale price: {0}", sale.Price));
                sb.AppendLine("------------------\n"); 
            }

            return sb.ToString();

        }
    }
}
