using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Bike : Vehicle
    {
        public string Gear { get; set; }
        public string Gearmodel { get; set; }

        public Bike (string name, string model, int year, string color, string gear, string gearmodel)
            :base (name,model,year,color)
        {
            Gear = gear;
            Gearmodel = gearmodel;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Gear + " " + Gearmodel;
        }
    }
}
