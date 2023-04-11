using CarService.Classes_for_CarService.Classes_for_CarCenter.Interfaces_for_CarCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService
{
    public class CarCenter : iCarWash , iGasPump , iRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking the vehicle for damages");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Repairing the vehicle");
        }

        public void PumpCas()
        {
            Console.WriteLine("Pumping gas");
        }

        public void WashCar()
        {
            Console.WriteLine("Washing the car");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing the trailer");
        }
    }

    
}
