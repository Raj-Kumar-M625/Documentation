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
    
    public partial class SqliteEntityWorkFlow
    {
        public long Id { get; set; }
        public long ActivityId { get; set; }
        public long EntityId { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public string Phase { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsProcessed { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Activity Activity { get; set; }
    }
}
