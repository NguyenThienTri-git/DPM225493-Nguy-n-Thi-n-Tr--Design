using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern02_BuilderReal
{
    class MotoBikeBuilder : VehicleBuilder
    {
        public MotoBikeBuilder() 
        {
            vehicle = new Vehicle("MotoBike");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "MotoBike Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "250 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}
