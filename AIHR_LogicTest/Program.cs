using AIHR_LogicTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AIHR_LogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AIHR Logic Test ");
            Console.WriteLine("_____________________________________________________________________________________________");

            var collection = GetCelestialBodies();

            collection = collection.Where(x => x.DistanceFromSun > 0).OrderBy(x => x.DistanceFromSun).ToList();
            for (int i = 0; i < collection.Count(); i++)
            {
                Console.WriteLine($" {i + 1} ) {collection[i].Name} , Distance from sun : {collection[i].DistanceFromSun} , OrbitalPeriod: {collection[i].OrbitalPeriod} , Mass:{collection[i].Mass} (1024kg) , PictureUrl: {collection[i].Picture}");
                SolarSystemExtention.Colonize(collection[i]);

            }
        }

        public static List<CelestialBody> GetCelestialBodies()
        {

            var collection = new List<CelestialBody>();

            collection.Add(new Star() { Name = "Sun", Picture = "", DistanceFromSun = 0, OrbitalPeriod = 0, Mass = 1.9891e30 });
            collection.Add(new GasGiant() { Name = "Jupiter", Picture = "https://solarstory.net/img/articles/big/full-disc-view-of-jupiter-in-april-2014.jpg", DistanceFromSun = 780000000, OrbitalPeriod = 4332, Mass = 1898 });
            collection.Add(new GasGiant() { Name = "Saturn", Picture = "https://solarstory.net/img/articles/big/saturn-in-natural-color-by-cassini-huygens.jpg", DistanceFromSun = 1438000000, OrbitalPeriod = 10747, Mass = 568 });
            collection.Add(new IceGiant() { Name = "Neptune", Picture = "https://solarstory.net/img/articles/big/neptune-by-voyager-2-narrow-angle-camera.jpg", DistanceFromSun = 4495100000, OrbitalPeriod = 59800, Mass = 102 });
            collection.Add(new IceGiant() { Name = "Uranos", Picture = "https://solarstory.net/img/articles/big/planet-uranus-by-voyager-2-in-1986.jpg", DistanceFromSun = 2872500000, OrbitalPeriod = 30660, Mass = 86.8 });
            collection.Add(new TerrestrialPlanet() { Name = "Mercury", Picture = "https://solarstory.net/img/articles/big/composite-image-of-mercury-by-messenger.jpg", DistanceFromSun = 57000000, OrbitalPeriod = 88, Mass = 0.330 });
            collection.Add(new TerrestrialPlanet() { Name = "Venus", Picture = "https://solarstory.net/img/articles/big/global-radar-view-of-venus-from-magellan.jpg", DistanceFromSun = 110000000, OrbitalPeriod = 224, Mass = 4.87 });
            collection.Add(new TerrestrialPlanet() { Name = "Earth", Picture = "https://solarstory.net/img/articles/big/nasa-blue-marble-of-western-hemisphere.jpg", DistanceFromSun = 148000000, OrbitalPeriod = 365, Mass = 5.97 });
            collection.Add(new TerrestrialPlanet() { Name = "Mars", Picture = "https://solarstory.net/img/articles/big/global-color-views-of-mars-by-viking.jpg", DistanceFromSun = 227900000, OrbitalPeriod = 687, Mass = 0.642 });
            collection.Add(new DwarfPlanet() { Name = "Ceres", Picture = "https://solarstory.net/img/articles/big/image-of-ceres-taken-by-dawn-spacecraft.jpg", DistanceFromSun = 423000000, OrbitalPeriod = 1682, Mass = 9.1 });
            collection.Add(new DwarfPlanet() { Name = "Pluto", Picture = "https://solarstory.net/img/articles/big/full-disc-view-of-pluto-by-new-horizons.jpg", DistanceFromSun = 5900000000, OrbitalPeriod = 90560, Mass = 0.013 });
            collection.Add(new DwarfPlanet() { Name = "Eris", Picture = "https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-eris.jpg", DistanceFromSun = 10125000000, OrbitalPeriod = 203670, Mass = 1.67 });
            collection.Add(new DwarfPlanet() { Name = "Haumea", Picture = "https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-haumea.jpg", DistanceFromSun = 6452000000, OrbitalPeriod = 104192, Mass = 4.00 });
            collection.Add(new DwarfPlanet() { Name = "Makemake", Picture = "https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-makemake.jpg", DistanceFromSun = 847000000, OrbitalPeriod = 111690, Mass = 3.1 });
            collection.Add(new DwarfPlanet() { Name = "Makemake", Picture = "https://solarstory.net/img/articles/big/artists-impression-of-the-dwarf-planet-makemake.jpg", DistanceFromSun = 847000000, OrbitalPeriod = 111690, Mass = 3.1 });

            return collection;
        }
    }
}
