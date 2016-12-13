using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.Data;

namespace Logics.UserData
{
    class NowTvShows
    {
        public TvShows TvShow { get; set; }

        public int NowSeason { get; set; }

        public int NowEpisode { get; set; }


        public NowTvShows(TvShows tvShow)
        {
            TvShow = tvShow;
            NowSeason = 1;
            NowEpisode = 1;
        }

        public void AddSeenEpisode(NowTvShows nowTvShow)
        {
            
        }
    }
}
