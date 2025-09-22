using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern02_BuilderReal
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder() {
            vehicle = new Vehicle("Car");
        }
        public override void BuildEngine()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildFrame()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildDoors()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildWheels()
        {
            vehicle["doors"] = "4";
        }
    }
}
