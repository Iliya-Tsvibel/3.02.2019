using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class VehicleBase
    {
        // DATA
        public int _numberOfWheels;
        public string _model;
        // FUNCTIONALITY
        public abstract int GetMaxNumOfPassengers();

        public abstract int GetMaxSpeed();

        public override string ToString()

        { 
        return $"Car model = {_model} number of wheels = {_numberOfWheels} max number of passengers = {GetMaxNumOfPassengers()} max speed = {GetMaxSpeed()}";
        }

}
}
