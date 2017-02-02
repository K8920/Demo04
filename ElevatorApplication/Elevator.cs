using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        private int maxFloor = 5;
        private int minFloor = 1;
        private int floor = 1;
        
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;
                else if (value > maxFloor)
                {
                    Console.WriteLine("Such floor doesn't exsist, please pick another floor");
                    floor = maxFloor;
                    
                }

                else if (value < minFloor)
                {
                    Console.WriteLine("Such floor doesn't exsist, please pick another floor");
                    floor = minFloor;
                }

            }
        }

    }
}
