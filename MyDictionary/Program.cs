using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> games = new Dictionary<int, string>();
            games.Add(1,"Forza Horizon 4");
            games.Add(2,"Battlefield 1");
            games.Add(3,"Grand Theft Auto");

            //Loop
            foreach (KeyValuePair<int,string> game  in games)
            {
                Console.WriteLine("İf you choose this {0} result : {1}",game.Key,game.Value);
            }
        }
    }
}
