using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Employee : Person, ICloneable
    {
        public int salary { get; set; }
        public string profession { get; set; }

        public Employee() { }

        public Employee(string name, int birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + this.salary + ", Profession: " + this.profession;
        }

        /*public object Clone()
        {
            return this.MemberwiseClone();
        }*/

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            //newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }


    }
}
