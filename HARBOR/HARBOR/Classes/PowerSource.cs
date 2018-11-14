using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARBOR.Classes
{
    public class PowerSource
    {
        public string type { get; set; } // small vs large vs batery
        public bool size { get; set; } // false is small, true is large
        public long powerOutput { get; set; } //kiloWatts
        public long powerConsumption { get; set; } //kiloWatt Hour
        public long powerStorage { get; set; } //kiloWatts
        public int MyProperty { get; set; }
    }
}
