using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern01_AbstractFactoryReal
{
    class AmericaFacroty : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new GrayWolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Deer();
        }
    }
}
