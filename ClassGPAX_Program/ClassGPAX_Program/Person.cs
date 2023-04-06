using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGPAX_Program
{
    internal class Person
    {
        private string name;
        private int age;
        private int birthYear;
        private double gpa;

        public Person(string name, int bYear)
        {
            this.name = name;
            this.birthYear = bYear;
            this.age = 2565 - bYear;
            this.gpa = gpa;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }

        public int getGPA()
        {
            return this.gpa;
        }
    }
}
