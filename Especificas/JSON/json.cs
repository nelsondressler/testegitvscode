// Generated by https://quicktype.io

namespace QuickType {
    using System.Collections.Generic;
    using System.Globalization;
    using System;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;

    public partial class ClasseWidget {
        [JsonProperty ("widget")]
        public Widget Widget { get; set; }
    }

    public partial class Widget {
        [JsonProperty ("debug")]
        public string Debug { get; set; }

        [JsonProperty ("window")]
        public Window Window { get; set; }

        [JsonProperty ("image")]
        public Image Image { get; set; }

        [JsonProperty ("text")]
        public Text Text { get; set; }
    }

    public partial class Image {
        [JsonProperty ("src")]
        public string Src { get; set; }

        [JsonProperty ("name")]
        public string Name { get; set; }

        [JsonProperty ("hOffset")]
        public long HOffset { get; set; }

        [JsonProperty ("vOffset")]
        public long VOffset { get; set; }

        [JsonProperty ("alignment")]
        public string Alignment { get; set; }
    }

    public partial class Text {
        [JsonProperty ("data")]
        public string Data { get; set; }

        [JsonProperty ("size")]
        public long Size { get; set; }

        [JsonProperty ("style")]
        public string Style { get; set; }

        [JsonProperty ("name")]
        public string Name { get; set; }

        [JsonProperty ("hOffset")]
        public long HOffset { get; set; }

        [JsonProperty ("vOffset")]
        public long VOffset { get; set; }

        [JsonProperty ("alignment")]
        public string Alignment { get; set; }

        [JsonProperty ("onMouseUp")]
        public string OnMouseUp { get; set; }
    }

    public partial class Window {
        [JsonProperty ("title")]
        public string Title { get; set; }

        [JsonProperty ("name")]
        public string Name { get; set; }

        [JsonProperty ("width")]
        public long Width { get; set; }

        [JsonProperty ("height")]
        public long Height { get; set; }
    }

    public partial class ClasseWidget {
        public static ClasseWidget FromJson (string json) => JsonConvert.DeserializeObject<ClasseWidget> (json, QuickType.Converter.Settings);
    }

    public static class Serialize {
        public static string ToJson (this ClasseWidget self) => JsonConvert.SerializeObject (self, QuickType.Converter.Settings);
    }

    internal static class Converter {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}