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
    
    public partial class SqliteActionDup
    {
        public long Id { get; set; }
        public long SqliteTableId { get; set; }
        public long BatchId { get; set; }
        public long EmployeeId { get; set; }
        public System.DateTime At { get; set; }
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public long MNC { get; set; }
        public long MCC { get; set; }
        public long LAC { get; set; }
        public long CellId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientType { get; set; }
        public string ActivityType { get; set; }
        public string Comments { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int ActivityTrackingType { get; set; }
        public int ImageCount { get; set; }
        public string PhoneDbId { get; set; }
        public string ClientCode { get; set; }
        public int ContactCount { get; set; }
        public bool AtBusiness { get; set; }
        public decimal ActivityAmount { get; set; }
    }
}
