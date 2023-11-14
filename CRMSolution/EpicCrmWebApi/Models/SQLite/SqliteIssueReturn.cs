﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicCrmWebApi
{
    public class SqliteIssueReturn
    {
        public bool IsNewEntity { get; set; }
        public bool IsNewAgreement { get; set; }

        public long EntityId { get; set; }
        public string EntityName { get; set; }

        public long AgreementId { get; set; }
        public string AgreementNumber { get; set; }

        // used only for new entries to match it up on server
        public string ParentReferenceId { get; set; }

        public string TranType { get; set; } // Issue/Return
        public long ItemId { get; set; }
        public string ItemCode { get; set; }
        public string SlipNumber { get; set; }
        public double Acreage { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeStamp { get; set; }  // only date part is relevant
        public string ActivityId { get; set; }

        // May 4 2020
        public decimal ItemRate { get; set; }
    }
}