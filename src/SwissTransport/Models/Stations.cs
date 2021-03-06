﻿namespace SwissTransport.Models
{
    using System.Collections.Generic;
    using System;

    using Newtonsoft.Json;

    public class Coordinate
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("x")] public double XCoordinate { get; set; }

        [JsonProperty("y")] public double YCoordinate { get; set; }
    }

    public class Station
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("score")] public int? Score { get; set; }

        [JsonProperty("coordinate")] public Coordinate Coordinate { get; set; }

        [JsonProperty("distance")] public double? Distance { get; set; }
    }

    public class Stations
    {
        [JsonProperty("stations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Station> StationList { get; set; }
    }

    public class JourneyStations
    {
        [JsonProperty("station")] public Station Station { get; set; }

        [JsonProperty("arrival")] public Station Arrival { get; set; }

        [JsonProperty("departure")] public string Departure { get; set; }
    }

    /// Added a Section class for better mapping and more information from the API.

    public class Section
    {
        [JsonProperty("journey")]
        public Journey Journey { get; set; }
    }

    /// Added a Journey class for better mapping and more information from the API.
    public class Journey
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("passList")]
        public List<Pass> Passes { get; set; }
    }

    /// Added a Pass class for better mapping and more information from the API.
    public class Pass
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        [JsonProperty("arrival")]
        public string Arrival { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }
    }
}