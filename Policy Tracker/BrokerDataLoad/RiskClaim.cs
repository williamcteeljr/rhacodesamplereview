//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaimsLoad
{
    using System;
    using System.Collections.Generic;
    
    public partial class RiskClaim
    {
        public int ID { get; set; }
        public System.DateTime PolicyEffDate { get; set; }
        public string Prefix { get; set; }
        public string PolicyNumber { get; set; }
        public string Suffix { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
        public int Earned { get; set; }
        public int Written { get; set; }
        public int ClaimCount { get; set; }
        public int Dividend { get; set; }
        public int PaidExpense { get; set; }
        public int PaidLoss { get; set; }
        public int IncurredLoss { get; set; }
    }
}
