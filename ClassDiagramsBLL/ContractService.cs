using ContractServiceBase;
using CRUDServiceImplementation;
using GPSTracker.DAL.Entities;
using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractServiceImplementation
{
    public class ContractService : CRUDService<Contract>, IContractService
    {
        public ContractService(IRepository repo) : base(repo)
        { 
        }
         public override Task Create(Contract entity)
         {
            entity.DateCreated = DateTime.Now;
            entity.DateLastChanged = DateTime.Now;

            return base.Create(entity);
         }

        public override Task Update(Contract entity)
        {
            entity.DateLastChanged = DateTime.Now;

            return base.Update(entity);
        }
    }
}
