using System.Collections.Generic;

namespace CL.AdmExpertSys.WEB.Core.Domain.Dto
{
    public class HomeSysWebAd
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Licencia { get; set; }        
        public string Ou { get; set; }        
        public string UpnPrefijo { get; set; }        
        public string PatchOu { get; set; }
        public bool ExisteUsuario { get; set; }
        public List<MsolAccountSku> ListaAccountSkus { get; set; }
        public string NombreGrupo { get; set; }
        public string Descripcion { get; set; }        
        public string CodigoLicencia { get; set; }        
        public bool CambioPatchOu { get; set; }        
        public bool Info { get; set; }        
        public decimal? Anexo { get; set; }        
        public string Cumpleanos { get; set; }        
        public string CentroCosto { get; set; }        
        public string Oficina { get; set; }        
        public string Ciudad { get; set; }        
        public string PaisRegion { get; set; }        
        public string DireccionSucursal { get; set; }        
        public string Ingreso { get; set; }        
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
        public bool UsrCambiaClaveSesion { get; set; }        
        public bool UsrNoCambiaClave { get; set; }        
        public bool ClaveNoExpira { get; set; }
        public bool AlmacenarClave { get; set; }
        public string Domicilio { get; set; }
    }
}
