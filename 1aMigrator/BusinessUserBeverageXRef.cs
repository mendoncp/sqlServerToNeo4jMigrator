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
    
    public partial class BusinessUserBeverageXRef
    {
        public BusinessUserBeverageXRef()
        {
            this.BarMenuBeverageInstances = new HashSet<BarMenuBeverageInstance>();
            this.BusinessBeverageFoodPairings = new HashSet<BusinessBeverageFoodPairing>();
        }
    
        public int BusinessUserBeverageXRefId { get; set; }
        public int BusinessUserId { get; set; }
        public int BeverageId { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual ICollection<BarMenuBeverageInstance> BarMenuBeverageInstances { get; set; }
        public virtual ICollection<BusinessBeverageFoodPairing> BusinessBeverageFoodPairings { get; set; }
        public virtual BusinessUser BusinessUser { get; set; }
    }
}
