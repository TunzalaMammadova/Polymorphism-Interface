using System;
using Domain.Models;

namespace Service.Services.Interface
{
	public interface IProductService
	{
		int GetCount();
		Product[] Search(string searchText);
		Product[] GetAll();
		decimal GetAvaragePrice();
        Product[] OrderByDate();
		Product[] GetAllByCategoryName(string categoryName);
		Product[] GetAllByCategoryId(int id);
    }
}

