using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedAssemblyEx;

namespace ClientforSharedAssembly
{
    public class Class1
    {
        public static void Main(string[] arv)
        {
            string uname;
            Console.Write("Enter your name! ");
            uname = Console.ReadLine();
            SharedAssemblyClass SharedAssemblyClass = new SharedAssemblyClass();
            Console.WriteLine(SharedAssemblyClass.WelcomeMsg(uname));
            Console.Read();
        }
    }
}
