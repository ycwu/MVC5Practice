using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Practice.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{

	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}