using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FitnessStats.Models
{
    [BsonIgnoreExtraElements]
    public class SyncSettings
    {
        public ObjectId Id { get; set; }

        [BsonElement("last_updated")]
        public DateTime LastUpdated { get; set; }
    }
}