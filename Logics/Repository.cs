using Logics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class Repository
    {
        public List<TvShows> ListOfTvShows()
        {
            List<TvShows> tvShowsList = new List<TvShows>();

            using (var context = new Context())
            {
                foreach (var tvShow in context.TvShows.ToList())
                {
                    if (tvShow.Id < 51)
                    {
                        tvShowsList.Add(tvShow);
                    }
                }

                return tvShowsList;
            }

        }

        public List<TvShows> SearchByName(string name)
        {
            if (name != String.Empty)
            {
                using (var context = new Context())
                {
                    var result = context.TvShows.Where(r => r.Name == name && r.Id < 51).ToList();

                    if (result.Count != 0)
                    {
                        return result;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public void AddTvShowToDataBase(string name, string country, string cast,
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
