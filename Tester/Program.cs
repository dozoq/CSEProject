using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLib.Game;
using MainLib.Cards;
using MainLib.Blackjack;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player;
            GameManager.InitializeGame(out player);
            GameManager.LevelUpCharacter(ref player );
            GameManager.Save();

            List<Card> PlayerHand = new List<Card>( 5 );
            Deck carddeck = new Deck();
            carddeck.ShuffleDeck();
            for (int i = 0 ; i<5 ; i++)
            {
                PlayerHand.Add(carddeck.Draw());
            }
            foreach (Card card in PlayerHand)
            {
                Console.WriteLine( $"{card.Number} OF {card.Suit}" );
            }
            Console.ReadKey();

            Blackjack blackjack = new Blackjack();
        }
    }
}
