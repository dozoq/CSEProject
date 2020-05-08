using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Game
{
    interface IMovesInterface
    {
        Int32 Energy { get; set; }
        //Key: Ability Name, Value: Mana cost
        Dictionary<String , Int32> MovesDictionary { get; set; }
    }
}
