using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLib
{
    public static class Utils
    {
        public static void Shuffle<T>(this Stack<T> stack)
        {
            var rnd = new Random();
            var values = stack.ToArray();
            stack.Clear();
            foreach (var value in values.OrderBy( X => rnd.Next() ))
            {
                stack.Push( value );
            }
        }
    }
}
