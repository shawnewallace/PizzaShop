using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restpost.api.Models
{
	public class PizzaOrderPostModel {
		public Size Size { get; set; }
		public Crust Crust { get; set; }

		public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
	}


	public class PizzaMenuApiModel : ModelBase
	{
		public List<Size> Sizes { get; set; } = new List<Size>();
		public List<Crust> Crusts { get; set; } = new List<Crust>();
		public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();


		public PizzaMenuApiModel() {
			Sizes.Add(new Size { Name = "Small", Price = 8d });
			Sizes.Add(new Size { Name = "Medium", Price = 10d });
			Sizes.Add(new Size { Name = "Large", Price = 12d });
			Sizes.Add(new Size { Name = "Extra-Large", Price = 15d });

			Crusts.Add(new Crust { Name = "Cracker", Price = 0d });
			Crusts.Add(new Crust { Name = "New York", Price = .50d });
			Crusts.Add(new Crust { Name = "Chicago", Price = .75d });

			Ingredients.Add(new Ingredient { Name = "Tomato Sauce", Price = 0d });
			Ingredients.Add(new Ingredient { Name = "Cheese", Price = 0d });
			Ingredients.Add(new Ingredient { Name = "Sausage", Price = .5d });
			Ingredients.Add(new Ingredient { Name = "Pepperoni", Price = .5d });
			Ingredients.Add(new Ingredient { Name = "Anchovies", Price = 1.25d });
			Ingredients.Add(new Ingredient { Name = "Pineapple", Price = .75d });
			Ingredients.Add(new Ingredient { Name = "Peppers", Price = .25d });
		}

	}

	public class Size : EntityModelBase, IMenuItem
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}

	public interface IMenuItem
	{
		string Name { get; set; }
		double Price { get; set; }
	}

	public class Crust : IMenuItem
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
	public class Ingredient : IMenuItem
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}

	public abstract class ModelBase
	{
	}
}
