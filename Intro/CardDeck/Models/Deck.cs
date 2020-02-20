using System;
using System.Collections.Generic;

namespace CardDeck.Models
{
    public class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Reset();
        }
        public List<Card> Reset()
        {
            Cards = new List<Card>();
            string[] suits = {"Spades", "Hearts", "Clubs", "Diamonds"};


            foreach(string s in suits)
            {
                for(int i = 1; i<=13; i++)
                {
                    Cards.Add(new Card(s, i));
                }
            }
            return Cards;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i =0; i < Cards.Count; i++)
            {
                int idx1 = rand.Next(Cards.Count);
                int idx2 = rand.Next(Cards.Count);
                Card temp = Cards[idx1];
                Cards[idx1] = Cards[idx2];
                Cards[idx2] = temp;
            }
        }

        public Card Deal()
        {
            Card deal = Cards[0];
            Cards.RemoveAt(0);
            return deal;
        }
    }
}