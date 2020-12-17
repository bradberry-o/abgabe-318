namespace SwissTransport.Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using SwissTransport;
    using SwissTransport.Core;
    using SwissTransport.Models;


    public class Connections
    {
        [JsonProperty("connections")] public List<Connection> ConnectionList { get; set; }
    }

    public class Connection
    {
        [JsonProperty("from")] public ConnectionPoint From { get; set; }

        [JsonProperty("to")] public ConnectionPoint To { get; set; }

        [JsonProperty("duration")] public string Duration { get; set; }

        [JsonProperty("sections")] public List<Section> Sections { get; set; }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")] public Station Station { get; set; }

        public DateTime? Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public DateTime? Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }
    }
}