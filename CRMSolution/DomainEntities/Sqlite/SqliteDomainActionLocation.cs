﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class SqliteDomainActionLocation
    {
        // Xamarin; GPS; Network
        public string Source { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime UtcAt { get; set; }
        public string LocationTaskStatus { get; set; }
        public string LocationException { get; set; }
        public bool IsGood { get; set; }
    }
}
