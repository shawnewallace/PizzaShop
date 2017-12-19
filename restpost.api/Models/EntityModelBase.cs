using System;

namespace restpost.api.Models
{
	public class EntityModelBase
	{
		public Guid Id { get; set; } = Guid.NewGuid();
	}
}