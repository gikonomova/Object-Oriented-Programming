using System;

//Define an abstract class Human holding a first name and a last name.
//Define a class Student derived from Human that has a field faculty number(5-10 digits / letters).
//Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns the payment earned by hour by the worker.
//Define the proper constructors and properties for the classes in your class hierarchy.
//Initialize a list of 10 students and sort them by faculty number in 
//ascending order(use a LINQ query or the OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by payment per hour in descending order.
//Merge the lists and then sort them by first name and last namev

namespace Problem01.HumanStudentAndWorker
{
    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}