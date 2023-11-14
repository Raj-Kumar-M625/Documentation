﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class SqlitePaymentData
    {
        public long Id { get; set; }
        public string PhoneDbId { get; set; }
        public long BatchId { get; set; }
        public long EmployeeId { get; set; }
        public string CustomerCode { get; set; }
        public string PaymentType { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Comment { get; set; }
        public int ImageCount { get; set; }
        public bool IsProcessed { get; set; }
        public string PhoneActivityId { get; set; }
        public long PaymentId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
    }
}
