using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logics.API.DTO.Details
{
    public class ApiSeason
    {
        [JsonProperty("season_number")]
        public int Season_number { get; set; }

        [JsonProperty("episode_count")]
        public int Episode_count { get; set; }
    }
}
