using System;

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
    public class Student : Human
    {
        private string facilityNumber;

        public Student(string firstName, string lastName, string facilityNumber)
            : base(firstName, lastName)
        {
            this.FacilityNumber = facilityNumber;
        }

        public string FacilityNumber
        {
            get
            {
                return this.facilityNumber;
            }
            set
            {
                if ((value.Length < 5) || (value.Length > 10))
                {
                    throw new IndexOutOfRangeException("Facility number must contain 5-10 digits!");
                }
                this.facilityNumber = value;
            }
        }
    }


}

