
using CL.AdmExpertSys.WEB.Core.Domain.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace CL.AdmExpertSys.WEB.Presentation.ViewModel
{
    public class HomeSysWebVm
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto { get; set; }        
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }
        public IList<SelectListItem> Licencias { get; set; }
        public string Ou { get; set; }
        public IList<SelectListItem> Ous { get; set; }
        public string UpnPrefijo { get; set; }
        public IList<SelectListItem> UpnPrefijoLista { get; set; }
        public string PatchOu { get; set; }
        public bool ExisteUsuario { get; set; }
        public List<MsolAccountSku> ListaAccountSkus { get; set; }
        public string NombreGrupo { get; set; }
        public string Descripcion { get; set; }
        [DisplayName(@"Código Licencia")]        
        public string CodigoLicencia { get; set; }
        public IList<SelectListItem> CodigoLicenciaLista { get; set; }
        public bool CambioPatchOu { get; set; }
        [DisplayName(@"Cuenta Genérica")]
        public bool Info { get; set; }
        [DisplayName(@"Anexo")]
        public decimal? Anexo { get; set; }
        [DisplayName(@"Cumpleaños")]
        public string Cumpleanos { get; set; }
        [DisplayName(@"Centro de Costo")]
        public string CentroCosto { get; set; }
        [DisplayName(@"Oficina")]
        public string Oficina { get; set; }
        public IList<SelectListItem> Oficinas { get; set; }
        [DisplayName(@"Ciudad")]
        public string Ciudad { get; set; }
        public IList<SelectListItem> Ciudades { get; set; }
        [DisplayName(@"País o Región")]
        public string PaisRegion { get; set; }
        public IList<SelectListItem> PaisesRegiones { get; set; }
        [DisplayName(@"Dirección Sucursal")]
        public string DireccionSucursal { get; set; }
        [DisplayName(@"Ingreso")]
        public string Ingreso { get; set; }
        [DisplayName(@"Cargo")]
        public string Cargo { get; set; }
        public IList<SelectListItem> Cargos { get; set; }
        [DisplayName(@"Departamento")]
        public string Departamento { get; set; }
        public IList<SelectListItem> Departamentos { get; set; }
        [DisplayName(@"Organización")]
        public string Organizacion { get; set; }
        public IList<SelectListItem> Organizaciones { get; set; }        
        [DisplayName(@"Jefatura")]
        public string Jefatura { get; set; }
        public string JefaturaCn { get; set; }
        [DisplayName(@"Móvil")]
        public string Movil { get; set; }
        [DisplayName(@"Pin HP")]
        public string PinHp { get; set; }
        [DisplayName(@"Teléfono IP")]
        public string TelefIp { get; set; }
        [DisplayName(@"Notas")]
        public string Notas { get; set; }
        [DisplayName(@"Rut")]
        public string Rut { get; set; }
        [DisplayName(@"Usuario cambia clave")]
        public bool UsrCambiaClaveSesion { get; set; }
        [DisplayName(@"Usuario no puede cambiar clave")]
        public bool UsrNoCambiaClave { get; set; }
        [DisplayName(@"Clave no expira")]
        public bool ClaveNoExpira { get; set; }
        [DisplayName(@"Almacenar clave")]
        public bool AlmacenarClave { get; set; }
    }
}
