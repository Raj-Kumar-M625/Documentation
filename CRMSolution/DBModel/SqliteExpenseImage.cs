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
    
    public partial class SqliteExpenseImage
    {
        public long Id { get; set; }
        public long SqliteExpenseId { get; set; }
        public int SequenceNumber { get; set; }
        public string ImageFileName { get; set; }
    
        public virtual SqliteExpense SqliteExpense { get; set; }
    }
}
