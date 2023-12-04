using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class Stationary : Phone, ICallable
    {
        public Stationary(string number) : base(number)
        {
        }

        public override void Call()
        {
            Console.WriteLine($"Dialing... {Number}");
        }
    }
}
