using AIHR_LogicTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIHR_LogicTest
{
    public static class SolarSystemExtention
    {
        public static void Colonize(CelestialBody celestialBody)
        {
            Console.WriteLine($" Colonize method has been called for CelestialBody : {celestialBody.Name}.)");
        }
    }
}
