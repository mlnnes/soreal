using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Logics.API.DTO.Details;
using Logics.API.DTO.Search;
using Logics.Data;
using Newtonsoft.Json;

namespace Logics.API
{
    public class ApiRequest
    {
        const string ApiKey = "4005fabf819584489ce4d821e4dc9862";

        static string QuerySearch(string title)
        {
            return string.Format("https://api.themoviedb.org/3/search/tv?query={0}&language=en-US&api_key={1}", title,
                ApiKey);
        }

        public static SearchByName GetSearchResults(string title)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetStringAsync(QuerySearch(title)).Result;
                return JsonConvert.DeserializeObject<SearchByName>(result);

            }
        }

        private static string QueryDetails(int id)
        {
            return
                string.Format(
                    "https://api.themoviedb.org/3/tv/{0}?append_to_response=credits&language=en-US&api_key={1}", id,
                    ApiKey);
        }

        public static TvShowDetails GetDetails(int id)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetStringAsync(QueryDetails(id)).Result;
                return JsonConvert.DeserializeObject<TvShowDetails>(result);

            }
        }

        public List<TvShows> GetAllResults(string title)
        {
            var searchResults = GetSearchResults(title);

            List <TvShows> searchList = new List<TvShows>();

            foreach (var item in searchResults.Results)
            {
                string cast = "";

                var tvShowDetails = GetDetails(item.Id);

                foreach (var actor in tvShowDetails.Credits.Cast)
                {
                    cast += actor.Name + ", ";
                }

                searchList.Add(new TvShows
                {
                    Name = tvShowDetails.Name,
                    TotalNumberOfEpisodes = tvShowDetails.Number_of_episodes,
                    TotalNumberOfSeasons = tvShowDetails.Number_of_seasons,
                    Cast = cast,
                    Country = String.Join(", ", tvShowDetails.Countries)

                });

            }

            return searchList;
        }


}
}
