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
    
    public partial class DataFeedProcessLog
    {
        public long Id { get; set; }
        public long TenantId { get; set; }
        public bool LockAcquiredStatus { get; set; }
        public bool HasCompleted { get; set; }
        public bool HasFailed { get; set; }
        public System.DateTime At { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string ProcessName { get; set; }
    }
}
