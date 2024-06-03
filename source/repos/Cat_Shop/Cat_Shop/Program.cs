
namespace Cat_House1
{
    internal class Program
    {
        class Cat
        {
            public string Nickname { set; get; }
            public int Age { set; get; }
            public string Gender { set; get; }
            public int Energy { set; get; }
            public int Price { set; get; }
            public int MealQuantity { set; get; }

            public Cat(string nickname, int age, string gender, int energy, int price, int mealQuantity)
            {
                Nickname = nickname;
                Age = age;
                Gender = gender;
                Energy = energy;
                Price = price;
                MealQuantity = mealQuantity;
            }

            public void Eat() { }
            public void Sleep() { }
            public void Play() { }
        }


        class CatHouse
        {
            public Cat[] Cats { get; set; }
            public int CatCount {  get; set; }

            public CatHouse(int size)
            {
                Cats = new Cat[size];
                CatCount = 0;
            }

            public void AddCat(Cat cat)
            {
                if (CatCount < Cats.Length)
                {
                    cat = Cats[CatCount];
                    CatCount++;
                }
                else
                {
                    Console.WriteLine("Cat House is full");
                }
            }

            public void RemoveByNickname(string nickname)
            {
                for(int i = 0; i < CatCount; i++)
                {
                    if (Cats[i].Nickname == nickname)
                    {
                        for(int j = i; j < CatCount; j++)
                        {
                            Cats[j] = Cat[j+1];
                        }
                        CatCount--;
                        Console.WriteLine($"{nickname} removed");
                    }
                    else
                    {
                        Console.WriteLine("This nickname not found");
                    }
                }
            }
        }

        class PetShop
        {
            public CatHouse[] CatHouses { get; set; }
            public int CatHouseCount { get; set; }

            public PetShop(int size)
            {
                CatHouses = new CatHouse[size];
                CatHouseCount = 0;
            }

            public void AddCatHouse(CatHouse cathouse)
            {
                if (CatHouseCount < CatHouses.Length)
                {
                    cathouse = CatHouses[CatHouseCount];
                    CatHouseCount++;
                }
                else
                {
                    Console.Writeline("Pet Shop is full");
                }
            }
        }


        static void Main(string[] args)
        {
            
            PetShop petshop = new PetShop(3);

            CatHouse ch1 = new CatHouse(2);
            CatHouse ch2 = new CatHouse(2);
            CatHouse ch3 = new CatHouse(2);

            petshop.AddCatHouse(ch1);
            petshop.AddCatHouse(ch2);
            petshop.AddCatHouse(ch3);

            ch1.AddCat(new Cat("Fluffy", 3, "female", 20, 25, 15));
            ch1.AddCat(new Cat("Oskar", 2  , "female" , 10 , 20 , 10));

            ch2.AddCat(new Cat("Whisker", 3, "male", 20, 25, 15));
            ch2.AddCat(new Cat("Felix", 2, "male", 10, 20, 10));

            ch3.AddCat(new Cat("Luna", 1, "female", 10, 30, 5));
            ch3.AddCat(new Cat("Bella", 1, "female",10, 20, 10));

            Console.WriteLine("Welcome to Pet Shop!");
            for (int i = 0; i < petshop.CatHouseCount; i++)
            {
                Console.WriteLine($"Cat house {i + 1}");
            }
        }
    }
}

