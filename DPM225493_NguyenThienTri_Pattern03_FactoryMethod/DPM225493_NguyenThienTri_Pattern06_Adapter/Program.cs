using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern06_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
           
            Console.ReadKey();
        }
    }
}
