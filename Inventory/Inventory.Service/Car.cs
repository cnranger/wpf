using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    public class Car : Vehicle
    {
        public Car(string make, string model, VehicleEnvironment environment,
            string photoName, int numberOfWheels, double topSpeedKph,
            DriverSide side, Review companyReview)
            : base(make, model, environment, photoName)
        {
            NumberOfWheels = numberOfWheels;
            TopSpeedKph = topSpeedKph;
            Side = side;
            CompanyReview = companyReview;
        }

        public int NumberOfWheels { get; private set; }
        public double TopSpeedKph { get; private set; }
        public DriverSide Side { get; private set; }
        public Review CompanyReview { get; private set; }
    }
}
