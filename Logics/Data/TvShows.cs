using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics.Data
{
    public class TvShows
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Cast { get; set; }

        [JsonProperty("NumberOfSeasons")]
        public int TotalNumberOfSeasons { get; set; }

        [JsonProperty("NumberOfEpisodes")]
        public int TotalNumberOfEpisodes { get; set; }


    }
}
