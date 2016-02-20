using System;
using System.Collections.Generic;
using System.Linq;

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
    class StudentAndWorkerSort
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
        {
        new Student("Ivan", "Shishkov", "92547364"),
        new Student("Ivan", "Ivanov", "23985421"),
        new Student("Victor", "Georgiev", "874352621"),
        new Student("Kalin", "Grigorov", "34654d753"),
        new Student("Aleksander", "Trifonov", "234234"),
        new Student("Yana", "Stoyanova", "2344326"),
        new Student("Dimitrinka", "Todorova", "86564345"),
        new Student("Lilly", "Malinova", "3455763"),
        new Student("Veselin", "Zapryanov", "32456"),
        new Student("Teodor", "Genov", "5786456"),
        new Student("Kalina", "Kalinova", "345345")
        };
            return students;
        }

        public static List<Worker> GetWorkers()
        {
            List<Worker> worker = new List<Worker>
        {
        new Worker("Pesho", "Stoyanov", 460.60m, 7),
        new Worker("Smirko", "Salfetkov", 500m, 9),
        new Worker("Antoaneta", "Gencheva", 120.80m, 3),
        new Worker("Kiril", "Metodiev", 790m, 8),
        new Worker("Deyan", "Danov", 1000.80m, 8),
        new Worker("Krasimira", "Veleva", 300.5m, 4),
        new Worker("Daniela", "Smirkova", 400, 4),
        new Worker("MAya", "Ilieva", 10000, 8),
        new Worker("Kamen", "Domev", 2400.70m, 7),
        new Worker("Nasko", "Jelyazkov", 100, 8),
        new Worker("Penko", "Karadjov", 200.98m, 5)
        };
            return worker;
        }
        static void Main()
        {
            List<Student> students = GetStudents(); //Initialize a list of 10 students and sort them by faculty number in ascending order

            IEnumerable<Student> sortedStudents = students.OrderBy(x => x.FacilityNumber);
            Console.WriteLine("Students:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("First Name: {0} \nLast Name: {1} \nFaciliti Number: {2}\n", student.FirstName, student.LastName, student.FacilityNumber);
            }

            List<Worker> workers = GetWorkers(); //Initialize a list of 10 workers and sort them by payment per hour in descending order.

            IEnumerable<Worker> sortedWorkes = workers.OrderBy(x => x.CalculateMoneyPerHour());
            Console.WriteLine("Workers:");
            foreach (var worker in sortedWorkes)
            {
                Console.WriteLine("First Name: {0} \nLast Name: {1} \nWorking Hours: {2}h \nSalary Per Week: {3}$ \nMoney Per Hour: {4:F2}$\n", worker.FirstName, worker.LastName, worker.WorkHoursPerDay, worker.WeeklySalary, worker.CalculateMoneyPerHour());
            }

        }
    }
}
