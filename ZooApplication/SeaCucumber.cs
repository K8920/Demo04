using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class SeaCucumber : Animal
    {
        public SeaCucumber()
        {
        }

        public SeaCucumber(string name, string breed, string gender, int age)
            : base(name, breed, gender, age)
        {
        }
    }
}
