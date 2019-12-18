using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_tester.Models.Betrivers
{
    public class BetOffer
    {
        public string Id { get; set; }
        public string BetOfferType { get; set; }
        public string CashOutStatus { get; set; }
        public string BetDescription { get; set; }
        public Outcome[] Outcomes { get; set; }
    }
}
