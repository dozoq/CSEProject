using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Game
{
    class Warrior : Character
    {
        public override Int32 Health { get; set; }
        public override LivingType Type { get; set; }
        public override Int32 AttackPoints { get; set; }
        public override Int32 Energy { get; set; }
        public override Dictionary<String , Int32> MovesDictionary { get; set; }
        public override Int16 Initiative { get; set; }
        public override Queue<String> QueuedMoves { get; set; }

        public Warrior() : base()
        {
            AttackPoints=12;
            Type=LivingType.Character;
            Health=80;
            Energy=20;
            Initiative=12;
            MovesDictionary=new Dictionary<string , int>();
            MovesDictionary.Add( "Rage" , 15 );
            MovesDictionary.Add( "Fortitude" , 8 );
        }
    }
}
