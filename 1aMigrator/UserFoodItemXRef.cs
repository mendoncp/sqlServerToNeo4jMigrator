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
    
    public partial class UserFoodItemXRef
    {
        public int UserFoodItemXRefId { get; set; }
        public int UserId { get; set; }
        public int BusinessFoodItemId { get; set; }
        public bool DoesLike { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public string ReviewTitle { get; set; }
        public string Review { get; set; }
        public bool Want { get; set; }
        public bool Favourite { get; set; }
        public Nullable<System.DateTime> DateLiked { get; set; }
        public Nullable<System.DateTime> DateRated { get; set; }
        public Nullable<System.DateTime> DateReviewed { get; set; }
        public Nullable<System.DateTime> DateWanted { get; set; }
        public Nullable<System.DateTime> DateFavourited { get; set; }
        public Nullable<System.DateTime> DateAddedToDailySpecials { get; set; }
    
        public virtual BusinessFoodItem BusinessFoodItem { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}