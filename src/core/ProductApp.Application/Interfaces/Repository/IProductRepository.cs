using System;
using Product.Domain.Entities;
namespace ProductApp.Application.Interfaces.Repository
{
	public interface IProductRepository : IGenericRepositoryAsync<Product.Domain.Entities.Product>
	{

    }
}

