//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class STRWeight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRWeight()
        {
            this.STRTags = new HashSet<STRTag>();
        }
    
        public long Id { get; set; }
        public string STRNumber { get; set; }
        public System.DateTime STRDate { get; set; }
        public decimal EntryWeight { get; set; }
        public decimal ExitWeight { get; set; }
        public string SiloNumber { get; set; }
        public string SiloIncharge { get; set; }
        public string UnloadingIncharge { get; set; }
        public long ExitOdometer { get; set; }
        public long BagCount { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public decimal DeductionPercent { get; set; }
        public bool IsEditAllowed { get; set; }
        public long CyclicCount { get; set; }
        public string VehicleNumber { get; set; }
        public long DWSCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRTag> STRTags { get; set; }
    }
}
