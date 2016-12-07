using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics.Data
{
    class Season
    {
        public int Id { get; set; }

        public int TvShowId { get; set; }

        public int NumberOfSeason { get; set; }

        public int NumberOfEpisodes { get; set; }

        public TvShows TvShow { get; set; }
    }
}
