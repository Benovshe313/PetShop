namespace CatHouse
{
    using Cat;
    using System;

    internal class Program
    {
        internal class CatHouse
        {
            public Cat[] Cats { get; set; }
            public int CatCount { get { return Cats.Length; } }

            public CatHouse(int size)
            {
                Cats = new Cat[size];
            }
        }
    }

        
            
        
    

