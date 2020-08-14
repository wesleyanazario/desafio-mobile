using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Newtonsoft.Json;

namespace Vitreo.Model
{
    public partial class CharacterDataWrapper
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("attributionText")]
        public string attributionText { get; set; }

        [JsonProperty("attributionHTML")]
        public string attributionHtml { get; set; }

        [JsonProperty("etag")]
        public string etag { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }
    }
}