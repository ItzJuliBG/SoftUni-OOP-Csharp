using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if(this.Count == 0) return false; return true;
        }
        public Stack<string> AddRange()
        {
            foreach (var item in range)
            {
                Push(item);
            }

            return this;
        }
    }
}
