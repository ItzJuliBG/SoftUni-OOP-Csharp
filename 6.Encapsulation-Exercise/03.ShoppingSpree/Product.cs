using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
	public class Product
	{
		private string name;

		private double cost;

		public Product(string name, double cost)
		{
			Name = name;
			Cost = cost;
		}

		public double Cost
		{
			get { return cost; }
			set { cost = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

	
	}
}
