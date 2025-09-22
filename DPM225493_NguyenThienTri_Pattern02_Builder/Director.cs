using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern02_Builder
{
     class Director
    {
        public void Construct (Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
