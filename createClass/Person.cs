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

        public string name { get; set; }
        public int birthDate { get; set; }
        public Genders gender { get; set; }

        public Person() { }

        public Person(string name, int birthDate, Genders gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        
        public override string ToString()
        {
            return "Name: " + this.name + ", Birth date: " + this.birthDate + ", Gender: " + this.gender;
        }

    }
}
