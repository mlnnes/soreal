using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logics.API.DTO.Details
{
    public class Credits
    {
        [JsonProperty("cast")]
        public Actor[] Cast { get; set; }
    }
}
