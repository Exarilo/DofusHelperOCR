namespace HDV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Items
    {
        [JsonProperty("_id")]
        public long Id { get; set; }

        [JsonProperty("ankamaId")]
        public long AnkamaId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("type")]
        public ItemType Type { get; set; }

        [JsonProperty("imgUrl")]
        public Uri ImgUrl { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, StatisticClass>> Statistics { get; set; }

        [JsonProperty("recipe")]
        public List<Dictionary<string, Recipe>> Recipe { get; set; }

        [JsonProperty("setId")]
        public long SetId { get; set; }

        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Conditions { get; set; }
    }

    public partial class Recipe
    {
        [JsonProperty("ankamaId")]
        public long AnkamaId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("imgUrl")]
        public Uri ImgUrl { get; set; }

        [JsonProperty("type")]
        public RecipeType Type { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }
    }

    public partial class StatisticClass
    {
        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }
    }

    public enum RecipeType { Aile, Alliage, Amulette, Anneau, Bois, Bottes, Bourgeon, Cape, Carapace, Ceinture, Cereale, Champignon, Chapeau, Coquille, Cuir, Ecorce, EssenceDeGardienDeDonjon, Etoffe, Fleur, Friandise, Fruit, Galet, Gelee, Graine, Huile, Laine, Legume, MaterielAlchimie, Minerai, Nowel, Oreille, Os, Pain, Patte, Peau, PierreBrute, PierrePrecieuse, Planche, Plante, Plume, Poil, Poisson, Potion, Poudre, Queue, Racine, RessourcesDiverses, Runes, Substrat, Teinture, Trophee, Vêtement, Œil, Œuf };

    public enum ItemType { Amulette, Anneau, Bottes, Bouclier, Cape, Ceinture, Chapeau, Dofus, ObjetVivant, SacADos, Trophee };

    public partial struct StatisticValue
    {
        public StatisticClass StatisticClass;
        public string String;

        public static implicit operator StatisticValue(StatisticClass StatisticClass) => new StatisticValue { StatisticClass = StatisticClass };
        public static implicit operator StatisticValue(string String) => new StatisticValue { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                RecipeTypeConverter.Singleton,
                StatisticValueConverter.Singleton,
                ItemTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class RecipeTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RecipeType) || t == typeof(RecipeType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Aile":
                    return RecipeType.Aile;
                case "Alliage":
                    return RecipeType.Alliage;
                case "Amulette":
                    return RecipeType.Amulette;
                case "Anneau":
                    return RecipeType.Anneau;
                case "Bois":
                    return RecipeType.Bois;
                case "Bottes":
                    return RecipeType.Bottes;
                case "Bourgeon":
                    return RecipeType.Bourgeon;
                case "Cape":
                    return RecipeType.Cape;
                case "Carapace":
                    return RecipeType.Carapace;
                case "Ceinture":
                    return RecipeType.Ceinture;
                case "Cereale":
                    return RecipeType.Cereale;
                case "Champignon":
                    return RecipeType.Champignon;
                case "Chapeau":
                    return RecipeType.Chapeau;
                case "Coquille":
                    return RecipeType.Coquille;
                case "Cuir":
                    return RecipeType.Cuir;
                case "EssenceDeGardienDeDonjon":
                    return RecipeType.EssenceDeGardienDeDonjon;
                case "Fleur":
                    return RecipeType.Fleur;
                case "Friandise":
                    return RecipeType.Friandise;
                case "Fruit":
                    return RecipeType.Fruit;
                case "Galet":
                    return RecipeType.Galet;
                case "Gelee":
                    return RecipeType.Gelee;
                case "Graine":
                    return RecipeType.Graine;
                case "Huile":
                    return RecipeType.Huile;
                case "Laine":
                    return RecipeType.Laine;
                case "Legume":
                    return RecipeType.Legume;
                case "MaterielAlchimie":
                    return RecipeType.MaterielAlchimie;
                case "Minerai":
                    return RecipeType.Minerai;
                case "Nowel":
                    return RecipeType.Nowel;
                case "Oreille":
                    return RecipeType.Oreille;
                case "Os":
                    return RecipeType.Os;
                case "Pain":
                    return RecipeType.Pain;
                case "Patte":
                    return RecipeType.Patte;
                case "Peau":
                    return RecipeType.Peau;
                case "PierreBrute":
                    return RecipeType.PierreBrute;
                case "PierrePrecieuse":
                    return RecipeType.PierrePrecieuse;
                case "Planche":
                    return RecipeType.Planche;
                case "Plante":
                    return RecipeType.Plante;
                case "Plume":
                    return RecipeType.Plume;
                case "Poil":
                    return RecipeType.Poil;
                case "Poisson":
                    return RecipeType.Poisson;
                case "Potion":
                    return RecipeType.Potion;
                case "Poudre":
                    return RecipeType.Poudre;
                case "Queue":
                    return RecipeType.Queue;
                case "Racine":
                    return RecipeType.Racine;
                case "RessourcesDiverses":
                    return RecipeType.RessourcesDiverses;
                case "Runes":
                    return RecipeType.Runes;
                case "Substrat":
                    return RecipeType.Substrat;
                case "Teinture":
                    return RecipeType.Teinture;
                case "Trophee":
                    return RecipeType.Trophee;
                case "Vêtement":
                    return RecipeType.Vêtement;
                case "ecorce":
                    return RecipeType.Ecorce;
                case "etoffe":
                    return RecipeType.Etoffe;
                case "Œil":
                    return RecipeType.Œil;
                case "Œuf":
                    return RecipeType.Œuf;
            }
            throw new Exception("Cannot unmarshal type RecipeType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RecipeType)untypedValue;
            switch (value)
            {
                case RecipeType.Aile:
                    serializer.Serialize(writer, "Aile");
                    return;
                case RecipeType.Alliage:
                    serializer.Serialize(writer, "Alliage");
                    return;
                case RecipeType.Amulette:
                    serializer.Serialize(writer, "Amulette");
                    return;
                case RecipeType.Anneau:
                    serializer.Serialize(writer, "Anneau");
                    return;
                case RecipeType.Bois:
                    serializer.Serialize(writer, "Bois");
                    return;
                case RecipeType.Bottes:
                    serializer.Serialize(writer, "Bottes");
                    return;
                case RecipeType.Bourgeon:
                    serializer.Serialize(writer, "Bourgeon");
                    return;
                case RecipeType.Cape:
                    serializer.Serialize(writer, "Cape");
                    return;
                case RecipeType.Carapace:
                    serializer.Serialize(writer, "Carapace");
                    return;
                case RecipeType.Ceinture:
                    serializer.Serialize(writer, "Ceinture");
                    return;
                case RecipeType.Cereale:
                    serializer.Serialize(writer, "Cereale");
                    return;
                case RecipeType.Champignon:
                    serializer.Serialize(writer, "Champignon");
                    return;
                case RecipeType.Chapeau:
                    serializer.Serialize(writer, "Chapeau");
                    return;
                case RecipeType.Coquille:
                    serializer.Serialize(writer, "Coquille");
                    return;
                case RecipeType.Cuir:
                    serializer.Serialize(writer, "Cuir");
                    return;
                case RecipeType.EssenceDeGardienDeDonjon:
                    serializer.Serialize(writer, "EssenceDeGardienDeDonjon");
                    return;
                case RecipeType.Fleur:
                    serializer.Serialize(writer, "Fleur");
                    return;
                case RecipeType.Friandise:
                    serializer.Serialize(writer, "Friandise");
                    return;
                case RecipeType.Fruit:
                    serializer.Serialize(writer, "Fruit");
                    return;
                case RecipeType.Galet:
                    serializer.Serialize(writer, "Galet");
                    return;
                case RecipeType.Gelee:
                    serializer.Serialize(writer, "Gelee");
                    return;
                case RecipeType.Graine:
                    serializer.Serialize(writer, "Graine");
                    return;
                case RecipeType.Huile:
                    serializer.Serialize(writer, "Huile");
                    return;
                case RecipeType.Laine:
                    serializer.Serialize(writer, "Laine");
                    return;
                case RecipeType.Legume:
                    serializer.Serialize(writer, "Legume");
                    return;
                case RecipeType.MaterielAlchimie:
                    serializer.Serialize(writer, "MaterielAlchimie");
                    return;
                case RecipeType.Minerai:
                    serializer.Serialize(writer, "Minerai");
                    return;
                case RecipeType.Nowel:
                    serializer.Serialize(writer, "Nowel");
                    return;
                case RecipeType.Oreille:
                    serializer.Serialize(writer, "Oreille");
                    return;
                case RecipeType.Os:
                    serializer.Serialize(writer, "Os");
                    return;
                case RecipeType.Pain:
                    serializer.Serialize(writer, "Pain");
                    return;
                case RecipeType.Patte:
                    serializer.Serialize(writer, "Patte");
                    return;
                case RecipeType.Peau:
                    serializer.Serialize(writer, "Peau");
                    return;
                case RecipeType.PierreBrute:
                    serializer.Serialize(writer, "PierreBrute");
                    return;
                case RecipeType.PierrePrecieuse:
                    serializer.Serialize(writer, "PierrePrecieuse");
                    return;
                case RecipeType.Planche:
                    serializer.Serialize(writer, "Planche");
                    return;
                case RecipeType.Plante:
                    serializer.Serialize(writer, "Plante");
                    return;
                case RecipeType.Plume:
                    serializer.Serialize(writer, "Plume");
                    return;
                case RecipeType.Poil:
                    serializer.Serialize(writer, "Poil");
                    return;
                case RecipeType.Poisson:
                    serializer.Serialize(writer, "Poisson");
                    return;
                case RecipeType.Potion:
                    serializer.Serialize(writer, "Potion");
                    return;
                case RecipeType.Poudre:
                    serializer.Serialize(writer, "Poudre");
                    return;
                case RecipeType.Queue:
                    serializer.Serialize(writer, "Queue");
                    return;
                case RecipeType.Racine:
                    serializer.Serialize(writer, "Racine");
                    return;
                case RecipeType.RessourcesDiverses:
                    serializer.Serialize(writer, "RessourcesDiverses");
                    return;
                case RecipeType.Runes:
                    serializer.Serialize(writer, "Runes");
                    return;
                case RecipeType.Substrat:
                    serializer.Serialize(writer, "Substrat");
                    return;
                case RecipeType.Teinture:
                    serializer.Serialize(writer, "Teinture");
                    return;
                case RecipeType.Trophee:
                    serializer.Serialize(writer, "Trophee");
                    return;
                case RecipeType.Vêtement:
                    serializer.Serialize(writer, "Vêtement");
                    return;
                case RecipeType.Ecorce:
                    serializer.Serialize(writer, "ecorce");
                    return;
                case RecipeType.Etoffe:
                    serializer.Serialize(writer, "etoffe");
                    return;
                case RecipeType.Œil:
                    serializer.Serialize(writer, "Œil");
                    return;
                case RecipeType.Œuf:
                    serializer.Serialize(writer, "Œuf");
                    return;
            }
            throw new Exception("Cannot marshal type RecipeType");
        }

        public static readonly RecipeTypeConverter Singleton = new RecipeTypeConverter();
    }

    internal class StatisticValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StatisticValue) || t == typeof(StatisticValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new StatisticValue { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<StatisticClass>(reader);
                    return new StatisticValue { StatisticClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type StatisticValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StatisticValue)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StatisticClass != null)
            {
                serializer.Serialize(writer, value.StatisticClass);
                return;
            }
            throw new Exception("Cannot marshal type StatisticValue");
        }

        public static readonly StatisticValueConverter Singleton = new StatisticValueConverter();
    }

    internal class ItemTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ItemType) || t == typeof(ItemType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Amulette":
                    return ItemType.Amulette;
                case "Anneau":
                    return ItemType.Anneau;
                case "Bottes":
                    return ItemType.Bottes;
                case "Bouclier":
                    return ItemType.Bouclier;
                case "Cape":
                    return ItemType.Cape;
                case "Ceinture":
                    return ItemType.Ceinture;
                case "Chapeau":
                    return ItemType.Chapeau;
                case "Dofus":
                    return ItemType.Dofus;
                case "ObjetVivant":
                    return ItemType.ObjetVivant;
                case "SacADos":
                    return ItemType.SacADos;
                case "Trophee":
                    return ItemType.Trophee;
            }
            throw new Exception("Cannot unmarshal type ItemType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ItemType)untypedValue;
            switch (value)
            {
                case ItemType.Amulette:
                    serializer.Serialize(writer, "Amulette");
                    return;
                case ItemType.Anneau:
                    serializer.Serialize(writer, "Anneau");
                    return;
                case ItemType.Bottes:
                    serializer.Serialize(writer, "Bottes");
                    return;
                case ItemType.Bouclier:
                    serializer.Serialize(writer, "Bouclier");
                    return;
                case ItemType.Cape:
                    serializer.Serialize(writer, "Cape");
                    return;
                case ItemType.Ceinture:
                    serializer.Serialize(writer, "Ceinture");
                    return;
                case ItemType.Chapeau:
                    serializer.Serialize(writer, "Chapeau");
                    return;
                case ItemType.Dofus:
                    serializer.Serialize(writer, "Dofus");
                    return;
                case ItemType.ObjetVivant:
                    serializer.Serialize(writer, "ObjetVivant");
                    return;
                case ItemType.SacADos:
                    serializer.Serialize(writer, "SacADos");
                    return;
                case ItemType.Trophee:
                    serializer.Serialize(writer, "Trophee");
                    return;
            }
            throw new Exception("Cannot marshal type ItemType");
        }

        public static readonly ItemTypeConverter Singleton = new ItemTypeConverter();
    }
}
