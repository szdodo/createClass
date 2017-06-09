using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Employee : Person
    {
        public int salary { get; set; }
        public string profession { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + this.salary + ", Profession: " + this.profession;
        }

    }
}
