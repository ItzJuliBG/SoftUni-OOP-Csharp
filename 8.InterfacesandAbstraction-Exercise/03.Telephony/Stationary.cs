﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class Stationary : ICallable
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}