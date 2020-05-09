using MainLib.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Blackjack
{
    public class Blackjack
    {
        private List<Card> CroupierCards = new List<Card>();
        private List<Card> PlayerCards = new List<Card>();
        private Deck carddeck;

        public Blackjack() 
        {
            carddeck = new Deck();
            carddeck.ShuffleDeck();
            CroupierCards.Add(carddeck.Draw());
            CroupierCards.Add(carddeck.Draw());
            PlayerCards.Add(carddeck.Draw());
            PlayerCards.Add(carddeck.Draw());

            this.play();
        }

        public void WriteOutCards() 
        {
            Console.WriteLine("Karty Krupiera");
            for (int i = 0 ; i<CroupierCards.Count ; i++)
            {
                if (i==1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine( $"{i+1}:{CroupierCards[ i ].Number}" );
                }
            }
            Console.WriteLine( "Karty Gracza" );
            int j = 0;
            foreach (Card card in PlayerCards)
            {
                j++;
                Console.WriteLine( $"{j}:{card.Number}" );
            }
        }
        public void Decide() 
        {
            if (this.CountPoints( CroupierCards )<=15)
            {
                var card = carddeck.Draw();
                CroupierCards.Add( card );
                Console.WriteLine( $"Krupier dobiera {card.Number}" );
            }
            else
            {
                Console.WriteLine( "Krupier nie dobiera" );
            }
        }

        public int CountPoints(List<Card> list) 
        {
            int sum = 0;
            foreach (Card card in list)
            {
                switch (card.Number)
                {
                    case CardNumber.ACE:
                        sum+=11;
                        break;
                    case CardNumber.KING:
                        sum+=10;
                        break;
                    case CardNumber.QUEEN:
                        sum+=10;
                        break;
                    case CardNumber.JACK:
                        sum+=10;
                        break;
                    default:
                        sum+=(int) card.Number;
                        break;
                }
            }
            return sum;
        }

        public void play() 
        {
            Console.WriteLine( "Witamy w Blackjack!" );
            Console.WriteLine( "Kliknij żeby zacząć" );
            Console.ReadKey();
            do
            {
                Console.Clear();
                this.WriteOutCards();
                this.Decide();
                Console.WriteLine( "Masz dwie opcje: \n 1. dobór kart \n 2.pass" );
                var key = Console.ReadKey();
                if (key.KeyChar=='1')
                {
                    PlayerCards.Add( carddeck.Draw() );
                }


            }
            while (this.CountPoints( PlayerCards )<21||this.CountPoints( CroupierCards )<21);
        }
    }
}
