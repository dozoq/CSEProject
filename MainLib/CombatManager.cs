using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
    public static class CombatManager
    {
        private static SortedList<Int16 , object> CombatQueue { get; set; }

        public static void CreateCombat(object[] characters)
        {
            CombatQueue=new SortedList<short , object>();
            foreach (object temp in characters)
            {
                if (temp is ILivingInterface)
                {
                    CombatQueue.Add( ( temp as ILivingInterface ).Initiative , temp );
                }
            }
        }

        private static void EndCombat() { CombatQueue.Clear(); }

        public static void DoMoves()
        {
            foreach (object temp in CombatQueue.Values)
            {
                //Do move
            }
        }
    }
}
