using System;

namespace CardDeck.Models
{
    public class Card
    {
        
        public string StringVal;//ace, 1,2,3,4,5,6,7,8,9,10,jack queen and king
        public int Value;//1-13
        public string Suit;//hearts clubs spades diamonds
        public Card(string suit, int cardIntValue)
        {
            Value = cardIntValue;
            Suit = suit;
            switch(cardIntValue)
            {
                case 1:
                    StringVal = "Ace";
                    break;
                case 11:
                    StringVal = "Jack";
                    break;
                case 12:
                    StringVal = "Queen";
                    break;
                case 13:
                    StringVal = "King";
                    break;
                default:
                    StringVal = cardIntValue.ToString();
                    break;
            }
        }
        public string showStats()
        {
            return $"{Suit} of {StringVal}, value - {Value}";
        }
    }
}