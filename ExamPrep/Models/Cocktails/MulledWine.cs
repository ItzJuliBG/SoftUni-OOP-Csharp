using ChristmasPastryShop.Models.Cocktails.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public class MulledWine : Cocktail
    {
        private const double mulledPrice = 13.5;
        public MulledWine(string name, string size) : base(name, size, mulledPrice)
        {

        }
    }
}
