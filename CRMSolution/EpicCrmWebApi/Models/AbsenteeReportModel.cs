﻿using DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpicCrmWebApi
{
    public class AbsenteeReportModel
    {
        public IEnumerable<AbsenteeReportDataModel> AbsenteeReportData { get; set; }
        public IEnumerable<OfficeHierarchyModel> OfficeHierarchy { get; set; }
    }
}