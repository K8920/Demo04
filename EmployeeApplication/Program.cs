using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Employee employee1 = new Employee();
            employee1.Name = "Teppo";
            employee1.Profession = "Blacksmith trainee";
            employee1.Salary = 6000;
            Console.WriteLine(employee1.ToString());

            Console.WriteLine("-------------------------------------");
            Boss boss = new Boss();
            boss.Name = "Seppo";
            boss.Profession = "Master Blacksmith";
            boss.Salary = 10000;
            boss.Car = "Nissan";
            boss.Bonus = "New phone";
            Console.WriteLine(boss.ToString());
            Console.WriteLine("-------------------------------------");

            employee1.Salary = 3000;
            Console.WriteLine(employee1.ToString());
            Console.WriteLine("-------------------------------------");
        }
    }
}
