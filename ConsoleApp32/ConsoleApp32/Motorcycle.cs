using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Motorcycle : VehicleBase
    {
        // DATA
        public int _numberOfHandBreakes;

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 180;
        }

        public override string ToString()
        {
            return $"Car model = {_numberOfHandBreakes}" + base.ToString();
        }
    }
}
