namespace HDV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Runes
    {
        [JsonProperty("statisticName")]
        public string StatisticName { get; set; }

        [JsonProperty("unitWeight")]
        public double UnitWeight { get; set; }

        [JsonProperty("nbMaxOver")]
        public long NbMaxOver { get; set; }

        [JsonProperty("imgUrl")]
        public Uri ImgUrl { get; set; }

        [JsonProperty("type")]
        public List<TypeElement> Type { get; set; }
    }

    public partial class TypeElement
    {
        [JsonProperty("runeName")]
        public string RuneName { get; set; }

        [JsonProperty("nbStat")]
        public long NbStat { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }
}
