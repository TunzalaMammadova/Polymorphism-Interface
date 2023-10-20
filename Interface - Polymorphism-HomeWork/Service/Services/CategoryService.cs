using System;
using System.Linq;
using System.Xml.Linq;
using Domain.Models;
using Service.Service.Interface;

namespace Service.Service
{
    public class CategoryService : ICategoryService
    { 

        public Category[] GetAll()
        {
            return Categories();
        }


        private Category[] Categories()
        {
            return new Category[]
            {               
                new Category {Id = 1 , Name = "Telephone" , CreatedDate = new(1897,10,24)},
                new Category {Id = 2 , Name = "Camera" , CreatedDate = new(1896,01,02)},
                new Category {Id = 3 , Name = "Computer" , CreatedDate = new(1965,10,09)},
                new Category {Id = 4 , Name = "Internet" , CreatedDate = new(1768,06,07)},
            };
        }

        public Category[] CategoryByName(string categoryText) => GetAll().Where(m => m.Name.ToLower() == categoryText).ToArray();

        public Category GetById(int id) => GetAll().FirstOrDefault(m => m.Id == id);
    }


}

