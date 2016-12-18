using Logics.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Logics
{
   public class RepositorySeed
    {
        private class ReadData
        {
            public List<TvShows> TvShows { get; set; }

            public List<Season> Seasons { get; set; }

        }

        ReadData readData;

        public IEnumerable<TvShows> TvShows
        {
            get
            {
                return readData.TvShows;
            }
        }

        public IEnumerable<Season> Seasons
        {
            get
            {
                return readData.Seasons;
            }
        }

        public RepositorySeed()
        {
            readData = JsonConvert.DeserializeObject<ReadData>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "../../../LOSData1.json"));
        }

    }
}
