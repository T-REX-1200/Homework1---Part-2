using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService
{
    public abstract class Vehicle
    {
        public string VehicleType { get; set; } = string.Empty;
        public int NumberOfWheels { get; set; }
        public int VehicleWeight { get; set; }
        public abstract string Drive();

        public Vehicle(string type,int wheels,int weight)
        {
            VehicleType = type;
            NumberOfWheels = wheels;
            VehicleWeight = weight;
        }
    }
}
