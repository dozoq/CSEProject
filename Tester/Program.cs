using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLib.Game;
using MainLib.Cards;

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

            Deck carddeck = new Deck();
            Console.WriteLine($"{carddeck.Peek().Number} OF {carddeck.Peek().Suit}");
            Console.ReadKey();
        }
    }
}
