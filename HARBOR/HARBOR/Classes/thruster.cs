using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARBOR.Classes
{
    public class Thruster
    {
        public string type { get; set; }
        public bool size { get; set; } // false is small, true is large
        public int thrust { get; set; } //kiloNewtons of output thrust
        public double powerRequirement { get; set; } //kiloWatts
        public double fuelConsumption { get; set; } //Units of Hydrogen per Second
        public int numberUsed { get; set; }

        public Thruster()
        {

        }

        public Thruster(string type, bool size, int thrust, long mass, double powerRequirement, double fuelConsumption, int numberUsed)
        {
            this.type = type;
            this.size = size;
            this.thrust = thrust;
            this.mass = mass;
            this.powerRequirement = powerRequirement;
            this.fuelConsumption = fuelConsumption;
            this.numberUsed = numberUsed;
        }
    }
}