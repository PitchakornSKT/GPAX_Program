using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGPAX_Program
{
    internal class Classroom
    {
        private string name;
        private List<Person> persons = new List<Person>();
        private int _ageSum = 0;
        private Person _minPerson = new Person);

        public Classroom(string name)
        {
            this.name = name;

        }
        public void addPerson2Class(Person newPerson)
        {
            this.persons.Add(newPerson);
            this._ageSum+= newPerson.getGPA();

            if(newPerson.getGPA()< _minPerson.getGPA())
            {
                this._minPerson= newPerson;
            }
        }

        public string getNameOfMinGPA()
        {
            return this._minPerson.getName();
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }

        public int getPersonCount()
        {
            return this.persons.Count;
        }

        public int getAgeSumaryOfThisClass()
        {
            return this._ageSum;
        }

        public double getAgeAverang()
        {
            return this._ageSum / this.persons.Count;
        }
        public double getGPAAverang()
        {
            double _avg = 0.0;
            foreach (Person p in this.persons)
            {
                _avg += p.getGPA();
            }
            return this._ageSum / this.persons.Count;
        }
    }
}
