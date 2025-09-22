using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern04_PrototypeReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);
            colormanager["light washed yellow"] = new Color(224, 216, 58);
            colormanager["violet"] = new Color(137, 42, 219);
            colormanager["magenta"] = new Color(135, 33, 121);

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["violet"].Clone() as Color;
            Color color3 = colormanager["blue"].Clone() as Color;
            
            Console.ReadKey();
        }
    }
}
