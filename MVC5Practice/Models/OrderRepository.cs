using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Practice.Models
{   
	public  class OrderRepository : EFRepository<Order>, IOrderRepository
	{

	}

	public  interface IOrderRepository : IRepository<Order>
	{

	}
}