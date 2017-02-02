using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int leave = 1;

            Elevator elevator = new Elevator();
            Console.WriteLine("Please choose floor between 1 and 5");
            Console.WriteLine("Pess 0 to leave elevator");
            Console.WriteLine("---------------");
            Console.WriteLine("Current floor:" +" "+elevator.Floor);
            Console.WriteLine("---------------");

            do
            {
                string line = Console.ReadLine();
                elevator.Floor = int.Parse(line);
                leave = int.Parse(line);
                Console.WriteLine("---------------");
                Console.WriteLine("Current floor:" + " " + elevator.Floor);
                Console.WriteLine("---------------");
            } while (leave != 0);
        }
    }
}
