using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "032-0303030";
            teacher.Room = "D345";
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(teacher.ToString());
            teacher.TeacherMethod();

            Student student = new Student("Korianteri", "Ruusunnuppu", "K999");
            student.Age = 20;
            student.PhoneNumber = "040-404040";
            student.Address = "Yliopstinkatu 1";
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(student.ToString());
            student.StudentMethod();
            Console.WriteLine("---------------------------------------------");
        }
    }
}
