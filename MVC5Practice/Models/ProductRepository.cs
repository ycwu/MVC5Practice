using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Practice.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public IQueryable<Product> GetDataOrderByProductId(int size)
        {
            return this.All().OrderByDescending(p => p.ProductId).Take(size);
        }
        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.IsDeleted == false);
        }
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