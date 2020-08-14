using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Newtonsoft.Json;

namespace Vitreo.Model
{
    public partial class Thumbnail
    {
        [JsonProperty("path")]
        public String Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        public string portrait_small { get; set; }

        public string portrait_medium { get; set; }

        public string portrait_xlarge { get; set; }

        public string portrait_fantastic { get; set; }

        public string portrait_uncanny { get; set; }

        public string portrait_incredible { get; set; }

    }
}