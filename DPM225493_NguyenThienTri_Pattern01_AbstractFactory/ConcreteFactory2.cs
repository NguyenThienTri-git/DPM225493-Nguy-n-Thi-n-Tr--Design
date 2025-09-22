using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern01_AbstractFactory
{
    internal class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProduct1 CreateProductA()
        {
            return new Product1B();
        }

        public override AbstractProduct2 CreateProductB()
        {
            return new Product2B();
        }
    }
}
