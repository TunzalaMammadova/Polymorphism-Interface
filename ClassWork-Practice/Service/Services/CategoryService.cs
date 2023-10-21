using System;
using Domain.Data;
using Domain.Models;
using Service.Services.Interface;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService()
        {
            _context = new AppDbContext();
        }


        public Category[] GetAll()
        {
            return _context.Categories();
        }
    }
    

}

