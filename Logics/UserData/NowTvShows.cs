using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    class NowTvShows : TvShows
    {
        //public TvShows TvShow { get; set; }

        public int NowSeason { get; set; }

        public int NowEpisode { get; set; }
        
        public NowTvShows(TvShows nowTvShow)
        {
            this.Name = nowTvShow.Name;
            this.Cast = nowTvShow.Cast;
            this.Country = nowTvShow.Country;
            this.TotalNumberOfSeasons = nowTvShow.TotalNumberOfSeasons;
            NowSeason = 1;
            NowEpisode = 1;
        }

        
    }
}
