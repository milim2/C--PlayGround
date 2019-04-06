using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace LINQBasicsTrafalga
{
    class Program
    {// LINQ --> language integrated Query -> Query ant data source using common
     // coding language

        class Animal
        {
            //let's create some Properties
            public string Name { get; set; }
            public double Weight { get; set; }
            public double Height { get; set; }
            public int AnimalId { get; set; }

            public Animal(string name = " ", double weight = 0, double height = 0)
            {
                Name = name;
                Weight = weight;
                Height = height;
            }
            public override string ToString()
            {
                return string.Format("{0} weighs {1} lbs and is {2} inches tall", Name, Weight, Height);
            }

        }

        static void Main(string[] args)
        {
            QueryCollection();
            QueryArrayList();
            QueryIntArray();
            QueryStringArray();
            Console.ReadKey();
        }

        static void QueryAnimalData()
        {
            Animal[] animals = new[]
            {
                new Animal { Name = "Ming", Weight = 118, Height = 300, AnimalId=1 },
                new Animal { Name = "Jone", Weight = 10, Height = 7, AnimalId=2 },
                new Animal { Name = "Arshi", Weight = 200, Height = 30, AnimalId=3 },
                new Animal { Name = "Toy", Weight = 200, Height = 30, AnimalId=4 },
                new Animal { Name = "Brian", Weight = 23, Height = 15, AnimalId=5 },
             
            };

            Owner[] owners = new[]
            {
                new Owner{Name="TomBrady", OwnerId=1},
                new Owner{Name="Lenron", OwnerId=2},
                new Owner{Name="TomBrady", OwnerId=3}

            };

            var nameHeight = from a in animals select new { a.Name, a.Height, a.Weight };
            Array arrNameHeight = nameHeight.ToArray();
            foreach (var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
        }

        static void QueryCollection()
        {
            var animalLIST = new List<Animal>()
            {
                new Animal {Name="dog1", Weight=118, Height=300},
                new Animal {Name="dog2", Weight=10, Height=7},
                new Animal {Name="dog3", Weight=200, Height=30}
            };
            var bigDogs = from dog in animalLIST
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;
            foreach (var dog in bigDogs)
            {
                Console.WriteLine("{0} weight {1} lbs", dog.Name, dog.Weight);

            }
            Console.WriteLine(" ");
        }
        
       

        static void QueryIntArray()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16 };

            var somenums = from num in numbers where num > 10
                            orderby num
                             select num;

            foreach (var i in somenums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
        }

        static void QueryArrayList()
        {
            ArrayList SomeAnimals = new ArrayList()
            {
                new Animal {Name="Mike", Weight=18, Height=0.5},
                new Animal {Name="James", Weight=90, Height=4},
                new Animal {Name="Kevin", Weight=200, Height=3}

            };

            // must convert to an Enumerable
            var SomeAnimalsEnum = SomeAnimals.OfType<Animal>();
            var sAnimals = from animal in SomeAnimalsEnum
                           where animal.Weight <= 90
                           orderby animal.Name
                           select animal;

            foreach (var animal in sAnimals)
            {
                Console.WriteLine("{0} weight {1} lbs", animal.Name, animal.Weight);

            }
            Console.WriteLine(" ");
        }


        static void QueryStringArray()
        {
            string[] dogs = { "Dog 1", "Dog2", "Dog3", "Dog 4", "Dog4", "Dog5", "Dog6", "Dog 7", "Dog8", "Dog9" };
            // we want to print out the dogs that have spaces in their name

            var dogSpaces = from dog in dogs where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(" ");

        }
    }
}
