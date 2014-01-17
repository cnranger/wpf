using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public class Vehicle
    {
        public Vehicle(string make, string model, VehicleEnvironment environment, string photoName)
        {
            PhotoName = photoName;
            Environment = environment;
            Model = model;
            Make = make;
        }

        public string Make { get; private set; }
        public string Model { get; private set; }
        public VehicleEnvironment Environment { get; private set; }
        public string PhotoName { get; private set; }
    }
}