using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Ostrich : Animal
    {
        public bool Eggs { get; set; }
        
        public Ostrich()
        {
        }

        public Ostrich(string name, string breed, string gender, int age, bool eggs)
            :base (name,breed,gender,age)
        {
            Eggs = eggs;
        }

        public void Peck()
        {
            if (Eggs == true)
            {
                Console.WriteLine("Please do not go near the nest of this ostrich or you might lose your eyes or few fingers or simply die");
            }
        }
    }
}
