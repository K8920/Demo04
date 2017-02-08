using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public string Bonus { get; set; }

        public Boss()
        {
        }

        public Boss(string name, string profession, int salary, string car, string bonus)
          : base (name,profession,salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Car + " " + Bonus;
        }
    }
}
