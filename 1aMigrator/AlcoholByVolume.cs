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
    
    public partial class AlcoholByVolume
    {
        public AlcoholByVolume()
        {
            this.Beverages = new HashSet<Beverage>();
        }
    
        public int AlcoholByVolumeId { get; set; }
        public decimal AlcoholByVolume1 { get; set; }
    
        public virtual ICollection<Beverage> Beverages { get; set; }
    }
}
