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
    
    public partial class BusinessUserRestaurantCategoryXRef
    {
        public int BusinessUserRestaurantCategoryXRefId { get; set; }
        public int BusinessUserId { get; set; }
        public int RestaurantCategoryId { get; set; }
    
        public virtual BusinessUser BusinessUser { get; set; }
        public virtual RestaurantCategory RestaurantCategory { get; set; }
    }
}
