using System;
using rpgoopcsharp.src.Entities;

namespace rpgoopcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            /*
            hero.Name = "Arus";
            hero.level = 2;
            hero.HeroType = "Knight";
            */
            

            Console.Write(hero.Attack());
        }
    }
}
