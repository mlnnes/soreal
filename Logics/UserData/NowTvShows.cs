using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    public class NowTvShows 
    {
        public TvShows TvShow { get; set; }

        public string Name { get; set; }

        public int NowSeason { get; set; }

        public int NowEpisode { get; set; }
        
        public NowTvShows(TvShows nowTvShow)
        {

            TvShow = nowTvShow;

            Name = nowTvShow.Name;

            //this.TvShow.Name = nowTvShow.Name;
            //this.TvShow.Cast = nowTvShow.Cast;
            //this.TvShow.Country = nowTvShow.Country;
            //this.TvShow.TotalNumberOfSeasons = nowTvShow.TotalNumberOfSeasons;
            NowSeason = 1;
            NowEpisode = 1;
        }

        
    }
}
