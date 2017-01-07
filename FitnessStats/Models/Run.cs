using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FitnessStats.Models
{
    [BsonIgnoreExtraElements]
    public class Run
    {
        [JsonIgnore]
        [BsonIgnore]
        public ObjectId Id { get; set; }

        [JsonProperty("utc_offset")]
        [BsonElement("utc_offset")]
        public int UtcOffset { get; set; }

        [JsonProperty("duration")]
        [BsonElement("duration")]
        public double Duration { get; set; }

        [JsonProperty("start_time")]
        [BsonElement("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("total_calories")]
        [BsonElement("total_calories")]
        public double TotalCalories { get; set; }

        [JsonProperty("tracking_mode")]
        [BsonElement("tracking_mode")]
        public string TrackingMode { get; set; }

        [JsonProperty("total_distance")]
        [BsonElement("total_distance")]
        public double TotalDistance { get; set; }

        [JsonProperty("entry_mode")]
        [BsonElement("entry_mode")]
        public string EntryMode { get; set; }

        [JsonProperty("has_path")]
        [BsonElement("has_path")]
        public bool HasPath { get; set; }

        [JsonProperty("source")]
        [BsonElement("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        [BsonElement("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        [BsonElement("uri")]
        public string Uri { get; set; }
    }
}