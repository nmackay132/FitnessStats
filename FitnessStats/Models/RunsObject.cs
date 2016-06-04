using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MyWebApplication.Models
{
    public class RunsObject
    {
        public int Size { get; set; }

        [JsonProperty("items")]
        public List<Run> Runs { get; set; }
    }
}