using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceTrack.RaceTrack.Cars
{
    public class HyundaiKona : RaceCar
    {
        public HyundaiKona()
        {
            Name = "Hyundai Kona";
            TopSpeed = 35;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life, albeit quietly.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}, arriving later than the rest.");
        }
    }
}