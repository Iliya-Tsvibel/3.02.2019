using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Car : VehicleBase
    {
        // DATA
        public int _numberOfDoors;

        public override int GetMaxNumOfPassengers()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 210;
        }

        public override string ToString()
        {
            return $"Car model = {_numberOfDoors} { base.ToString()}";
        }
    }
}
