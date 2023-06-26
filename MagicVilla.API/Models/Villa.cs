using System;
namespace MagicVilla.API.Models
{
	public class Villa
	{
		public Villa(string name)
		{
			Id = Guid.NewGuid();
			Name = name;
			CreatedDate = DateTime.Now;
		}

		protected Villa()
		{

		}

		public Guid Id { get; set; }
		public string? Name { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

