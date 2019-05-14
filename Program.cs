using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            animal animal = new animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat;
            //cat.Speak();
            animal.Speak();

            Ayam ayam = new Ayam();
            animal = ayam;
            //ayam.Speak();
            animal.Speak();

            Dog dog = new Dog();
            animal = dog;
            //dog.Speak();
            animal.Speak();

            Console.ReadKey();
        }
    }
}
