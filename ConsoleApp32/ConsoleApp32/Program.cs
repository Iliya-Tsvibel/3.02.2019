using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {

            Car mit = new Car
            {
                _numberOfWheels = 4,
                _model = "Mitsubisy",
                _numberOfDoors = 5,
            };

            Car toy = new Car
            {
                _numberOfWheels = 4,
                _model = "Toyota",
                _numberOfDoors = 5,
            };

            Motorcycle har = new Motorcycle
            {
                _numberOfWheels = 2,
                _model = "Harley",
                _numberOfHandBreakes = 2,
            };

            Motorcycle suz = new Motorcycle
            {
                _numberOfWheels = 2,
                _model = "Suzuki",
                _numberOfHandBreakes = 2,
            };





            VehicleBase[] _vehicle =
                { new Car {
                _numberOfWheels = 4,
                _model = "Mitsubisy",
                _numberOfDoors = 5,
            }, new Car {
                _numberOfWheels = 4,
                _model = "Toyota",
                _numberOfDoors = 5,
            }, new Motorcycle {
                _numberOfWheels = 2,
                _model = "Harley",
                _numberOfHandBreakes = 2,
            }, };

            PrintManyVehicle(_vehicle);
            PrintVehicle(_vehicle[0]);

        }
        
        private static void PrintManyVehicle(VehicleBase[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        static void PrintVehicle(VehicleBase v)
            {
            Console.WriteLine(v._model);
            }

        
    }
}
