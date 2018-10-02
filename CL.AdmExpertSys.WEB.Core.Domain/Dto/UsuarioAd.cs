﻿
using System;

namespace CL.AdmExpertSys.WEB.Core.Domain.Dto
{
    public class UsuarioAd
    {
        public DateTime? AccountExpirationDate { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string DistinguishedName { get; set; }
        public string EmailAddress { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string SamAccountName { get; set; }
        public Guid? Guid { get; set; }
        public string Surname { get; set; }
        public bool? Enabled { get; set; }
        public string EstadoCuenta { get; set; }
        public string UpnPrefijo { get; set; }        
        public bool Info { get; set; }
        public string InfoString { get; set; }
        public string Licenses { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string TelephoneNumber { get; set; }
        public string Manager { get; set; }
        public string EmployeeID { get; set; }
    }
}
