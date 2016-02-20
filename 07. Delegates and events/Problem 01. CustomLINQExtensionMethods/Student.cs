using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.CustomLINQExtensionMethods
{
    class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;

        }

        public int Grade
        {
            get 
            {
                return grade;
            }
            set 
            {
                if (value < 2)
                {
                    throw new ArgumentException("Grade cannot be smaller than 2.");
                }

                this.grade = value; 
            }
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
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        
    }
}
