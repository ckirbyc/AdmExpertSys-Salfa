using CL.AdmExpertSys.WEB.Core.Domain.Contracts.Repository;
using CL.AdmExpertSys.WEB.Core.Domain.Model;
using Pragma.Commons.Data;
using System.Data.Entity;

namespace CL.AdmExpertSys.WEB.Infrastructure.Data.Repository.Implementation
{
    public class OficinaRepository : Repository<OFICINA>, IOficinaRepository
    {
        public OficinaRepository(DbContext context)
            : base(context)
        {
        }
    }
}
