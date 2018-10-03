using CL.AdmExpertSys.WEB.Application.Contracts.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace CL.AdmExpertSys.WEB.Application.Services
{
    public class TransversalService : ITransversalService
    {
        protected IRolCargoService RolCargoService;
        protected ILicenciaO365Service LicenciaO365Service;
        protected IPerfilUsuarioService PerfilUsuarioService;
        protected IOficinaService OficinaService;

        public TransversalService(IRolCargoService rolCargoService,
            ILicenciaO365Service licenciaO365Service,
            IPerfilUsuarioService perfilUsuarioService,
            IOficinaService oficinaService)
        {
            RolCargoService = rolCargoService;
            LicenciaO365Service = licenciaO365Service;
            PerfilUsuarioService = perfilUsuarioService;
            OficinaService = oficinaService;
        }

        public List<SelectListItem> GetSelectRolCarga()
        {
            var lista = (from a in RolCargoService.FindAll()
                         where a.Vigente                         
                         orderby a.Nombre
                         select a).AsEnumerable()
                    .Select(x => new SelectListItem
                    {
                        Value = x.IdRolCargo.ToString(CultureInfo.InvariantCulture),
                        Text = x.Nombre
                    }).ToList();

            return lista;
        }

        public List<SelectListItem> GetSelectLicencia()
        {
            var lista = (from a in LicenciaO365Service.FindAll()
                         where a.Vigente
                         orderby a.Nombre
                         select a).AsEnumerable()
                    .Select(x => new SelectListItem
                    {
                        Value = x.IdLicencia.ToString(CultureInfo.InvariantCulture),
                        Text = x.Nombre
                    }).ToList();

            return lista;
        }

        public List<SelectListItem> GetSelectPerfil()
        {
            var lista = (from a in PerfilUsuarioService.FindAll()                         
                         orderby a.NombrePerfil
                         select a).AsEnumerable()
                    .Select(x => new SelectListItem
                    {
                        Value = x.IdPerfil.ToString(CultureInfo.InvariantCulture),
                        Text = x.NombrePerfil
                    }).ToList();

            return lista;
        }

        public List<SelectListItem> GetSelectOficina()
        {
            var lista = (from a in OficinaService.FindAll()
                         orderby a.Nombre
                         select a).AsEnumerable()
                    .Select(x => new SelectListItem
                    {
                        Value = x.Nombre,
                        Text = x.Nombre
                    }).ToList();

            return lista;
        }
    }
}
