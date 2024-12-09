using System;
using Product.Domain.Entities;
namespace ProductApp.Application.Interfaces.Repository
{
	public interface IProductRepository
	{

        Task<List<Product>> GetAllProduct();
	}
}

