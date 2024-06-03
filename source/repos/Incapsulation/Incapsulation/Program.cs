namespace Incapsulation
{
    internal class Program
    {
        internal class Person
        {
            public string Name { get; set; }
            public string SurName { get; set; }

            private int age;
            public int Age { get => age; 
            set => age = value > 0 && value < 35 ? age = value : throw new Exception("Invalid data"); }

            //void setAge(int value)
            //{
            //    if (value > 0 && value < 35)
            //        age = value;
            //    else
            //        throw new Exception("Invalid data");
            //}
        }
        static void Main(string[] args)
        {
            Person person = new();
            person.Age = -25;
            Console.WriteLine(person.Age);
        }
    }
}
