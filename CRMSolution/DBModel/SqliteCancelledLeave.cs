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
    
    public partial class SqliteCancelledLeave
    {
        public long Id { get; set; }
        public long BatchId { get; set; }
        public long EmployeeId { get; set; }
        public long LeaveId { get; set; }
        public bool IsProcessed { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
    
        public virtual SqliteActionBatch SqliteActionBatch { get; set; }
    }
}
