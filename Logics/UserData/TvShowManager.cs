using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    class TvShowManager
    {
        List<TvShows> alreadyTvShowsList = new List<TvShows>();
        
        List<TvShows> laterTvShowsList = new List<TvShows>();

        List<NowTvShows> nowTvShowsList = new List<NowTvShows>();


        public List<TvShows> AlreadyTvShowsList
        {
            get { return alreadyTvShowsList; }
            set { alreadyTvShowsList = value; }
        }

        public List<TvShows> LaterTvShowsList
        {
            get { return laterTvShowsList; }
            set { laterTvShowsList = value; }
        }

        public List<NowTvShows> NowTvShowsList
        {
            get { return nowTvShowsList; }
            set { nowTvShowsList = value; }
        }

        public void AddNowTvShow(NowTvShows nowTvShow)
        {
            foreach (var item in nowTvShowsList)
            {
                if (item.Name  == nowTvShow.Name)
                {
                    throw new ArgumentException("This tv show is already in the list");
                }
            }

            nowTvShowsList.Add(nowTvShow);

        }

        public void AddAlreadyTvShow(TvShows alreadyTvShow)
        {
            foreach (var item in alreadyTvShowsList)
            {
                if (item.Name == alreadyTvShow.Name)
                {
                    throw new ArgumentException("This tv show is already in the list");
                }
            }

            alreadyTvShowsList.Add(alreadyTvShow);

        }

        public void AddLaterTvShow(TvShows laterTvShow)
        {
            foreach (var item in laterTvShowsList)
            {
                if (item.Name == laterTvShow.Name)
                {
                    throw new ArgumentException("This event already exists");
                }
            }

            laterTvShowsList.Add(laterTvShow);
        }


        public void AddSeenEpisode(NowTvShows nowTvShow)
        {
            using (var context = new Context())
            {
                //var episode = nowTvShow.NowEpisode;
                //var season = nowTvShow.NowSeason;
                //var totalSeasons = nowTvShow.TvShow.TotalNumberOfSeasons;
                var seasonsList = context.Seasons.Where(r => r.TvShow.Name == nowTvShow.Name).ToList();

                foreach (var item in seasonsList)
                {
                    //var totalEpisodes = item.NumberOfEpisodes;

                    if (nowTvShow.NowEpisode < item.NumberOfEpisodes)
                    {
                        nowTvShow.NowEpisode += 1;
                    }
                    else
                    {
                        if (nowTvShow.NowSeason < nowTvShow.TotalNumberOfSeasons)
                        {
                            nowTvShow.NowSeason += 1;
                            nowTvShow.NowEpisode = 1;
                        }
                        else
                        {
                            var alr = new TvShows
                            {
                                Name = nowTvShow.Name,
                                Cast = nowTvShow.Cast,
                                Country = nowTvShow.Country,
                                TotalNumberOfSeasons = nowTvShow.TotalNumberOfSeasons,
                                TotalNumberOfEpisodes = nowTvShow.TotalNumberOfEpisodes,
                            };
                            alreadyTvShowsList.Add(alr);
                        }
                    }
                }
            }
        }

    }
}
