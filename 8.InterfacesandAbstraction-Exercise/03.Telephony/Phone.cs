using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public abstract class Phone : ICallable
    {
        public string Number { get; protected set; }

        protected Phone(string number)
        {
            Number = number;
        }

        public abstract void Call();
    }
}
