using System;
using System.Collections.Generic;
using CardDeck.Models;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle();
            Player timmy = new Player("Timmy");
            for( int i =0; i <5; i++)
            {
                timmy.Draw(newDeck);
            }
            Console.WriteLine("What card would you discard");
            string index = Console.ReadLine();
            int idx = Int32.Parse(index);
            timmy.Discard(idx);
        }
    }
}