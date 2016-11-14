using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Practice.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public Product Find(int id)
        {
            Product result = this.All().FirstOrDefault(p => p.ProductId == id);
            return result;
        }
    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}