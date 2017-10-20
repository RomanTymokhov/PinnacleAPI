using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PinnacleWrapper;
using PinnacleWrapper.Data;
using PinnacleWrapper.Enums;
using Newtonsoft.Json;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PinnacleClient client = new PinnacleClient();

            var balance = client.GetClientBalance().Result.AvailableBalance;
            var ligues = client.GetLeagues(29).Result.ToList();
            var sports = client.GetSports().Result.ToList();
            var odds = client.GetOdds(new GetOddsRequest(29)).Result.Leagues;

            //foreach (var ligue in ligues)
            //{
            //    Console.WriteLine(ligue.AllowRoundRobins);
            //}

            //foreach (var sport in sports)
            //{
            //    Console.WriteLine(sport.Id + " " + sport.Name);
            //}

            foreach (var odd in odds)
            {
                Console.WriteLine(odd.Id);
            }

            Console.WriteLine(balance);
            
        }
    }
}
