using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

