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
    
    public partial class BusinessHour
    {
        public int BusinessHourId { get; set; }
        public int UserId { get; set; }
        public string DayOfWeek { get; set; }
        public System.TimeSpan OpenTime { get; set; }
        public System.TimeSpan CloseTime { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}