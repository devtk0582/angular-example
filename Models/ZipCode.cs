//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZipCode
    {
        public int ZipID { get; set; }
        public string ZipCode1 { get; set; }
        public int CityID { get; set; }
        public bool Active { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    
        public virtual City City { get; set; }
    }
}
