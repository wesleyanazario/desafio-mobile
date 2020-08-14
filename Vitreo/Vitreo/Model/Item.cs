using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Newtonsoft.Json;

namespace Vitreo.Model
{
    public partial class Item
    {
        [JsonProperty("resourceURI")]
        public Uri ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}