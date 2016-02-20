using System;
using System.Collections.Generic;

//Define an abstract class Human holding a first name and a last name.
//Define a class Student derived from Human that has a field faculty number(5-10 digits / letters).
//Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns the payment earned by hour by the worker.
//Define the proper constructors and properties for the classes in your class hierarchy.
//Initialize a list of 10 students and sort them by faculty number in 
//ascending order(use a LINQ query or the OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by payment per hour in descending order.
//Merge the lists and then sort them by first name and last name

namespace Problem01.HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weeklySalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weeklySalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeeklySalary = weeklySalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeeklySalary
        {
            get { return this.weeklySalary; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Weekly Salary must be a possitive number!");
                }
                this.weeklySalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 && value > 24)
                {
                    throw new IndexOutOfRangeException("Working Hours Per Day must be between 1 - 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            return this.WeeklySalary / (this.WorkHoursPerDay * 5);
        }
    }
}
