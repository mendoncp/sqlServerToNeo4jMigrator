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
    
    public partial class FoodMenu
    {
        public FoodMenu()
        {
            this.BusinessFoodItemCategories = new HashSet<BusinessFoodItemCategory>();
        }
    
        public int FoodMenuId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<BusinessFoodItemCategory> BusinessFoodItemCategories { get; set; }
        public virtual BusinessUser BusinessUser { get; set; }
    }
}
