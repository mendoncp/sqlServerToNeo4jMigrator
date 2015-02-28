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
    
    public partial class State
    {
        public State()
        {
            this.Beverages = new HashSet<Beverage>();
            this.Cities = new HashSet<City>();
            this.UserProfiles = new HashSet<UserProfile>();
        }
    
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
    
        public virtual ICollection<Beverage> Beverages { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}