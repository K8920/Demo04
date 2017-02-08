using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Bike bike1 = new Bike("Name: Mummopyörä", "Model: 6000 Year:",1640,"Red","Gear: No"," ");
            Console.WriteLine(bike1.ToString());
            Console.WriteLine("-----------------------------------------------------------------------");

            Bike bike2 = new Bike("Name: Superbike", "Model: 9999 Year:", 2017,"Color: green", "Gear: Yes", "Gearmodel: X10");
            Console.WriteLine(bike2.ToString());
            Console.WriteLine("-----------------------------------------------------------------------");

            Boat boat1 = new Boat("Name: Ezmeralda", "Model: 500 Year:", 1850, "Color: White", "Type: Motorboat Seats:",10);
            Console.WriteLine(boat1.ToString());

            Console.WriteLine("-----------------------------------------------------------------------");
            Boat boat2 = new Boat("Name: Bonjour", "Model: 200 Year:", 2005, "Color: Blue", "Type: Kayak Seats:", 2);
            Console.WriteLine(boat2.ToString());
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
