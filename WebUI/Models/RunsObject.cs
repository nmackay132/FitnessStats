using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebUI.Models
{
    public class RunsObject
    {
        public int Size { get; set; }

        [JsonProperty("items")]
        public List<Run> Runs { get; set; }
    }
}