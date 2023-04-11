using CarService.Classes_for_CarService.Classes_for_CarCenter.Interfaces_for_CarCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService.Classes_for_CarCenter
{
    public class CarWash : iCarWash
    {
        public void WashCar()
        {
            Console.WriteLine("These services can be aplied to cars only");
        }

        public void WashTrailer()
        {
            Console.WriteLine("These services can be aplied to trailers only");
        }
    }
}
