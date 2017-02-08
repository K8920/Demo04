using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gorillas
            Console.WriteLine("--------------------------------------");
            Gorilla gorilla1 = new Gorilla();
            gorilla1.Name = "Name: Mungo";
            gorilla1.Breed = "Breed: Gorilla";
            gorilla1.Gender = "Gender: Male";
            gorilla1.Age = 15;
            gorilla1.Banana = true;
            Console.WriteLine(gorilla1.ToString());
            gorilla1.Dead();
            Console.WriteLine("--------------------------------------");
            Gorilla gorilla2 = new Gorilla();
            gorilla2.Name = "Name: Kungo";
            gorilla2.Breed = "Breed: Gorilla";
            gorilla2.Gender = "Gender: Female";
            gorilla2.Age = 16;
            gorilla2.Banana = true;
            Console.WriteLine(gorilla2.ToString());
            gorilla1.Dead();
            Console.WriteLine("--------------------------------------");
            Gorilla harambe = new Gorilla();
            harambe.Name = "Name: Harambe";
            harambe.Breed = "Breed: Gorilla";
            harambe.Gender = "Gender: Male";
            harambe.Age = 17;
            harambe.Banana = false;
            Console.WriteLine(harambe.ToString());
            harambe.Dead();
            Console.WriteLine("--------------------------------------");

            //Ostriches
            Ostrich ostrich1 = new Ostrich();
            ostrich1.Name = "Name: Killer7";
            ostrich1.Breed = "Breed: Ostrich";
            ostrich1.Gender = "Gender: Female";
            ostrich1.Age = 7;
            ostrich1.Eggs = true;
            Console.WriteLine(ostrich1.ToString());
            ostrich1.Peck();
            Console.WriteLine("--------------------------------------");
            Ostrich ostrich2 = new Ostrich();
            ostrich2.Name = "Name: Overdrive";
            ostrich2.Breed = "Breed: Ostrich";
            ostrich2.Gender = "Gender: Male";
            ostrich2.Age = 15;
            ostrich2.Eggs = false;
            Console.WriteLine(ostrich2.ToString());
            ostrich1.Peck();
            Console.WriteLine("--------------------------------------");
            Ostrich ostrich3 = new Ostrich();
            ostrich3.Name = "Name: BlueCheese";
            ostrich3.Breed = "Breed: Ostrich";
            ostrich3.Gender = "Gender: Female";
            ostrich3.Age = 9;
            ostrich3.Eggs = false;
            Console.WriteLine(ostrich3.ToString());
            ostrich1.Peck();
            //seacucumber
            Console.WriteLine("--------------------------------------");
            SeaCucumber maggara = new SeaCucumber();
            maggara.Name = "Name: Tonno";
            maggara.Breed = "Breed: SeaCucumber";
            maggara.Gender = "Gener: nobody knows";
            maggara.Age = 1000;
            Console.WriteLine(maggara.ToString());
            Console.WriteLine("--------------------------------------");
        }
    }
}
