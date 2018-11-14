using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARBOR.Classes
{
    public class Ship
    {
        public double mass { get; set; } //kiloGrams
        public long hieght { get; set; } //Blocks
        public long width { get; set; }
        public long length { get; set; }
        public Thruster thrustElem { get; set; }
        public PowerSource powerSour { get; set; }

        public Ship()
        {

        }

        public Ship(double mass, long hieght, long width, long length, Thruster thrustElem, PowerSource powerSour)
        {
            this.mass = mass;
            this.hieght = hieght;
            this.width = width;
            this.length = length;
            this.thrustElem = thrustElem;
            this.powerSour = powerSour;
        }
    }
}