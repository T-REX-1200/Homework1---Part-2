using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Classes_for_CarService
{
    public class Car : Vehicle
    {
        public string CarBrand { get; set; }
        public int HorsePower { get; set; }
        public Car(string type, int wheels, int weight, string brand, int hp) : base(type, wheels, weight)
        {
            CarBrand = brand;
            HorsePower = hp;
        }

        public override string Drive()
        {
            return $"{CarBrand} goes brmmmmmmmm brmmmmmmmmm";
        }
    }
}
