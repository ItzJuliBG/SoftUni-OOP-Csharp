using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class Smartphone : Phone, ICallable, IBrowsable
    {
        public Smartphone(string number, string url) : base(number)
        {
            URL = url;
        }
        public string URL { get; private set; }

        public void Browse()
        {
            if (URL.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
            Console.WriteLine($"Browsing: {URL}!");

            }
        }
        public override void Call()
        {
            Console.WriteLine($"Calling... {Number}");
        }

   
    }
}
