using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Game
{
    public interface ILivingInterface
    {
        Int32 Health { get; set; }
        Int32 AttackPoints { get; set; }
        Int16 Initiative { get; set; }
        LivingType Type { get; set; }
        Queue<String> QueuedMoves { get; set; }
        

        void Die();
        void Attack(Object Target);
        void TakeDamage(Int32 Damage);
    }


    public enum LivingType { Character, NPC, Enemy}
}
