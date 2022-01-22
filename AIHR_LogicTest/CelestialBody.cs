using AIHR_LogicTest.CelestialBodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIHR_LogicTest.Entities
{
    public abstract class CelestialBody : ICelestialBody
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public long DistanceFromSun { get; set; }
        public int OrbitalPeriod { get; set; }
        public double Mass { get; set; }

        public bool CanSustainLife { get; set; }
        public bool CanBeTerraformed { get; set; }
        public bool HasSatelliteMoon { get; set; }
    }
}
