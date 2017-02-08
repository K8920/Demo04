using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio radio = new Radio();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("You can change the volume between 0 and 9");
            Console.WriteLine("You can change the channel between 20000.0 and 26000.0");
            Console.WriteLine("Current Volume: " + radio.Volume);
            Console.WriteLine("Current Volume: " + radio.Channel);
            Console.WriteLine("Power is off");
            int Power = 1;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Turn power on by entering number 1");
            Console.WriteLine("You can Change the volume by entering number 2");
            Console.WriteLine("You can turn off the radio by entering volume value to 0 several times");
            Console.WriteLine("------------------------------------------------------------------");
            
            do
            {
                Console.WriteLine("Please choose volume level between 0 and 9");
                string line1 = Console.ReadLine();
                radio.Volume = int.Parse(line1);
                Power = int.Parse(line1);
                Console.WriteLine("Current Volume: " + radio.Volume);
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Please select a channel");
                string line2 = Console.ReadLine();
                radio.Channel = double.Parse(line2);
                Console.WriteLine("Current Channel: " + radio.Channel);
                Console.WriteLine("------------------------------------------------------------------");

            } while (Power != 0);
        }
    }
}
