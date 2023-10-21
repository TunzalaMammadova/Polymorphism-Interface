using System;
using Service;
using Service.Services;
using Service.Services.Interface;

namespace ClassWork_Practice.Controllers
{
	public class CategoryController
	{
        private readonly ICategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }


        public void GetAll()
        {
            var categories = _categoryService.GetAll();

            foreach (var item in categories)
            {
                string data = $"Name: {item.Name}";
                Console.WriteLine(data);
            }
        }
    }
}

