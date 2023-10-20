using System;
using Domain.Models;
using Service.Services.Interface;

namespace Service.Services
{
    public class BlogService : IBlogService
    {
        public Blog[] GetAll()
        {
            return Blogs();
        }


        public Blog GetById(int id)
        {
            Blog existBlog = Blogs().FirstOrDefault(m => m.Id == id);

            return existBlog;
        }




        private Blog[] Blogs()
        {
            return new Blog[]
            {
                new Blog{Id = 1, Title = "Test1", Description = "Desc1"},
                new Blog{Id = 2, Title = "Test2", Description = "Desc2"},
                new Blog{Id = 3, Title = "Test3", Description = "Desc3"},

            };



        }

    }


}  

