//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CINCOPA
{
    using System;
    using System.Collections.Generic;
    
    public partial class DRUG
    {
        public DRUG()
        {
            this.AB_THERAPY = new HashSet<AB_THERAPY>();
        }
    
        public System.Guid Id { get; set; }
        public string NAME { get; set; }
        public string MNN { get; set; }
        public string GROUP { get; set; }
        public string CODE { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedByDate { get; set; }
        public string StateCode { get; set; }
    
        public virtual ICollection<AB_THERAPY> AB_THERAPY { get; set; }
    }
}
