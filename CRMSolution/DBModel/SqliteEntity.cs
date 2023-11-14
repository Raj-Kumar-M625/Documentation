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
    
    public partial class SqliteEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SqliteEntity()
        {
            this.SqliteEntityContacts = new HashSet<SqliteEntityContact>();
            this.SqliteEntityCrops = new HashSet<SqliteEntityCrop>();
            this.SqliteEntityLocations = new HashSet<SqliteEntityLocation>();
            this.SqliteEntityImages = new HashSet<SqliteEntityImage>();
        }
    
        public long Id { get; set; }
        public long BatchId { get; set; }
        public long EmployeeId { get; set; }
        public string PhoneDbId { get; set; }
        public bool AtBusiness { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string LandSize { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string LocationTaskStatus { get; set; }
        public string LocationException { get; set; }
        public long MNC { get; set; }
        public long MCC { get; set; }
        public long LAC { get; set; }
        public long CellId { get; set; }
        public bool IsProcessed { get; set; }
        public long EntityId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int ContactCount { get; set; }
        public int CropCount { get; set; }
        public int ImageCount { get; set; }
        public string UniqueIdType { get; set; }
        public string UniqueId { get; set; }
        public string TaxId { get; set; }
        public int LocationCount { get; set; }
        public string DerivedLocSource { get; set; }
        public decimal DerivedLatitude { get; set; }
        public decimal DerivedLongitude { get; set; }
        public string FatherHusbandName { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string HQCode { get; set; }
        public string HQName { get; set; }
    
        public virtual SqliteActionBatch SqliteActionBatch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SqliteEntityContact> SqliteEntityContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SqliteEntityCrop> SqliteEntityCrops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SqliteEntityLocation> SqliteEntityLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SqliteEntityImage> SqliteEntityImages { get; set; }
    }
}
