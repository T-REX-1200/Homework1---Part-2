using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService
{
    public class Truck : Vehicle
    {
        public string TruckTrailer { get; set; }
        public Truck(string type, int wheels, int weight, string trailer) : base(type, wheels, weight)
        {
            TruckTrailer = trailer;
        }

        public override string Drive()
        {
            return $"This {VehicleType} weighs {VehicleWeight} tons with a {TruckTrailer} attached, so drive carefully";
        }
    }
}
