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
    
    public partial class BusinessBeverageCategory
    {
        public BusinessBeverageCategory()
        {
            this.BarMenuBeverageInstances = new HashSet<BarMenuBeverageInstance>();
        }
    
        public int BusinessBeverageCategoryId { get; set; }
        public int BusinessBeverageMenuId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<BarMenuBeverageInstance> BarMenuBeverageInstances { get; set; }
        public virtual BusinessBeverageMenu BusinessBeverageMenu { get; set; }
    }
}
