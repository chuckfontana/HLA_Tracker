using System;
using System.Collections.Generic;
using System.Text;

namespace HLA_Tracker.Core.Domain
{
    public class SerologicalType:BaseObject
    {
        public Patient Patient { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string BPub1 { get; set; }
        public string BPub2 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string DR1 { get; set; }
        public string DR2 { get; set; }
        public string DRB2_1 { get; set; }
        public string DRB2_2 { get; set; }
        public string DQ1 { get; set; }
        public string DQ2 { get; set; }
        public string DP1 { get; set; }
        public string DP2 { get; set; }
    }
}
