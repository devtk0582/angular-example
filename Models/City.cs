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
    
    public partial class City
    {
        public City()
        {
            this.ZipCodes = new HashSet<ZipCode>();
        }
    
        public int CityID { get; set; }
        public string AccentCity { get; set; }
        public string CityName { get; set; }
        public Nullable<int> StateID { get; set; }
        public bool Active { get; set; }
        public bool Primary { get; set; }
        public Nullable<int> CountryID { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<ZipCode> ZipCodes { get; set; }
    }
}