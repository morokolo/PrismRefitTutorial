using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PrismRefitTutorial.Models
{
    public class ApiResponse
    {
        [JsonProperty("total_count")]
        public int totalCount { get; set; }
        [JsonProperty("incomplete_results")]
        public bool incompleteResults { get; set; }
        public List<User> items { get; set; }
    }
}
