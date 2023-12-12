using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int avgAge;
            public void AnimalNoise()
            {
                Console.WriteLine("*happy noise*");
            }
        }

        class Dog : Animal 
        {
            public string race;
        }  

        class Cat : Dog
        { 
        
        }

        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.name = "Doggie";
            newDog.AnimalNoise();
            Console.WriteLine(newDog.name);

            Cat newCat = new Cat();
            newCat.name = "micka";
            newCat.AnimalNoise();
            Console.WriteLine(newCat.name);
            Console.ReadKey();
        }
    }
}
