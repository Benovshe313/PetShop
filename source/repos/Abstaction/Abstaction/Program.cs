using System.Xml.Serialization;

namespace Abstaction
{
    internal class Program
    {
        internal abstract class Person {
            public abstract void SoundOf();
           


        }

        internal class P2 : Person
        {
            public override void SoundOf()
            {
                Console.WriteLine("P2");
            }
        }

        internal abstract class P3 : P2
        {
            

        }

        
        static void Main(string[] args)
        {
            //Person person = new P2();
            Person obj = new P2();
            obj.SoundOf();

        }
    }
}
