using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIHR_LogicTest.CelestialBodies
{
    public interface ICelestialBody
    {
        public bool CanSustainLife { get; set; }

        public bool CanBeTerraformed { get; set; }

        public bool HasSatelliteMoon { get; set; }
    }
}
