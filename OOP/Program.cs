using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();

            Dog dog = new Dog();
            dog.Greet();

            cat c = new cat();
            c.Greet();

            Animal animal2 = new Dog();
            animal2.Greet();

            Animal animal3 = new cat();
            animal3.Greet();

            Person p = new Person();
            p.print();
            p.DoStuff();
            p.DoStuff2();
            p.DoStuff3();

            AcceptAnimal(animal);
            AcceptAnimal(dog); // the power of polymorphism
            AcceptAnimal(c);



            AcceptDog(dog);
            // AcceptDog(animal); // all dogs are animals, but not 

            Console.Read();
        }

        static void AcceptAnimal(Animal a)
        {
            Console.WriteLine("An animal has been accepted");
        }

        static void AcceptDog(Dog d)
        {
            Console.WriteLine("A dog has been accepted");
        }
    }
    
}
