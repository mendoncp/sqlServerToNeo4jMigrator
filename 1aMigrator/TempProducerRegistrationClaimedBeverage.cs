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
    
    public partial class TempProducerRegistrationClaimedBeverage
    {
        public int TempProducerRegistrationClaimedBeverageId { get; set; }
        public int TempProducerRegistrationInfoId { get; set; }
        public int BeverageId { get; set; }
    
        public virtual TempProducerRegistrationInfo TempProducerRegistrationInfo { get; set; }
    }
}
