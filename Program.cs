using System;

namespace Polymor_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(15);
            animal.Goes();

            Console.WriteLine("");

            Dog dog = new Dog(30," Class Dog");
            dog.Goes();
        }
    }
}
