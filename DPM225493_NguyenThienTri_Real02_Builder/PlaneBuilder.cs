using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern02_BuilderReal
{
    class PlaneBuilder : VehicleBuilder
    {
        public PlaneBuilder()
        {
            vehicle = new Vehicle("Plane Boeing 777");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Boeing Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "General Electric (GE)";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "14";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "10";
        }
    }
}
