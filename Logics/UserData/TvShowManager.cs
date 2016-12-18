using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    public class TvShowManager
    {

        List<NowTvShows> alreadyTvShowsList = new List<NowTvShows>();

        List<NowTvShows> laterTvShowsList = new List<NowTvShows>();

        List<NowTvShows> nowTvShowsList = new List<NowTvShows>();


        public List<NowTvShows> AlreadyTvShowsList
        {
            get { return alreadyTvShowsList; }
            set { alreadyTvShowsList = value; }
        }

        public List<NowTvShows> LaterTvShowsList
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

            if (nowTvShow != null)
            {
                foreach (var item in nowTvShowsList)
                {
                    if (item.TvShow.Name == nowTvShow.TvShow.Name)
                    {
                        throw new ArgumentException();
                    }
                }

                nowTvShowsList.Add(nowTvShow);

            }

            else

            {
                throw new FormatException();
            }
        }


        public void AddAlreadyTvShow(NowTvShows alreadyTvShow)
        {
            if (alreadyTvShow != null)
            {
                foreach (var item in alreadyTvShowsList)
                {
                    if (item.Name == alreadyTvShow.Name)
                    {
                        throw new ArgumentException();
                    }
                }

                AlreadyTvShowsList.Add(alreadyTvShow);
            }
            else
            {
                throw new ArgumentNullException();
            }

        }


        public void AddLaterTvShow(NowTvShows laterTvShow)
        {

            if (laterTvShow != null)
            {
                foreach (var item in laterTvShowsList)
                {
                    if (item.Name == laterTvShow.Name)
                    {
                        throw new ArgumentException();
                    }
                }

                laterTvShowsList.Add(laterTvShow);

            }

            else

            {
                throw new FormatException();
            }
        }

        public void AddSeenEpisode(NowTvShows nowTvShow)
        {
            using (var context = new Context())
            {
                //var episode = nowTvShow.NowEpisode;
                //var season = nowTvShow.NowSeason;
                //var totalSeasons = nowTvShow.TvShow.TotalNumberOfSeasons;
                var seasonsList = context.Seasons.Where(r => r.TvShow.Name == nowTvShow.TvShow.Name).ToList();

                foreach (var item in seasonsList)
                {
                    //var totalEpisodes = item.NumberOfEpisodes;

                    if (nowTvShow.NowEpisode < item.NumberOfEpisodes)
                    {
                        nowTvShow.NowEpisode += 1;
                        break;
                    }
                    else
                    {
                        if (nowTvShow.NowSeason < nowTvShow.TvShow.TotalNumberOfSeasons)
                        {
                            nowTvShow.NowSeason += 1;
                            nowTvShow.NowEpisode = 1;
                            break;
                        }
                        else
                        {
                            var alr = new NowTvShows(nowTvShow.TvShow);

                            RemoveFromAList(nowTvShow);
                            AddAlreadyTvShow(alr);
                            
                            break;
                        }
                    }
                }
            }
        }


       

        public void RemoveFromAList(NowTvShows nowTvShow)
        {
            if (NowTvShowsList.Contains(nowTvShow))
            {
                NowTvShowsList.Remove(nowTvShow);
            }
            if (AlreadyTvShowsList.Contains(nowTvShow))
            {
                AlreadyTvShowsList.Remove(nowTvShow);
            }

            if (LaterTvShowsList.Contains(nowTvShow))
            {
                LaterTvShowsList.Remove(nowTvShow);
            }
        }
    }
}
