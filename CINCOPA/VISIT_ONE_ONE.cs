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
    
    public partial class VISIT_ONE_ONE
    {
        public System.Guid Id { get; set; }
        public System.Guid CRFId { get; set; }
        public System.DateTime DATE_VISIT { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedByDate { get; set; }
        public string StateCode { get; set; }
    
        public virtual CRF CRF { get; set; }
        public virtual EVALUATION_OF_SYMPTOMS_VISIT_11 EVALUATION_OF_SYMPTOMS_VISIT_11 { get; set; }
    }
}
