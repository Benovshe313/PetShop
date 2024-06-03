namespace Inheritance
{
    internal class Program
    {
        internal class Animal
        {
            public string Name { set; get; }
            public DateTime Date { set; get; }

            public Animal(string name, string date)
            {
                Name = name;
                Date = DateTime.Parse(date);
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Name:{Name} Date:{Date.ToShortDateString()}");
            }
        }

        internal class Cat : Animal
        {
            public string Color { set; get; }

            public Cat(string name,string date,string color):base(name,date) {

                Color = color;
            }

            public void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Color:{Color}");
            }
        }
       
        static void Main(string[] args)
        {
            //Cat cat = new Cat("Mestan", "10.10.2010", "White");
            //cat.ShowInfo();

            Animal cat = new Cat("Mestan", "10.10.2010", "White");
            //cat.ShowInfo();

            //var a = cat as Cat;
            //a?.ShowInfo();

            if (cat is Cat CatTypeReferense) {
                CatTypeReferense.ShowInfo();
            }
        }
    }
}
