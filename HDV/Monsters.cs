namespace HDV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Monsters
    {
        [JsonProperty("_id")]
        public long Id { get; set; }

        [JsonProperty("ankamaId")]
        public long AnkamaId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("imgUrl")]
        public Uri ImgUrl { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("statistics")]
        public List<Statistic> Statistics { get; set; }

        [JsonProperty("resistances")]
        public List<Resistance> Resistances { get; set; }

        [JsonProperty("areas", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Areas { get; set; }

        [JsonProperty("drops", NullValueHandling = NullValueHandling.Ignore)]
        public List<Drop> Drops { get; set; }
    }

    public partial class Drop
    {
        [JsonProperty("imgUrl")]
        public Uri ImgUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dropPercent")]
        public DropPercent DropPercent { get; set; }

        [JsonProperty("ankamaId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AnkamaId { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public partial class DropPercent
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }
    }

    public partial class Resistance
    {
        [JsonProperty("Terre", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Terre { get; set; }

        [JsonProperty("Air", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Air { get; set; }

        [JsonProperty("Feu", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Feu { get; set; }

        [JsonProperty("Eau", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Eau { get; set; }

        [JsonProperty("Neutre", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Neutre { get; set; }
    }

    public partial class Statistic
    {
        [JsonProperty("PV", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Pv { get; set; }

        [JsonProperty("PA", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Pa { get; set; }

        [JsonProperty("PM", NullValueHandling = NullValueHandling.Ignore)]
        public DropPercent Pm { get; set; }
    }
}
