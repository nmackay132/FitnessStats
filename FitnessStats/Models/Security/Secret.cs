using System;

namespace FitnessStats.Models.Security
{
    public class Secret
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}