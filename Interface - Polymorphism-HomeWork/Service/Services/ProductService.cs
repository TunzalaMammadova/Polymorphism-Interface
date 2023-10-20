using System;
using Domain.Models;
using Service.Service.Interface;

namespace Service.Service
{
    public class ProductService : IProductService
    {
        public Product[] GetAll()
        {
            return Products();
        }


        private Product[] Products()
        {
            return new Product[]
            {
                new Product{Id = 1, Name = "Samsung", Price = 3400 ,CreatedDate = new(1996,04,04), Category = "Notebook"},
                new Product{Id = 2, Name = "Bosch", Price = 2300 ,CreatedDate = new(1988,05,06), Category = "Machine"},
                new Product{Id = 3, Name = "Nokia", Price = 4500 ,CreatedDate = new(1995,10,11), Category = "Telephone"},
                new Product{Id = 4, Name = "Beko", Price = 4800 ,CreatedDate = new(1993,09,09), Category = "Machine"},
                new Product{Id = 5, Name = "Apple", Price = 6000 , CreatedDate = new(1887,07,08), Category = "TV"},
            };


        }

        public Product[] SearchByName(string searchText)
        {
            return GetAll().Where(m => m.Name.ToLower().Contains(searchText.ToLower())).ToArray();

        }


        public Product[] SortProducts(string sortText)
        {
            var products = GetAll();

            if (sortText == "asc")
                return products.OrderBy(m => m.CreatedDate).ToArray();


            return products.OrderByDescending(m => m.CreatedDate).ToArray();

        }
    }

}
