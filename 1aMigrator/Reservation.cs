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
    
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public string UserEmail { get; set; }
        public int RestaurantId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public int ReservationHour { get; set; }
        public int ReservationMinute { get; set; }
        public bool IsPM { get; set; }
        public int NumberOfPatrons { get; set; }
        public Nullable<bool> IsAcceptedByRestaurant { get; set; }
    }
}
