using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaceExample
{
    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Walk();
        void MakeSound();
    }

    class Dog : IAnimal
    {
        public void Eat() { Console.WriteLine("Dog is eating meat."); }
        public void Sleep() { Console.WriteLine("Dog is sleeping in its kennel."); }
        public void Walk() { Console.WriteLine("Dog is walking happily."); }
        public void MakeSound() { Console.WriteLine("Dog says: Woof! Woof!"); }
    }

    class Cat : IAnimal
    {
        public void Eat() { Console.WriteLine("Cat is eating fish."); }
        public void Sleep() { Console.WriteLine("Cat is sleeping on the sofa."); }
        public void Walk() { Console.WriteLine("Cat is walking gracefully."); }
        public void MakeSound() { Console.WriteLine("Cat says: Meow!"); }
    }

    class Bird : IAnimal
    {
        public void Eat() { Console.WriteLine("Bird is eating seeds."); }
        public void Sleep() { Console.WriteLine("Bird is sleeping on a tree branch."); }
        public void Walk() { Console.WriteLine("Bird is hopping on the ground."); }
        public void MakeSound() { Console.WriteLine("Bird sings: Tweet Tweet!"); }
    }

    class Fish : IAnimal
    {
        public void Eat() { Console.WriteLine("Fish is eating algae."); }
        public void Sleep() { Console.WriteLine("Fish is resting in water."); }
        public void Walk() { Console.WriteLine("Fish cannot walk; it swims."); }
        public void MakeSound() { Console.WriteLine("Fish makes bubbles... blub blub!"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            IAnimal bird = new Bird();
            IAnimal fish = new Fish();

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
            fish.MakeSound();

            dog.Eat(); dog.Sleep(); dog.Walk();
            cat.Eat(); cat.Sleep(); cat.Walk();
            bird.Eat(); bird.Sleep(); bird.Walk();
            fish.Eat(); fish.Sleep(); fish.Walk();

            Console.ReadKey();
        }
    }
}

