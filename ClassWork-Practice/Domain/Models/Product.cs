using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public Category Category { get; set; }
    }
}

