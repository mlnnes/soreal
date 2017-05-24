using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    public class TvShowManager
    {
        public List<NowTvShows> alreadyTvShowsList = new List<NowTvShows>();
        public List<NowTvShows> laterTvShowsList = new List<NowTvShows>();

        public List<NowTvShows> nowTvShowsList = new List<NowTvShows>();

        public TvShowManager()
        {
            GetUserDataBase();
        }

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
                nowTvShow.NowSeason = 1;
                nowTvShow.NowEpisode = 1;

                using (Context context = new Context())
                {
                    context.NowTvShows.Add(nowTvShow);
                    context.SaveChanges();
                }
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
                using (Context context = new Context())
                {
                    context.NowTvShows.Add(alreadyTvShow);
                    context.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }

        }


        public void AddLaterTvShow(NowTvShows laterTvShow)
        {
            if (NowTvShowsList.FindAll(r => r.Name == laterTvShow.Name).Count == 1)
            {
                throw new ArgumentException("This Tv Show is in progress now");
            }

                if (laterTvShow != null)
                {
                    foreach (var item in laterTvShowsList)
                    {
                        if (item.Name == laterTvShow.Name)
                        {
                            throw new ArgumentException("This Tv Show has already been added");
                        }
                    }

                    laterTvShowsList.Add(laterTvShow);

                    using (Context context = new Context())
                    {
                        context.NowTvShows.Add(laterTvShow);
                        context.SaveChanges();
                    }

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
                if (context.Seasons.Where(r => r.TvShow.Name == nowTvShow.TvShow.Name).ToList().Count != 0)
                {
                    var seasonsList = context.Seasons.Where(r => r.TvShow.Name == nowTvShow.TvShow.Name).ToList();

                    foreach (var item in seasonsList)
                    {

                        if (nowTvShow.NowEpisode < item.NumberOfEpisodes)
                        {
                            if (LaterTvShowsList.Contains(nowTvShow))
                            {
                                RemoveFromAList(nowTvShow);
                                AddNowTvShow(nowTvShow);
                                break;
                            }


                            var result = NowTvShowsList.Find(r => r.TvShow.Id == nowTvShow.TvShow.Id);
                            var tvshow = new TvShows() { Id = result.Id };
                            context.TvShows.Attach(tvshow);
                            context.Entry(tvshow).State = EntityState.Deleted;
                            context.SaveChanges();

                            var result2 = NowTvShowsList.Find(r => r.Id == nowTvShow.Id);
                            var nowtvshow = new NowTvShows() { Id = result.Id };
                            context.NowTvShows.Attach(nowtvshow);
                            context.Entry(nowtvshow).State = EntityState.Deleted;
                            context.SaveChanges();

                            nowTvShow.NowEpisode += 1;
                            context.NowTvShows.Add(nowTvShow);
                            context.SaveChanges();
                            
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

                                alr.NowSeason = alr.TvShow.TotalNumberOfSeasons + 1;

                                RemoveFromAList(nowTvShow);
                                AddAlreadyTvShow(alr);

                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (nowTvShow.NowEpisode < nowTvShow.TvShow.TotalNumberOfEpisodes)
                    {
                        nowTvShow.NowEpisode += 1;
                    }
                    else
                    {
                        var alr = new NowTvShows(nowTvShow.TvShow);

                        alr.NowSeason = alr.TvShow.TotalNumberOfSeasons + 1;
                        RemoveFromAList(nowTvShow);

                        AddAlreadyTvShow(alr);
                    }
                }
            }
        }



        public void RemoveFromAList(NowTvShows nowTvShow)
        {

            using (var context = new Context())
            {


                if (NowTvShowsList.Contains(nowTvShow))
                {

                    var result = NowTvShowsList.Find(r => r.TvShow.Id == nowTvShow.TvShow.Id);
                    var tvshow = new TvShows() { Id = result.Id };
                    context.TvShows.Attach(tvshow);
                    context.Entry(tvshow).State = EntityState.Deleted;
                    context.SaveChanges();

                    var result2 = NowTvShowsList.Find(r => r.Id == nowTvShow.Id);
                    var nowtvshow = new NowTvShows() { Id = result.Id };
                    context.NowTvShows.Attach(nowtvshow);
                    context.Entry(nowtvshow).State = EntityState.Deleted;
                    context.SaveChanges();

                    NowTvShowsList.Remove(nowTvShow);

                    
                  


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



        public void GetUserDataBase()
        {
            
                using (Context context = new Context())
                {
                    alreadyTvShowsList =
                        context.NowTvShows.Where(r => r.NowSeason > r.TvShow.TotalNumberOfSeasons).ToList();
                    foreach (var item in alreadyTvShowsList)
                    {
                        foreach (var tvshow in context.TvShows.ToList())
                        {
                            if (item.Name == tvshow.Name && tvshow.Id < 51)
                            {
                                item.TvShow = tvshow;
                            }
                        }
                    }


                    laterTvShowsList = context.NowTvShows.Where(r => r.NowSeason == 1 && r.NowEpisode == 0).ToList();

                    foreach (var item in laterTvShowsList)
                    {
                        foreach (var tvshow in context.TvShows.ToList())
                        {
                            if (item.Name == tvshow.Name && tvshow.Id < 51)
                            {
                                item.TvShow = tvshow;
                            }
                        }
                    }


                    nowTvShowsList =
                        context.NowTvShows.Where(
                                r =>
                                    r.NowSeason <= r.TvShow.TotalNumberOfSeasons &&
                                    !(r.NowSeason == 1 && r.NowEpisode == 0))
                            .ToList();

                    foreach (var item in nowTvShowsList)
                    {
                        foreach (var tvshow in context.TvShows.ToList())
                        {
                            if (item.Name == tvshow.Name && tvshow.Id < 51)
                            {
                                item.TvShow = tvshow;
                            }
                        }
                    }

                    CheckUniqness();

                }
            }

           
        

    


        public void CheckUniqness()
        {

            foreach (var item in AlreadyTvShowsList)
            {
               var result= NowTvShowsList.FindAll(r => r.Name == item.Name)
                    ;

                foreach (var item2 in result)
                {
                    NowTvShowsList.Remove(item2);
                }
            }
        }

    }
}
