//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1aMigrator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
            this.States = new HashSet<State>();
            this.UserProfiles = new HashSet<UserProfile>();
            this.ViticultureRegions = new HashSet<ViticultureRegion>();
        }
    
        public int CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int LegalDrinkingAge { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
        public virtual ICollection<ViticultureRegion> ViticultureRegions { get; set; }
    }
}
