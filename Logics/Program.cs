using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logics.API;

namespace Logics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter tvshow: ");
            var title = Console.ReadLine();
            try
            {
                var tvShowData = ApiRequest.GetSearchResults(title);

                if (tvShowData != null)
                {
                    foreach (var item in tvShowData.Results)
                    {
                        Console.WriteLine("id = {0}, title = {1}", item.Id, item.Name);
                    }
                }

                else
                    Console.WriteLine("No data returned");


                foreach (var item in tvShowData.Results)
                {
                    var details = ApiRequest.GetDetails(item.Id);
                    Console.WriteLine("Name: {0}, Seasons: {1}, Episodes: {2}", details.Name, details.Number_of_seasons,
                        details.Number_of_episodes);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }


            Console.ReadLine();

        }
    }
}
