using System;
using Domain.Models;

namespace Service.Services.Interface
{
	public interface IBlogService
	{
		Blog[] GetAll();
		Blog GetById(int id);
	}
}

