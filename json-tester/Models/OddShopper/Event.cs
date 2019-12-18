using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_tester.Models.OddShopper
{
    public class Event
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime StartDate { get; set; }
        public string League { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ExternalId { get; set; }
        public virtual ICollection<Outcome> Outcomes { get; set; }
    }
}
