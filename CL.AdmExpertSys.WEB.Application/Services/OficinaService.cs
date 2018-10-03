using CL.AdmExpertSys.WEB.Application.Contracts.Services;
using CL.AdmExpertSys.WEB.Core.Domain.Contracts.Repository;
using CL.AdmExpertSys.WEB.Core.Domain.Model;

namespace CL.AdmExpertSys.WEB.Application.Services
{
    public class OficinaService : BaseService<OFICINA>, IOficinaService
    {
        protected IOficinaRepository Repo;

        public OficinaService(IOficinaRepository repo)
            : base(repo)
        {
            Repo = repo;
        }
    }
}
