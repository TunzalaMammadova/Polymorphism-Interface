using System;
using System.Xml.Linq;
using Domain.Models;

namespace Domain.Data
{
	public class AppDbContext
	{
		public Category[] Categories()
		{
			return new Category[]
            {
				new Category{Id = 1 , Name = "Phone"},
				new Category{Id = 2 , Name = "TV"},
				new Category{Id = 3 , Name = "Console"},
				new Category{Id = 4 , Name = "Computer"}
			};
		}


		public Product[] Products()
		{
			return new Product[]
			{
				new Product{Id = 1 , Name = "Iphone 15", Price = 3500 ,CreateDate = new DateTime(2023 ,05,15) ,Category = Categories()[0] },
                new Product{Id = 2 , Name = "Iphone 14", Price = 3000 ,CreateDate = new DateTime(2023 ,09,11) ,Category = Categories()[0] },
                new Product{Id = 3 , Name = " Samsung 7V", Price = 2000 ,CreateDate = new DateTime(2021 ,07,17) ,Category = Categories()[1] },
                new Product{Id = 4 , Name = "Sony P5", Price = 500 ,CreateDate = new DateTime(2022 ,05,19) ,Category = Categories()[3] },
            };
		}
	}
}

