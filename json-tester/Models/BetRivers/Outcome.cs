using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_tester.Models.Betrivers
{
    public class Outcome
    {
        public string Id { get; set; }
        public decimal Line { get; set; }
        public string OddsAmerican { get; set; }
        public string OddsFractional { get; set; }
        public string Label { get; set; }
    }
}
