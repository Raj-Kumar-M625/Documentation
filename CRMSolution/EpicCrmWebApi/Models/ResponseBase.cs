﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace EpicCrmWebApi
{
    public class ResponseBase : MinimumResponse
    {
        public long EmployeeDayId { get; set; }
    }
}