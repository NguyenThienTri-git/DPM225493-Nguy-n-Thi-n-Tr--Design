using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern01_AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProduct1 CreateProductA() ;
        public abstract AbstractProduct2 CreateProductB() ;

    }
}
