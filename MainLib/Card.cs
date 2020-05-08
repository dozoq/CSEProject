using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Cards
{
    public class Card
    {
        public CardNumber Number { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardNumber number , CardSuit suit) 
        {
            this.Number=number;
            this.Suit=suit;
        }
        public Card() 
        {
            this.Number=CardNumber.ACE;
            this.Suit=CardSuit.DIAMOND;
        }

        public static Card GenerateRandomCard() 
        {
            throw new NotImplementedException();
        }

    }

    public enum CardNumber { ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE}
    public enum CardSuit { DIAMOND, HEART, CLUB, SPADE }
}
