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
    
    public partial class SqliteReturnOrderItem
    {
        public long Id { get; set; }
        public long SqliteReturnOrderId { get; set; }
        public int SerialNumber { get; set; }
        public string ProductCode { get; set; }
        public int UnitQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
    
        public virtual SqliteReturnOrder SqliteReturnOrder { get; set; }
    }
}
