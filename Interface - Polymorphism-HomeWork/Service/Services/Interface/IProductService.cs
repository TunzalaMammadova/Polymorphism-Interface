using System;
using Domain.Models;

namespace Service.Service.Interface
{
	public interface IProductService
	{
		Product[] GetAll();
		Product[] SearchByName(string searchText);
		Product[] SortProducts(string sortText);
    }
}

