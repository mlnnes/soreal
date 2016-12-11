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
   public class Repository
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

        public Repository()
        {
            readData = JsonConvert.DeserializeObject<ReadData>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "../../../LOSData1.json"));
        }


        public static List<TvShows> ListOfTvShows()
        {
            List<TvShows> tvShowsList = new List<TvShows>();

            using (var context = new Context())
            {
                var result = from tvShow in context.TvShows
                    select tvShow;

                foreach (var item in result)
                {
                    tvShowsList.Add(item);
                }

                return tvShowsList;
            }

        }

        public static List<TvShows> SearchByName(string name)
        {
            using (var context = new Context())
            {
                var result = context.TvShows.Where(r => r.Name == name).ToList();
                return result;
            }
        }


        public static void AddTvShowToDataBase(string name, string country, string cast, 
            int totalNumberOfSeasons, int totalNumberOfEpisodes)
        {
            using (var context = new Context())
            {
                foreach (var item in context.TvShows)
                {
                    if (item.Name == name)
                    {
                       throw new ArgumentException("This TV Show already exists");
                    }
                }

                var tvShow = new TvShows
                {
                    Name = name,
                    Country = country,
                    Cast = cast,
                    TotalNumberOfSeasons = totalNumberOfSeasons,
                    TotalNumberOfEpisodes = totalNumberOfEpisodes
                };
                context.TvShows.Add(tvShow);

                context.SaveChanges();
            }   
        }

    }
}
