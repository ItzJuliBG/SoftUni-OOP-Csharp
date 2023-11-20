using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BorderControl
{
    public class Citizen
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public void PrintFakeIDs(string fakeId)
        {
            var lastTheeChars = this.Id.Substring(this.Id.Length - fakeId.Length, fakeId.Length);
                if (lastTheeChars == fakeId) 
                {
                    Console.WriteLine(this.Id);
                } 
            
        }
    }
}
