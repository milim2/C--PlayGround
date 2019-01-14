using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student("Fred", 1, "Programming");
            Student p2 = new Student();
            p2.setName("Greg");
            p2.setId(2);
            p2.setProgram("Art");

            Console.WriteLine(p.getName() + p.getProgram() + p.getId());
            Console.WriteLine(" ");

            Student2 s = new Student2();

            s.Program = "Business";
            s.Id = 3;
            s.Name = "Ram";

            Console.WriteLine(s.Name + " " + s.Id + " " + s.Program);
            Console.ReadKey();
        }
    }
}
