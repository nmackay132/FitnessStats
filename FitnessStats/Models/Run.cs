using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models
{
    public class Run
    {
        public int UtcOffset { get; set; }
        public double Duration { get; set; }
        public DateTime StartTime { get; set; }
        public double TotalCalories { get; set; }
        public string TrackingMode { get; set; }
        public double TotalDistance { get; set; }
        public string EntryMode { get; set; }
        public bool HasPath { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}