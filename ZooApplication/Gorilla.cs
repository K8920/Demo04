using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Gorilla : Animal
    {
        public bool Banana = true;

        public Gorilla()
        {
        }

        public Gorilla(string name, string breed, string gender, int age,bool banana)
            :base (name,breed,gender,age)
        {
            Banana = banana;
        }

        public void Dead()
        {
            if (Banana == false)
            {
                Console.WriteLine("R.I.P Harambe 28.5.2016");
            }
            else if (Banana == true)
            {
                Console.WriteLine("This gorilla has a banana");
            }
        }
    }
}
