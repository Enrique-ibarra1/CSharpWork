using System;
using System.Collections.Generic;

namespace CardDeck.Models
{
    public class Player
    {
        public string Name;
        public List<Card> Hand {get; set;}
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck playerDeck)
        {
            Card draw = playerDeck.Deal();
            Hand.Add(draw);
            Console.WriteLine($"{Name} picked {draw.showStats()}");
            return draw;
        }
        public Card Discard(int idx)
        {
            if ( Hand[idx] == null)
            {
                return null;
            }
            Card discard = Hand[idx];
            Hand.RemoveAt(idx);
            return discard;
        }

    }
}