using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    class Program
    {
        static void Main(string[] args)
        {
           var rep = new Repository();

            //Repository.ListOfTvShows();

           var tvs = Repository.SearchByName("Westworld");
            foreach (var item in tvs)
            {
                Console.WriteLine(item.Cast);
                Console.ReadLine();
            }

            Repository.AddTvShowToDataBase("Gossip girl","USA",
                "Blake Lively, Leaton Mister, Ed Westwick",6,118);
            Console.WriteLine("Dobavilos");
            


        }
    }
}
