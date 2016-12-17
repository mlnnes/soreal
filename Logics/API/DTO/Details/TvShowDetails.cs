using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logics.API.DTO.Details
{
    public class TvShowDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number_of_episodes")]
        public int Number_of_episodes { get; set; }

        [JsonProperty("number_of_seasons")]
        public int Number_of_seasons { get; set; }

        [JsonProperty("credits")]
        public Credits Credits { get; set; }
        
        [JsonProperty("seasons")]
        public ApiSeason[] Seasons { get; set; }

        [JsonProperty("origin_country")]
        public string[] Countries { get; set; }

    }
}
