using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FitnessStats.Models
{
    [BsonIgnoreExtraElements]
    public class Run
    {
        public ObjectId Id { get; set; }
        [BsonElement("utc_offset")]
        public int UtcOffset { get; set; }
        [BsonElement("duration")]
        public double Duration { get; set; }
        [BsonElement("start_time")]
        public DateTime StartTime { get; set; }
        [BsonElement("total_calories")]
        public double TotalCalories { get; set; }
        [BsonElement("tracking_mode")]
        public string TrackingMode { get; set; }
        [BsonElement("total_distance")]
        public double TotalDistance { get; set; }
        [BsonElement("entry_mode")]
        public string EntryMode { get; set; }
        [BsonElement("has_path")]
        public bool HasPath { get; set; }
        [BsonElement("source")]
        public string Source { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("uri")]
        public string Uri { get; set; }
    }
}