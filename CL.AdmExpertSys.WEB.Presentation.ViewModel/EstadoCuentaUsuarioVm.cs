using CL.AdmExpertSys.WEB.Core.Domain.Model;
using System;

namespace CL.AdmExpertSys.WEB.Presentation.ViewModel
{
    public class EstadoCuentaUsuarioVm
    {
        public decimal IdEstadoCuentaUsuario { get; set; }
        public string CuentaAd { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Descripcion { get; set; }
        public string Dominio { get; set; }
        public bool CreadoAd { get; set; }
        public bool Sincronizado { get; set; }
        public decimal LicenciaId { get; set; }
        public bool Habilitado { get; set; }
        public bool Eliminado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CodigoLicencia { get; set; }        
        public bool Vigente { get; set; }
        public bool LicenciaAsignada { get; set; }
        public string Clave { get; set; }
        public decimal? Anexo { get; set; }
        public string Cumpleanos { get; set; }
        public string CentroCosto { get; set; }
        public string Oficina { get; set; }
        public string Ciudad { get; set; }
        public string PaisRegion { get; set; }
        public string DireccionSucursal { get; set; }
        public DateTime? Ingreso { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Organizacion { get; set; }
        public string Jefatura { get; set; }
        public string JefaturaCn { get; set; }
        public string Movil { get; set; }
        public string PinHp { get; set; }
        public string TelefIp { get; set; }
        public string Notas { get; set; }
        public string Rut { get; set; }
        public bool? UsrCambiaClaveSesion { get; set; }
        public bool? UsrNoCambiaClave { get; set; }
        public bool? ClaveNoExpira { get; set; }
        public bool? AlmacenarClave { get; set; }
        public LICENCIAS_O365 LICENCIAS_O365 { get; set; }
    }
}
