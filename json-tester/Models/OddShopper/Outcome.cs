using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_tester.Models.OddShopper
{
    public class Outcome
    {
        public int TestOdds { get; set; }
        public int GroupingId { get; set; }


        public int Id { get; set; }
        public int EventId { get; set; }
        public int OfferId { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string Line { get; set; }
        public string Odds { get; set; }

        public string Participant { get; set; }
        public int? PlayerId { get; set; }
        public bool? Preferred { get; set; }
        public string ExternalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
