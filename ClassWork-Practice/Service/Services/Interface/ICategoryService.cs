using System;
using Domain.Models;

namespace Service.Services.Interface
{
	public interface ICategoryService
	{
		Category[] GetAll();
		
	}		
}
