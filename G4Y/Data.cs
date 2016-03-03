using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4Y
{
    class Dane
    {
        public string id { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime createdAt { get; set; }
        [JsonProperty(PropertyName = "result")]
        public string result { get; set; }
    }
}
