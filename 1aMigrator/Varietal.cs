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
    
    public partial class Varietal
    {
        public Varietal()
        {
            this.BeverageVarietalXRefs = new HashSet<BeverageVarietalXRef>();
        }
    
        public int VarietalId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<BeverageVarietalXRef> BeverageVarietalXRefs { get; set; }
    }
}
