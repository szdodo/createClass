using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Person
    {
        public enum Genders
        {
            Male,
            Female
        }

        public string Name { get; set; }
        public int BirthDate { get; set; }
        public Genders Gender { get; set; }

        public Person() { }

        public Person(string name, int birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public Person(string name, int birthDate, Genders gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        
        public override string ToString()
        {
            return "Name: " + this.Name + ", Birth date: " + this.BirthDate + ", Gender: " + this.Gender;
        }

    }
}
