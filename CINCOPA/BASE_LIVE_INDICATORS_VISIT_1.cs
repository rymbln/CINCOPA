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
    
    public partial class BASE_LIVE_INDICATORS_VISIT_1
    {
        public System.Guid Id { get; set; }
        public int BLOOD_PRESSURE_RIGHT_HAND { get; set; }
        public int BLOOD_PRESSURE_LEFT_HAND { get; set; }
        public int HEART_RATE { get; set; }
        public int RESPIRATORY_RATE { get; set; }
        public decimal TEMPERATURE { get; set; }
        public string HEAVY_TYPE { get; set; }
        public string OXYGEN_THERAPY_NEEDED { get; set; }
        public string DECOMPENSATION_SIGNS { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedByDate { get; set; }
        public string StateCode { get; set; }
    
        public virtual VISIT_ONE VISIT_ONE { get; set; }
    }
}
