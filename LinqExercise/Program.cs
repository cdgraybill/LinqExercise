using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUERY SYNTAX
            string[] cars = new string[] { "Honda", "Toyota", "Ford", "Dodge" };

            var findA = from car in cars
                        where car.Contains("a")
                        orderby car ascending
                        select car;

            foreach (var x in findA)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Press any key.");
            Console.ReadLine();

            // METHOD SYNTAX
            List<string> videoGames = new List<string>() { "Halo: Reach", "BioShock", "Destiny 2", "Path of Exile", "Rainbow Six: Siege" };

            var result = videoGames.OrderBy(videogame => videogame.Length);

            foreach (var game in result)
            {
                Console.WriteLine(game);
            }

            Console.ReadLine();
        }
    }
}
