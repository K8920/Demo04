using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Animal
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal()
        {
        }

        public Animal(string name, string breed, string gender, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return Name + " " + Breed + " " + Gender + " " + Age;
        }
    }
}   
