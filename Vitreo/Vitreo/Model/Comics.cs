using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Newtonsoft.Json;

namespace Vitreo.Model
{
    public partial class Comics
    {
        [JsonProperty("available")]
        public long Available { get; set; }

        [JsonProperty("collectionURI")]
        public Uri CollectionUri { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

}