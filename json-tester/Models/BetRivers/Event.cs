using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_tester.Models.Betrivers
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Participant[] Participants { get; set; }
        public DateTime Start { get; set; }
        public EventInfo[] EventInfo { get; set; }
        public string State { get; set; }
        public BetOffer[] BetOffers { get; set; }
    }
}
