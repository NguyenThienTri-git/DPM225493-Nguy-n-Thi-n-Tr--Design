using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern06_AdapterReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compound unknown = new Compound();
            unknown.Display();
            
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
           
            Console.ReadKey();
        }
    }
}
