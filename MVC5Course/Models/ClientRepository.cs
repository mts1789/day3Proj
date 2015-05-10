using System;
using System.Linq;
using System.Collections.Generic;
using PagedList;
using PagedList.Mvc;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            //return base.All().Where(x => !x.IsActive);
            return base.All().Where(x => !x.IsActive).OrderBy(p => p.ClientId);
        
        }

        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}