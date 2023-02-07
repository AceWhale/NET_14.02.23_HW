using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02._23_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee("Nikita", "10.02.2004", "+380631140207", "CEO", "Main Proger");
            employees[1] = new Employee("Dima", "22.07.2004", "+380955053116", "CO-CEO", "Proger");
            Console.WriteLine(employees[0] + "\n");
            Console.WriteLine(employees[1]);
            Console.WriteLine("\n");

            Plane[] planes = new Plane[2];
            planes[0] = new Plane("GC_5435", 2016, "Грузовой");
            planes[1] = new Plane("UF_3123", 2021, "Пассажирский");
            Console.WriteLine(planes[0] + "\n");
            Console.WriteLine(planes[1]);
            Console.WriteLine("\n");

            Matrix a = new Matrix();
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
