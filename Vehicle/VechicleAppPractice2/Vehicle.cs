using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
   public class Vehicle
    {
        public string vehiclename { set; get; }
        public int regno { set; get; }
        public  List<Double> speed = new List<double>();
        public Vehicle(string vehiclename,int regno)
        {
            this.vehiclename = vehiclename;
            this.regno = regno;
        }
    }
}
