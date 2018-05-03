using System;
using Newtonsoft.Json;

namespace PrismRefitTutorial.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string userName { get; set; }

        public override string ToString()
        {
            return userName;
        }
    }
}
