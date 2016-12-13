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
                if (item.TvShow.Name  == nowTvShow.TvShow.Name)
                {
                    throw new ArgumentException("This event already exists");
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
                    throw new ArgumentException("This event already exists");
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

    }
}
