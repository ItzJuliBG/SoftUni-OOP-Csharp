using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BorderControl
{
    public class Robot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }
        public void PrintFakeIDs(string fakeId)
        {
            var t = this.Id.Substring(this.Id.Length - fakeId.Length, fakeId.Length);
            if (t==fakeId)
                {
                    Console.WriteLine(this.Id);
                }
        }
    }
}
