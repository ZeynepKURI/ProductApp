using System;
using Microsoft.EntityFrameworkCore;

namespace ProductApp.Persistence.Context
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Product> products { get; set; }
		


	}
}

