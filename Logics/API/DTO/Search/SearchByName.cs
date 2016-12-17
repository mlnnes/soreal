using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logics.API.DTO.Search
{
    public class SearchByName
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }

    }
}
