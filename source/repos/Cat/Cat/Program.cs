namespace Cat
{
    public class Cat
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int MealQuantity { get; set; }

        public Cat(string nickname, int age, string gender, int energy, int price, int mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }

        public void Eat()
        {
          
        }

        public void Sleep()
        {
            
        }

        public void Play()
        {
           
        }
    }
}
