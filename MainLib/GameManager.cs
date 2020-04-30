using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
    public static class GameManager
    {
        private static List<ILivingInterface> LivingList { get; set; }

        public static void InitializeGame(out Character player)
        {
            LivingList=new List<ILivingInterface>();
            player = new Warrior();
            try
            {
                System.IO.Directory.CreateDirectory( @"C:\Users\Public\GameTest" );
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine( e );
            }
        }

        public static void AddToList(ILivingInterface _object)
        {
            LivingList.Add( _object );
        }

        public static void RemFromList(ILivingInterface _object)
        {
            LivingList.Remove( _object );
        }

        public static void GameOver()
        {
            //Game Ended
        }

        public static void LevelUpCharacter(ref Character _char)
        {
            _char.AttackPoints+=5;
            _char.Health+=12;
        }

        public static void Save()
        {
            try
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter( @"C:\Users\Public\GameTest\Save.txt" ))
                {
                    foreach (ILivingInterface Live in LivingList)
                    {
                        file.WriteLine(Live.ToString());
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine( e );
            }
            finally
            {
                Console.WriteLine("Game not saved properly");
            }
        }
    }
}
