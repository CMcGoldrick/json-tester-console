using json_tester.Models.OddShopper;
using json_tester.Models.Betrivers;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace json_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoadBetRivers());
            //Console.WriteLine(LoadOddShopper());
        }
         
        public static Models.OddShopper.Event[] LoadOddShopper()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\13127\source\repos\json-tester\json-tester\oddshopper.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Models.OddShopper.Event[]>(json);
                return items;
            }
        }

        public static BetOffer[] LoadBetRivers()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\13127\source\repos\json-tester\json-tester\betrivers.json"))
            {
                string json = r.ReadToEnd();
                var betOffers = JsonConvert.DeserializeObject<BetOffer[]>(json);

                return betOffers;
            }
        }


        public class OddShopperResponse
        {
            public Models.OddShopper.Event[] Events { get; set; }
        }

        public class BetriversResponse
        {
            public Models.Betrivers.Event[] Events { get; set; }
        }
    }
}



