using System;
using Domain.Models;
using Service.Service;
using Service.Service.Interface;

namespace Interface___Polymorphism_HomeWork.Controller
{
	public class CategoryController
	{
		private readonly ICategoryService _categoryService;

		public CategoryController()
		{
			_categoryService = new CategoryService();
		}


		public void CategoryByName()
		{
            var categories = _categoryService.CategoryByName(Console.ReadLine());

            foreach (var category in categories)
			{
				Console.WriteLine($"{category.Name} - {category.CreatedDate.ToString("MM.dd.yyyy")}");

            }

        }

		public void AllCategory()
		{
			var categories = _categoryService.GetAll();

            foreach (var category in categories)
			{
				Console.WriteLine($"{category.Name} - {category.CreatedDate.ToString("MM.dd.yyyy")}");
            }
		}


		public void GetById()
		{
            var category = _categoryService.GetById(2);
		
            string result =  ($"{category.Name} - {category.CreatedDate.ToString("MM.dd.yyyy")}");

			Console.WriteLine(result);
        }
    }
}

