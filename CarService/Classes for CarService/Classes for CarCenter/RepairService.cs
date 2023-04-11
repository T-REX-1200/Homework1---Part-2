using CarService.Classes_for_CarService.Classes_for_CarCenter.Interfaces_for_CarCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService.Classes_for_CarCenter
{
    public class RepairService : iRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking the vehicle");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing the vehicle");
        }
    }
}
