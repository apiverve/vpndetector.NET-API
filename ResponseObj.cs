using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("is_vpn")]
        public bool Isvpn { get; set; }

        [JsonProperty("is_datacenter")]
        public bool Isdatacenter { get; set; }

        [JsonProperty("checked_on")]
        public string Checkedon { get; set; }

        [JsonProperty("risk_level")]
        public string Risklevel { get; set; }

        [JsonProperty("threat_level")]
        public string Threatlevel { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
