using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("ip")]
    public string ip { get; set; }

    [JsonProperty("is_vpn")]
    public bool isvpn { get; set; }

    [JsonProperty("is_datacenter")]
    public bool isdatacenter { get; set; }

    [JsonProperty("checked_on")]
    public string checkedon { get; set; }

    [JsonProperty("risk_level")]
    public string risklevel { get; set; }

    [JsonProperty("threat_level")]
    public string threatlevel { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
