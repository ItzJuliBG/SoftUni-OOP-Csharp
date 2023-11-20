﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        Random random = new Random();
    
        public string RandomString()
        {
            int index = random.Next(0, this.Count);
            string stringToReturn =this[index];
            this.RemoveAt(index);
            return stringToReturn;
        }

    }
}
