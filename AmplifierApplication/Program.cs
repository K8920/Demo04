using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Console.WriteLine("You can change the volume level between 1 and 100");
            Console.WriteLine("Entering value 0 turns off the amplifier");
            Console.WriteLine("Current volume: " + amp.Volume);
            Console.WriteLine("Please enter wanted volume level");
            int power = 1;

            do
            {
                string line = Console.ReadLine();
                amp.Volume = int.Parse(line);
                power = int.Parse(line);
                Console.WriteLine("---------------");
                Console.WriteLine("Current Volume: " + amp.Volume +"db");
                Console.WriteLine("---------------");
            }

            while (power != 0);
        }
    }
}
