namespace Polimorfizm
{
    internal class Program
    {

        internal class Animal
        {
            public virtual void Sound()
            {
                Console.WriteLine("Animal sound..");
            }
        }

        internal class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Dog is barking..");
            }
        }

        internal class Dog2 : Dog
        {
            
        }
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.Sound();
        }
    }
}
