using System;
using rpgoopcsharp.src.Entities;

namespace rpgoopcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            /*
            hero.Name = "Arus";
            hero.level = 2;
            hero.HeroType = "Knight";
            */

            Console.Write(hero);
        }
    }
}
