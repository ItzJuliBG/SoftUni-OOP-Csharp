using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    public class Person
    {
		private string name;
		private double money;
		private List<string> bagOfProducts;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
			BagOfProducts = new List<string>();
        }

        public List<string> BagOfProducts
		{
			get { return bagOfProducts; }
			set { bagOfProducts = value; }
		}

		public double Money
		{
			get { return money; }
			set {
				if(value< 0)
				{
					throw new Exception("Money cannot be negative");
				}
				money = value;
			} }

		public string Name
		{
			get { return name; }
			set {
				if (string.IsNullOrWhiteSpace(value)) //or nullorempty
				{
					throw new Exception("Name cannot be empty");
				}
				name = value; }
        }
        public string Buy(Product product)
        {
			if(this.Money >= product.Cost)
			{
				Money -= product.Cost;
				BagOfProducts.Add(product.Name);
				return $"{Name} bought {product.Name}";
			}
            return $"{Name} can't afford {product.Name}";
        }

    }
}
