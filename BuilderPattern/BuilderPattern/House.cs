using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Doors { get; set; }
        public string Windows { get; set; }

        public override string ToString()
        {
            return $"House with {Walls}, {Roof}, {Doors} and {Windows}";
        }
    }
}
