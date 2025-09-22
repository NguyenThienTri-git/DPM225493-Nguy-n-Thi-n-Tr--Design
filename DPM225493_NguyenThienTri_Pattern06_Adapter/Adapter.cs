using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern06_Adapter
{
    internal class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            
            adaptee.SpecificRequest();
        }
    }
}
