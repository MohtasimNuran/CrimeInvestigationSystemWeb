//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrimeInvestigationSystemWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddEvidence
    {
        public int Id { get; set; }
        public Nullable<int> CaseId { get; set; }
        public string EvidenceType { get; set; }
        public string Evidence { get; set; }
        public Nullable<int> SuspectId { get; set; }
        public string Note { get; set; }
        public Nullable<short> Points { get; set; }
        public string Dates { get; set; }
    
        public virtual AddCase AddCase { get; set; }
        public virtual AddSuspect AddSuspect { get; set; }
    }
}
