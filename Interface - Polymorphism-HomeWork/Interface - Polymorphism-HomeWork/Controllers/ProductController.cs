using System;
using Domain.Models;
using Service.Service;
using Service.Service.Interface;

namespace Interface___Polymorphism_HomeWork.Controller
{
	public class ProductController
	{
		private readonly IProductService _productService;

		public ProductController()
		{
			_productService = new ProductService();
		}


		public void GetAllProductsCount()
		{
			int Count = 0;

			var products = _productService.GetAll();

			foreach (var product in products)
			{
				Count++;
			}

			Console.WriteLine(Count);
		}


		public void Search()
		{
			var products = _productService.SearchByName(Console.ReadLine());

			foreach (var product in products)
			{
				Console.WriteLine($"{product.Name} - {product.Price} - {product.CreatedDate.ToString("MM.dd.yyyy")} - {product.Category}");

            }

		}

		public void GetAllProducts()
		{
			var products = _productService.GetAll();

			foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} - {product.CreatedDate.ToString("MM.dd.yyyy")} - {product.Category}");

            }

        }

		public void GetProductsByPriceAverage()
		{
            var products = _productService.GetAll();

			var AveragePrice = products.Sum(m => m.Price / products.Length);

			Console.WriteLine(AveragePrice);

		}

		public void SortProducts()
		{
			var products = _productService.SortProducts("SortText");

            Console.WriteLine("Please choose SortText");

			string SortText = Console.ReadLine();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} - {product.CreatedDate.ToString("MM.dd.yyyy")} - {product.Category}");
            }
		}

	}
}	
