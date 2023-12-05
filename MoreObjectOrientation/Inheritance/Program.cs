using System;

namespace Inheritance
{
    interface IPet
    {
        void Play();
    }

    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hau hau");
        }
        public void Play()
        {
            MakeSound();
            MakeSound();
            MakeSound();
        }
    }
    class Cat : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miau miau");
        }

        public void Play()
        {
            MakeSound();
            MakeSound();
        }
    }

    class Tiger : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Wrrrr");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.MakeSound();

            var c = new Cat();
            c.MakeSound();

            MakeNoises(new Animal[] { d, c, d, new Cat(), new Dog(), new Tiger() });
            PlayWithPets(new IPet[] { d, c, new Cat(), new Dog() });
        }
        public static void MakeNoises(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        public static void PlayWithPets(IPet[] pets)
        {
            foreach(var pet in pets)
            {
                pet.Play();
            }
        }
    }
}
