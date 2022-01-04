using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Poter", "Superman", "Luke Skywalker", "Lara Croft" };
            string[] villains = { "Voldemort", "Joker", "Vemnom ", "Darth Vader", "Cruela" };


            

            string randomHero = GetRandomCharacter(heroes);
            Console.WriteLine($"Your random hero is:{randomHero}");
            string randomVillain = GetRandomCharacter(villains);
            Console.WriteLine($"Your random hero is:{randomVillain}");

        }

        public static string GetRandomCharacter(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomCharacter = someArray[randomIndex];
            return randomCharacter;
        }
    }
}
