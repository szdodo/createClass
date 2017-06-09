using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass{

    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.name = "Ka";
            per.birthDate = 11;
            Console.WriteLine(per.ToString());
            Person peri = new Person("Kak", 4, Person.Genders.Female);
            Console.WriteLine(peri.ToString());
            Employee em = new Employee();
            em.name = "Ki";
            em.birthDate = 2;
            em.salary = 10;
            em.profession = "smith";
            Console.WriteLine(em.ToString());

            Employee Kovacs = new Employee("Géza", 1, 1000, "léhűtő");
            //Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            //Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }

 
}
