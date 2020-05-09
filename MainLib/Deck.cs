using MainLib.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Cards
{
    public class Deck
    {
        private Stack<Card> Cards { get; set; }

        public Deck() 
        {
            Cards=new Stack<Card>( 52 );
            for (int i = 0 ; i<4 ; i++)
            {
                for (int j = 0 ; j<14 ; j++)
                {
                    Cards.Push( new Card((CardNumber)j,(CardSuit)i) );
                }
            }
        }

        public Card Peek() { return Cards.Peek(); }
        public void ShuffleDeck() { Cards.Shuffle(); }

        public Card Draw() { return Cards.Pop(); }

    }
}
