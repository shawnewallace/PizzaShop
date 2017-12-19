using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restpost.api.Models;

namespace restpost.api.Controllers
{
	[Route("api/[controller]")]
	public class PizzaController : AppControllerBase
	{
		// GET api/values
		[HttpGet]
		public PizzaMenuApiModel Get()
		{
			var model = new PizzaMenuApiModel();

			return model;
		}

		[HttpGet("{id}", Name = "Get")]
		public IActionResult Get(Guid id) {
			return new ObjectResult(id);
		}

		// POST api/values
		[HttpPost]
		public IActionResult Post([FromBody]PizzaOrderPostModel order)
		{
			if (order == null)
			{
				return BadRequest();
			}

			return CreatedAtRoute("Get", new { id = Guid.NewGuid() }, order);
		}
	}

	public abstract class AppControllerBase : Controller
	{
	}
}
