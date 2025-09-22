using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern02_Builder
{
    class Product
    {
        private List<string> _part= new List<string>();
        public void Add(string part)
        {
            _part.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _part)
            {
                Console.WriteLine(part);
            }
        }
    }
}
