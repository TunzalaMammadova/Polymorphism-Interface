using System;
using Domain.Models;

namespace Service.Service.Interface
{
	public interface ICategoryService
	{
		Category[] GetAll();
        Category[] CategoryByName(string searchText);
        Category GetById(int id);
    }
}

