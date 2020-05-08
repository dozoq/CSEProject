using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib.Game
{
    public abstract class Character : ILivingInterface, IMovesInterface
    {
        abstract public Int32 Health { get; set; }
        abstract public LivingType Type { get; set; }
        abstract public Int32 AttackPoints { get; set; }
        abstract public Int32 Energy { get; set; }
        abstract public Dictionary<String , Int32> MovesDictionary { get; set; }
        abstract public Int16 Initiative { get; set; }
        abstract public Queue<string> QueuedMoves { get; set; }


        protected Character()
        {
            GameManager.AddToList( this );
            QueuedMoves=new Queue<string>();
        }

        public void queueMove(string move)
        {
            QueuedMoves.Enqueue( move );
        }

        public void DoAllQueuedMoves()
        {
            for (int i = 0 ; i<QueuedMoves.Count ;i++)
            {
                string moveToDo = QueuedMoves.Peek();
                //MoveToDo.DoSometching()
                Console.WriteLine( moveToDo );
           
            }
        }

        public void Attack(Object Target)
        {
            if (Target is ILivingInterface)
            {
                var temp = Target as ILivingInterface;
                temp.TakeDamage(AttackPoints);
            }
        }
        public void Die()
        {
            GameManager.RemFromList(this);
        }
        public void TakeDamage(Int32 Damage)
        {
            Health-=Damage;
        }

        public override String ToString()
        {
            return "Type:" +Type+Environment.NewLine+
                "Attack:"+AttackPoints+Environment.NewLine+
                "Health:"+Health+Environment.NewLine+
                "Energy:"+Energy+Environment.NewLine+
                "Initiative:"+Initiative+Environment.NewLine
                ;
        }
    }
}
